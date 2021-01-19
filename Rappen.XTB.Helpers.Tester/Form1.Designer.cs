namespace Rappen.XTB.Helpers.Tester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntityFilter = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.rbPropOptionset = new System.Windows.Forms.RadioButton();
            this.rbPropAttribute = new System.Windows.Forms.RadioButton();
            this.rbPropGrid = new System.Windows.Forms.RadioButton();
            this.rbPropText = new System.Windows.Forms.RadioButton();
            this.rbPropView = new System.Windows.Forms.RadioButton();
            this.rbPropEntities = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.rbPropLookup = new System.Windows.Forms.RadioButton();
            this.rbPropCheckbox = new System.Windows.Forms.RadioButton();
            this.txtRecord = new Rappen.XTB.Helpers.Controls.XRMRecordTextBox();
            this.chkCheckBox = new Rappen.XTB.Helpers.Controls.XRMRecordCheckBox();
            this.cmbOptions = new Rappen.XTB.Helpers.Controls.XRMOptionSetComboBox();
            this.cmbAttributes = new Rappen.XTB.Helpers.Controls.XRMAttributeComboBox();
            this.txtFetch = new Rappen.XTB.Helpers.Controls.XRMRecordTextBox();
            this.cmbViews = new Rappen.XTB.Helpers.Controls.XRMDataComboBox();
            this.cmbEntities = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.gridData = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.xrmLookupDialog1 = new Rappen.XTB.Helpers.Controls.XRMLookupDialog();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1101, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(23, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(302, 617);
            this.propertyGrid1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridData);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 601);
            this.splitContainer1.SplitterDistance = 662;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnLookup);
            this.splitContainer2.Panel1.Controls.Add(this.txtRecord);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.chkCheckBox);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.cmbOptions);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.cmbAttributes);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txtEntityFilter);
            this.splitContainer2.Panel1.Controls.Add(this.btnExecute);
            this.splitContainer2.Panel1.Controls.Add(this.lblConnection);
            this.splitContainer2.Panel1.Controls.Add(this.btnConnect);
            this.splitContainer2.Panel1.Controls.Add(this.txtFetch);
            this.splitContainer2.Panel1.Controls.Add(this.cmbViews);
            this.splitContainer2.Panel1.Controls.Add(this.cmbEntities);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rbPropCheckbox);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropLookup);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropOptionset);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropAttribute);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropGrid);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropText);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropView);
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropEntities);
            this.splitContainer2.Size = new System.Drawing.Size(662, 601);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Checkbox";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Optionset";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Attribute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "View FetchXML";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Entity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter entities";
            // 
            // txtEntityFilter
            // 
            this.txtEntityFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntityFilter.Location = new System.Drawing.Point(96, 51);
            this.txtEntityFilter.Name = "txtEntityFilter";
            this.txtEntityFilter.Size = new System.Drawing.Size(207, 20);
            this.txtEntityFilter.TabIndex = 20;
            this.txtEntityFilter.TextChanged += new System.EventHandler(this.txtEntityFilter_TextChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExecute.Location = new System.Drawing.Point(12, 351);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 60;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(93, 17);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(78, 13);
            this.lblConnection.TabIndex = 4;
            this.lblConnection.Text = "Not connected";
            // 
            // rbPropOptionset
            // 
            this.rbPropOptionset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropOptionset.AutoSize = true;
            this.rbPropOptionset.Location = new System.Drawing.Point(3, 541);
            this.rbPropOptionset.Name = "rbPropOptionset";
            this.rbPropOptionset.Size = new System.Drawing.Size(14, 13);
            this.rbPropOptionset.TabIndex = 9;
            this.rbPropOptionset.UseVisualStyleBackColor = true;
            this.rbPropOptionset.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropAttribute
            // 
            this.rbPropAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropAttribute.AutoSize = true;
            this.rbPropAttribute.Location = new System.Drawing.Point(3, 514);
            this.rbPropAttribute.Name = "rbPropAttribute";
            this.rbPropAttribute.Size = new System.Drawing.Size(14, 13);
            this.rbPropAttribute.TabIndex = 8;
            this.rbPropAttribute.UseVisualStyleBackColor = true;
            this.rbPropAttribute.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropGrid
            // 
            this.rbPropGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPropGrid.AutoSize = true;
            this.rbPropGrid.Location = new System.Drawing.Point(331, 41);
            this.rbPropGrid.Name = "rbPropGrid";
            this.rbPropGrid.Size = new System.Drawing.Size(14, 13);
            this.rbPropGrid.TabIndex = 6;
            this.rbPropGrid.UseVisualStyleBackColor = true;
            this.rbPropGrid.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropText
            // 
            this.rbPropText.AutoSize = true;
            this.rbPropText.Location = new System.Drawing.Point(3, 155);
            this.rbPropText.Name = "rbPropText";
            this.rbPropText.Size = new System.Drawing.Size(14, 13);
            this.rbPropText.TabIndex = 2;
            this.rbPropText.UseVisualStyleBackColor = true;
            this.rbPropText.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropView
            // 
            this.rbPropView.AutoSize = true;
            this.rbPropView.Location = new System.Drawing.Point(3, 108);
            this.rbPropView.Name = "rbPropView";
            this.rbPropView.Size = new System.Drawing.Size(14, 13);
            this.rbPropView.TabIndex = 1;
            this.rbPropView.UseVisualStyleBackColor = true;
            this.rbPropView.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropEntities
            // 
            this.rbPropEntities.AutoSize = true;
            this.rbPropEntities.Location = new System.Drawing.Point(3, 80);
            this.rbPropEntities.Name = "rbPropEntities";
            this.rbPropEntities.Size = new System.Drawing.Size(14, 13);
            this.rbPropEntities.TabIndex = 0;
            this.rbPropEntities.UseVisualStyleBackColor = true;
            this.rbPropEntities.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Record";
            // 
            // btnLookup
            // 
            this.btnLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLookup.Location = new System.Drawing.Point(270, 391);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(33, 23);
            this.btnLookup.TabIndex = 72;
            this.btnLookup.Text = "lkp";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // rbPropLookup
            // 
            this.rbPropLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropLookup.AutoSize = true;
            this.rbPropLookup.Location = new System.Drawing.Point(3, 396);
            this.rbPropLookup.Name = "rbPropLookup";
            this.rbPropLookup.Size = new System.Drawing.Size(14, 13);
            this.rbPropLookup.TabIndex = 10;
            this.rbPropLookup.UseVisualStyleBackColor = true;
            this.rbPropLookup.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropCheckbox
            // 
            this.rbPropCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropCheckbox.AutoSize = true;
            this.rbPropCheckbox.Location = new System.Drawing.Point(3, 567);
            this.rbPropCheckbox.Name = "rbPropCheckbox";
            this.rbPropCheckbox.Size = new System.Drawing.Size(14, 13);
            this.rbPropCheckbox.TabIndex = 11;
            this.rbPropCheckbox.UseVisualStyleBackColor = true;
            this.rbPropCheckbox.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // txtRecord
            // 
            this.txtRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecord.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecord.DisplayFormat = "";
            this.txtRecord.Entity = null;
            this.txtRecord.EntityReference = null;
            this.txtRecord.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.txtRecord.Location = new System.Drawing.Point(96, 392);
            this.txtRecord.LogicalName = null;
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Service = null;
            this.txtRecord.Size = new System.Drawing.Size(168, 20);
            this.txtRecord.TabIndex = 71;
            // 
            // chkCheckBox
            // 
            this.chkCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCheckBox.Attribute = "";
            this.chkCheckBox.AutoSize = true;
            this.chkCheckBox.Entity = null;
            this.chkCheckBox.EntityReference = null;
            this.chkCheckBox.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.chkCheckBox.Location = new System.Drawing.Point(96, 566);
            this.chkCheckBox.LogicalName = null;
            this.chkCheckBox.Name = "chkCheckBox";
            this.chkCheckBox.Service = null;
            this.chkCheckBox.Size = new System.Drawing.Size(15, 14);
            this.chkCheckBox.TabIndex = 69;
            this.chkCheckBox.UseVisualStyleBackColor = true;
            // 
            // cmbOptions
            // 
            this.cmbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Location = new System.Drawing.Point(96, 538);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(207, 21);
            this.cmbOptions.TabIndex = 66;
            // 
            // cmbAttributes
            // 
            this.cmbAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAttributes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttributes.FormattingEnabled = true;
            this.cmbAttributes.Location = new System.Drawing.Point(96, 511);
            this.cmbAttributes.Name = "cmbAttributes";
            this.cmbAttributes.Size = new System.Drawing.Size(207, 21);
            this.cmbAttributes.TabIndex = 64;
            this.cmbAttributes.SelectedIndexChanged += new System.EventHandler(this.xrmAttributeComboBox1_SelectedIndexChanged);
            // 
            // txtFetch
            // 
            this.txtFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFetch.BackColor = System.Drawing.SystemColors.Window;
            this.txtFetch.DisplayFormat = "fetchxml";
            this.txtFetch.Entity = null;
            this.txtFetch.EntityReference = null;
            this.txtFetch.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.txtFetch.Location = new System.Drawing.Point(12, 152);
            this.txtFetch.LogicalName = null;
            this.txtFetch.Multiline = true;
            this.txtFetch.Name = "txtFetch";
            this.txtFetch.Service = null;
            this.txtFetch.Size = new System.Drawing.Size(291, 193);
            this.txtFetch.TabIndex = 50;
            // 
            // cmbViews
            // 
            this.cmbViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbViews.DisplayFormat = "";
            this.cmbViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViews.FormattingEnabled = true;
            this.cmbViews.Location = new System.Drawing.Point(96, 105);
            this.cmbViews.Name = "cmbViews";
            this.cmbViews.Service = null;
            this.cmbViews.Size = new System.Drawing.Size(207, 21);
            this.cmbViews.TabIndex = 40;
            this.cmbViews.SelectedIndexChanged += new System.EventHandler(this.xrmDataComboBox1_SelectedIndexChanged);
            // 
            // cmbEntities
            // 
            this.cmbEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Location = new System.Drawing.Point(96, 77);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(207, 21);
            this.cmbEntities.TabIndex = 30;
            this.cmbEntities.SelectedIndexChanged += new System.EventHandler(this.xrmEntityComboBox1_SelectedIndexChanged);
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToOrderColumns = true;
            this.gridData.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.ColumnOrder = "";
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.FilterColumns = "";
            this.gridData.Location = new System.Drawing.Point(0, 0);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersVisible = false;
            this.gridData.Service = null;
            this.gridData.ShowFriendlyNames = true;
            this.gridData.ShowIdColumn = false;
            this.gridData.ShowIndexColumn = false;
            this.gridData.ShowLocalTimes = true;
            this.gridData.Size = new System.Drawing.Size(431, 601);
            this.gridData.TabIndex = 0;
            // 
            // xrmLookupDialog1
            // 
            this.xrmLookupDialog1.Entity = null;
            this.xrmLookupDialog1.LogicalName = "";
            this.xrmLookupDialog1.LogicalNames = null;
            this.xrmLookupDialog1.Service = null;
            this.xrmLookupDialog1.Title = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 623);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Rappen.XTB.Helpers.Tester";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rappen.XTB.Helpers.Controls.XRMRecordTextBox txtFetch;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox cmbEntities;
        private System.Windows.Forms.Button btnConnect;
        private Rappen.XTB.Helpers.Controls.XRMDataComboBox cmbViews;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RadioButton rbPropText;
        private System.Windows.Forms.RadioButton rbPropView;
        private System.Windows.Forms.RadioButton rbPropEntities;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.RadioButton rbPropGrid;
        private Rappen.XTB.Helpers.Controls.XRMDataGridView gridData;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntityFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Controls.XRMOptionSetComboBox cmbOptions;
        private System.Windows.Forms.Label label5;
        private Controls.XRMAttributeComboBox cmbAttributes;
        private System.Windows.Forms.RadioButton rbPropOptionset;
        private System.Windows.Forms.RadioButton rbPropAttribute;
        private Controls.XRMRecordCheckBox chkCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLookup;
        private Controls.XRMRecordTextBox txtRecord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPropLookup;
        private Controls.XRMLookupDialog xrmLookupDialog1;
        private System.Windows.Forms.RadioButton rbPropCheckbox;
    }
}

