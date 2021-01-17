using McTools.Xrm.Connection;
using McTools.Xrm.Connection.WinForms;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
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
            xrmDataComboBox1.Service = service;
            xrmDataTextBox1.Service = service;
            xrmGridView1.Service = service;
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
            xrmEntityComboBox1.DataSource = null;
            toolStripStatusLabel1.Text = e.CurrentStep;
        }

        private void LoadEntities()
        {
            entities = service.LoadEntities().EntityMetadata;
            FilterEntities();
        }

        private void FilterEntities()
        {
            xrmDataComboBox1.SelectedIndex = -1;
            var filter = txtEntityFilter.Text.Trim().ToLowerInvariant();
            var contains = filter.StartsWith("*");
            filter = filter.Trim('*');
            xrmEntityComboBox1.DataSource = entities
                .Where(e => FilterEntity(e, filter, contains, xrmEntityComboBox1.ShowFriendlyNames))
                .OrderBy(e => OrderEntity(e, xrmEntityComboBox1.ShowFriendlyNames));
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
            xrmDataTextBox1.Entity = null;
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
            xrmDataComboBox1.DataSource = views;
        }

        private void GetData()
        {
            var data = service.RetrieveMultiple(new FetchExpression(xrmDataTextBox1.Text));
            xrmGridView1.DataSource = data;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            formHelper.AskForConnection(null);
        }

        private void xrmEntityComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadViews(xrmEntityComboBox1.SelectedEntity);
        }

        private void xrmDataComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            xrmDataTextBox1.Entity = xrmDataComboBox1.SelectedEntity;
        }

        private void rbProp_CheckedChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject =
                rbPropEntities.Checked ? (Control)xrmEntityComboBox1 :
                rbPropView.Checked ? (Control)xrmDataComboBox1 :
                rbPropText.Checked ? (Control)xrmDataTextBox1 :
                rbPropGrid.Checked ? (Control)xrmGridView1 :
                null;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtEntityFilter_TextChanged(object sender, EventArgs e)
        {
            FilterEntities();
        }
    }
}
