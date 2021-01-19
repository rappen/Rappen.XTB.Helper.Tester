﻿using McTools.Xrm.Connection;
using McTools.Xrm.Connection.WinForms;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XTB.Helpers.Controls;
using Rappen.XTB.Helpers.Extensions;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Rappen.XTB.Helpers.Tester
{
    public partial class Form1 : Form
    {
        private IOrganizationService service;
        private ConnectionDetail currentDetail;
        private ConnectionManager cManager;
        private FormHelper formHelper;
        private EntityMetadataCollection entities;

        public Form1()
        {
            InitializeComponent();
            cManager = ConnectionManager.Instance;
            cManager.FromXrmToolBox = true;
            cManager.ConnectionSucceed += new ConnectionManager.ConnectionSucceedEventHandler(cManager_ConnectionSucceed);
            cManager.ConnectionFailed += new ConnectionManager.ConnectionFailedEventHandler(cManager_ConnectionFailed);
            cManager.StepChanged += new ConnectionManager.StepChangedEventHandler(cManager_StepChanged);
            cManager.RequestPassword += new ConnectionManager.RequestPasswordEventHandler(cManager_RequestPassword);
            formHelper = new FormHelper(this);
        }

        private void cManager_ConnectionSucceed(object sender, ConnectionSucceedEventArgs e)
        {
            lblConnection.Text = e.ConnectionDetail.ToString();
            service = e.OrganizationService;
            currentDetail = e.ConnectionDetail;
            cmbViews.Service = service;
            txtFetch.Service = service;
            xrmLookupDialog1.Service = service;
            chkCheckBox.Service = service;
            gridData.Service = service;
            LoadEntities();
        }

        private void cManager_ConnectionFailed(object sender, ConnectionFailedEventArgs e)
        {
            lblConnection.Text = "Not connected";
            service = null;
            currentDetail = null;
        }

        private bool cManager_RequestPassword(object sender, RequestPasswordEventArgs e)
        {
            //
            return true;
        }

        private void cManager_StepChanged(object sender, StepChangedEventArgs e)
        {
            cmbEntities.DataSource = null;
            toolStripStatusLabel1.Text = e.CurrentStep;
        }

        private void LoadEntities()
        {
            entities = service.LoadEntities().EntityMetadata;
            FilterEntities();
        }

        private void FilterEntities()
        {
            cmbViews.SelectedIndex = -1;
            var filter = txtEntityFilter.Text.Trim().ToLowerInvariant();
            var contains = filter.StartsWith("*");
            filter = filter.Trim('*');
            cmbEntities.DataSource = entities.Where(e => FilterEntity(e, filter, contains, cmbEntities.ShowFriendlyNames));
        }

        private bool FilterEntity(EntityMetadata entity, string filter, bool contains, bool friendly)
        {
            var logical = entity.LogicalName.ToLowerInvariant();
            var name = (entity.DisplayName?.UserLocalizedLabel?.Label ?? string.Empty).ToLowerInvariant();
            if (friendly && string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            if (contains)
            {
                return logical.Contains(filter) || name.Contains(filter);
            }
            return logical.StartsWith(filter) || name.StartsWith(filter);
        }

        private object OrderEntity(EntityMetadata entity, bool friendly)
        {
            return friendly ? entity.DisplayName?.UserLocalizedLabel?.Label : entity.LogicalName ?? entity.LogicalName;
        }

        private void LoadViews(EntityMetadata entity)
        {
            txtFetch.Entity = null;
            if (entity == null)
            {
                return;
            }
            var query = new QueryExpression("savedquery");
            query.ColumnSet.AddColumns("name", "fetchxml");
            query.AddOrder("querytype", OrderType.Ascending);
            query.AddOrder("name", OrderType.Ascending);
            query.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, entity.LogicalName);
            var views = service.RetrieveMultiple(query);
            cmbViews.DataSource = views;
        }

        private void GetData()
        {
            var data = service.RetrieveMultiple(new FetchExpression(txtFetch.Text));
            gridData.DataSource = data;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            formHelper.AskForConnection(null);
        }

        private void xrmEntityComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enabled = false;
            cmbViews.DataSource = null;
            cmbAttributes.DataSource = null;
            cmbOptions.DataSource = null;
            txtFetch.Entity = null;
            try
            {
                if (cmbEntities.SelectedEntity is EntityMetadata entity)
                {
                    xrmLookupDialog1.LogicalName = entity.LogicalName;
                    LoadViews(cmbEntities.SelectedEntity);
                    if (entity.Attributes == null)
                    {
                        entity = service.GetEntity(entity.LogicalName);
                    }
                    cmbAttributes.DataSource = entity;
                }
            }
            finally
            {
                Enabled = true;
            }
        }

        private void xrmDataComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFetch.Entity = cmbViews.SelectedEntity;
        }

        private void rbProp_CheckedChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject =
                rbPropEntities.Checked ? cmbEntities :
                rbPropView.Checked ? cmbViews :
                rbPropText.Checked ? txtFetch :
                rbPropAttribute.Checked ? cmbAttributes :
                rbPropOptionset.Checked ? cmbOptions :
                rbPropCheckbox.Checked ? chkCheckBox :
                rbPropGrid.Checked ? (Control)gridData :
                null;
            if (rbPropLookup.Checked)
            {
                propertyGrid1.SelectedObject = xrmLookupDialog1;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtEntityFilter_TextChanged(object sender, EventArgs e)
        {
            FilterEntities();
        }

        private void xrmAttributeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAttributes.SelectedAttribute is EnumAttributeMetadata attr)
            {
                cmbOptions.DataSource = attr.OptionSet;
            }
            else
            {
                cmbOptions.DataSource = null;
            }
            cmbOptions.Enabled = cmbOptions.DataSource != null;
            if (cmbAttributes.SelectedAttribute is BooleanAttributeMetadata boolattr)
            {
                chkCheckBox.Attribute = boolattr.LogicalName;
                chkCheckBox.Enabled = true;
            }
            else
            {
                chkCheckBox.Enabled = false;
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            if (xrmLookupDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtRecord.Entity = xrmLookupDialog1.Entity;
                chkCheckBox.Entity = xrmLookupDialog1.Entity;
            }
        }
    }
}
