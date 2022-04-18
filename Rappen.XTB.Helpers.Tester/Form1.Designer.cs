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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.rbPropLookup = new System.Windows.Forms.RadioButton();
            this.rbPropText = new System.Windows.Forms.RadioButton();
            this.rbPropCheckbox = new System.Windows.Forms.RadioButton();
            this.rbPropLookupDlg = new System.Windows.Forms.RadioButton();
            this.rbPropOptionset = new System.Windows.Forms.RadioButton();
            this.rbPropAttribute = new System.Windows.Forms.RadioButton();
            this.rbPropGrid = new System.Windows.Forms.RadioButton();
            this.rbPropFetch = new System.Windows.Forms.RadioButton();
            this.rbPropView = new System.Windows.Forms.RadioButton();
            this.rbPropEntities = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rbPropDateTime = new System.Windows.Forms.RadioButton();
            this.pickDateTime = new Rappen.XTB.Helpers.Controls.XRMColumnDateTime();
            this.xrmRecordSelected = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.cmbLookup = new Rappen.XTB.Helpers.Controls.XRMColumnLookup();
            this.xrmRecordText = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.txtRecord = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.chkCheckBox = new Rappen.XTB.Helpers.Controls.XRMColumnBool();
            this.cmbOptions = new Rappen.XTB.Helpers.Controls.XRMColumnOptionSet();
            this.cmbAttributes = new Rappen.XTB.Helpers.Controls.XRMAttributeComboBox();
            this.txtFetch = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.xrmRecordView = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.cmbViews = new Rappen.XTB.Helpers.Controls.XRMColumnLookup();
            this.cmbEntities = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.gridData = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.xrmLookupDialog1 = new Rappen.XTB.Helpers.Controls.XRMLookupDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.numNumber = new Rappen.XTB.Helpers.Controls.XRMColumnNumber();
            this.rbPropNumber = new System.Windows.Forms.RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
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
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
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
            this.propertyGrid1.Size = new System.Drawing.Size(281, 601);
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
            this.splitContainer2.Panel1.Controls.Add(this.numNumber);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.pickDateTime);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.cmbLookup);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.btnSave);
            this.splitContainer2.Panel1.Controls.Add(this.xrmRecordText);
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
            this.splitContainer2.Panel2.Controls.Add(this.rbPropNumber);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropDateTime);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropLookup);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropText);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropCheckbox);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropLookupDlg);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropOptionset);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropAttribute);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropGrid);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropFetch);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropView);
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropEntities);
            this.splitContainer2.Size = new System.Drawing.Size(662, 601);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Lookup";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Text";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(96, 563);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLookup
            // 
            this.btnLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLookup.Location = new System.Drawing.Point(270, 328);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(33, 23);
            this.btnLookup.TabIndex = 72;
            this.btnLookup.Text = "lkp";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Record";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Checkbox";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Optionset";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 358);
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
            this.btnExecute.Location = new System.Drawing.Point(12, 294);
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
            // rbPropLookup
            // 
            this.rbPropLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropLookup.AutoSize = true;
            this.rbPropLookup.Location = new System.Drawing.Point(3, 439);
            this.rbPropLookup.Name = "rbPropLookup";
            this.rbPropLookup.Size = new System.Drawing.Size(14, 13);
            this.rbPropLookup.TabIndex = 13;
            this.rbPropLookup.UseVisualStyleBackColor = true;
            this.rbPropLookup.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropText
            // 
            this.rbPropText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropText.AutoSize = true;
            this.rbPropText.Location = new System.Drawing.Point(3, 385);
            this.rbPropText.Name = "rbPropText";
            this.rbPropText.Size = new System.Drawing.Size(14, 13);
            this.rbPropText.TabIndex = 12;
            this.rbPropText.UseVisualStyleBackColor = true;
            this.rbPropText.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropCheckbox
            // 
            this.rbPropCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropCheckbox.AutoSize = true;
            this.rbPropCheckbox.Location = new System.Drawing.Point(3, 462);
            this.rbPropCheckbox.Name = "rbPropCheckbox";
            this.rbPropCheckbox.Size = new System.Drawing.Size(14, 13);
            this.rbPropCheckbox.TabIndex = 11;
            this.rbPropCheckbox.UseVisualStyleBackColor = true;
            this.rbPropCheckbox.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropLookupDlg
            // 
            this.rbPropLookupDlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropLookupDlg.AutoSize = true;
            this.rbPropLookupDlg.Location = new System.Drawing.Point(3, 333);
            this.rbPropLookupDlg.Name = "rbPropLookupDlg";
            this.rbPropLookupDlg.Size = new System.Drawing.Size(14, 13);
            this.rbPropLookupDlg.TabIndex = 10;
            this.rbPropLookupDlg.UseVisualStyleBackColor = true;
            this.rbPropLookupDlg.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropOptionset
            // 
            this.rbPropOptionset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropOptionset.AutoSize = true;
            this.rbPropOptionset.Location = new System.Drawing.Point(3, 411);
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
            this.rbPropAttribute.Location = new System.Drawing.Point(3, 358);
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
            this.rbPropGrid.Location = new System.Drawing.Point(309, 39);
            this.rbPropGrid.Name = "rbPropGrid";
            this.rbPropGrid.Size = new System.Drawing.Size(14, 13);
            this.rbPropGrid.TabIndex = 6;
            this.rbPropGrid.UseVisualStyleBackColor = true;
            this.rbPropGrid.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropFetch
            // 
            this.rbPropFetch.AutoSize = true;
            this.rbPropFetch.Location = new System.Drawing.Point(3, 155);
            this.rbPropFetch.Name = "rbPropFetch";
            this.rbPropFetch.Size = new System.Drawing.Size(14, 13);
            this.rbPropFetch.TabIndex = 2;
            this.rbPropFetch.UseVisualStyleBackColor = true;
            this.rbPropFetch.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
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
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 485);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "DateTime";
            // 
            // rbPropDateTime
            // 
            this.rbPropDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropDateTime.AutoSize = true;
            this.rbPropDateTime.Location = new System.Drawing.Point(3, 485);
            this.rbPropDateTime.Name = "rbPropDateTime";
            this.rbPropDateTime.Size = new System.Drawing.Size(14, 13);
            this.rbPropDateTime.TabIndex = 14;
            this.rbPropDateTime.UseVisualStyleBackColor = true;
            this.rbPropDateTime.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // pickDateTime
            // 
            this.pickDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickDateTime.Column = "modifiedon";
            this.pickDateTime.Location = new System.Drawing.Point(96, 482);
            this.pickDateTime.Name = "pickDateTime";
            this.pickDateTime.RecordHost = this.xrmRecordSelected;
            this.pickDateTime.Size = new System.Drawing.Size(207, 20);
            this.pickDateTime.TabIndex = 80;
            this.pickDateTime.ValueChanged += new System.EventHandler(this.pickDateTime_ValueChanged);
            // 
            // xrmRecordSelected
            // 
            this.xrmRecordSelected.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.xrmRecordSelected.LogicalName = null;
            this.xrmRecordSelected.Record = null;
            this.xrmRecordSelected.Service = null;
            // 
            // cmbLookup
            // 
            this.cmbLookup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLookup.Column = null;
            this.cmbLookup.DisplayFormat = "";
            this.cmbLookup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLookup.Filter = null;
            this.cmbLookup.FormattingEnabled = true;
            this.cmbLookup.Location = new System.Drawing.Point(96, 435);
            this.cmbLookup.Name = "cmbLookup";
            this.cmbLookup.OnlyActiveRecords = false;
            this.cmbLookup.RecordHost = this.xrmRecordSelected;
            this.cmbLookup.Service = null;
            this.cmbLookup.Size = new System.Drawing.Size(207, 21);
            this.cmbLookup.TabIndex = 77;
            // 
            // xrmRecordText
            // 
            this.xrmRecordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xrmRecordText.Column = "";
            this.xrmRecordText.DisplayFormat = "name";
            this.xrmRecordText.Location = new System.Drawing.Point(96, 382);
            this.xrmRecordText.Name = "xrmRecordText";
            this.xrmRecordText.ReadOnly = true;
            this.xrmRecordText.RecordHost = this.xrmRecordSelected;
            this.xrmRecordText.Size = new System.Drawing.Size(207, 20);
            this.xrmRecordText.TabIndex = 74;
            // 
            // txtRecord
            // 
            this.txtRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecord.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecord.Column = null;
            this.txtRecord.DisplayFormat = "";
            this.txtRecord.Location = new System.Drawing.Point(96, 329);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.ReadOnly = true;
            this.txtRecord.RecordHost = this.xrmRecordSelected;
            this.txtRecord.Size = new System.Drawing.Size(168, 20);
            this.txtRecord.TabIndex = 71;
            // 
            // chkCheckBox
            // 
            this.chkCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCheckBox.AutoSize = true;
            this.chkCheckBox.Column = "";
            this.chkCheckBox.Location = new System.Drawing.Point(96, 462);
            this.chkCheckBox.Name = "chkCheckBox";
            this.chkCheckBox.RecordHost = this.xrmRecordSelected;
            this.chkCheckBox.Size = new System.Drawing.Size(15, 14);
            this.chkCheckBox.TabIndex = 69;
            this.chkCheckBox.UseVisualStyleBackColor = true;
            // 
            // cmbOptions
            // 
            this.cmbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOptions.Column = null;
            this.cmbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Location = new System.Drawing.Point(96, 408);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.RecordHost = this.xrmRecordSelected;
            this.cmbOptions.Size = new System.Drawing.Size(207, 21);
            this.cmbOptions.TabIndex = 66;
            // 
            // cmbAttributes
            // 
            this.cmbAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAttributes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttributes.FormattingEnabled = true;
            this.cmbAttributes.Location = new System.Drawing.Point(96, 355);
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
            this.txtFetch.Column = "fetchxml";
            this.txtFetch.DisplayFormat = "";
            this.txtFetch.Location = new System.Drawing.Point(12, 152);
            this.txtFetch.Multiline = true;
            this.txtFetch.Name = "txtFetch";
            this.txtFetch.RecordHost = this.xrmRecordView;
            this.txtFetch.Size = new System.Drawing.Size(291, 137);
            this.txtFetch.TabIndex = 50;
            // 
            // xrmRecordView
            // 
            this.xrmRecordView.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.xrmRecordView.LogicalName = null;
            this.xrmRecordView.Record = null;
            this.xrmRecordView.Service = null;
            // 
            // cmbViews
            // 
            this.cmbViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbViews.Column = null;
            this.cmbViews.DisplayFormat = "";
            this.cmbViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViews.Filter = null;
            this.cmbViews.FormattingEnabled = true;
            this.cmbViews.Location = new System.Drawing.Point(96, 105);
            this.cmbViews.Name = "cmbViews";
            this.cmbViews.RecordHost = null;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.ColumnOrder = "";
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.FilterColumns = "";
            this.gridData.Location = new System.Drawing.Point(0, 0);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersVisible = false;
            this.gridData.RowHeadersWidth = 72;
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
            this.xrmLookupDialog1.AdditionalViews = ((System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>>)(resources.GetObject("xrmLookupDialog1.AdditionalViews")));
            this.xrmLookupDialog1.LogicalName = "";
            this.xrmLookupDialog1.LogicalNames = null;
            this.xrmLookupDialog1.Record = null;
            this.xrmLookupDialog1.Service = null;
            this.xrmLookupDialog1.Title = null;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 509);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "Number";
            // 
            // numNumber
            // 
            this.numNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumber.Column = "";
            this.numNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numNumber.Location = new System.Drawing.Point(96, 507);
            this.numNumber.Name = "numNumber";
            this.numNumber.RecordHost = this.xrmRecordSelected;
            this.numNumber.Size = new System.Drawing.Size(207, 20);
            this.numNumber.TabIndex = 82;
            this.numNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbPropNumber
            // 
            this.rbPropNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbPropNumber.AutoSize = true;
            this.rbPropNumber.Location = new System.Drawing.Point(3, 509);
            this.rbPropNumber.Name = "rbPropNumber";
            this.rbPropNumber.Size = new System.Drawing.Size(14, 13);
            this.rbPropNumber.TabIndex = 15;
            this.rbPropNumber.UseVisualStyleBackColor = true;
            this.rbPropNumber.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConnect;
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
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rappen.XTB.Helpers.Controls.XRMColumnText txtFetch;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox cmbEntities;
        private System.Windows.Forms.Button btnConnect;
        private Rappen.XTB.Helpers.Controls.XRMColumnLookup cmbViews;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RadioButton rbPropFetch;
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
        private Controls.XRMColumnOptionSet cmbOptions;
        private System.Windows.Forms.Label label5;
        private Controls.XRMAttributeComboBox cmbAttributes;
        private System.Windows.Forms.RadioButton rbPropOptionset;
        private System.Windows.Forms.RadioButton rbPropAttribute;
        private Controls.XRMColumnBool chkCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLookup;
        private Controls.XRMColumnText txtRecord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPropLookupDlg;
        private Controls.XRMLookupDialog xrmLookupDialog1;
        private System.Windows.Forms.RadioButton rbPropCheckbox;
        private Controls.XRMRecordHost xrmRecordView;
        private Controls.XRMRecordHost xrmRecordSelected;
        private Controls.XRMColumnText xrmRecordText;
        private System.Windows.Forms.RadioButton rbPropText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private Controls.XRMColumnLookup cmbLookup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbPropLookup;
        private Controls.XRMColumnDateTime pickDateTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbPropDateTime;
        private Controls.XRMColumnNumber numNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbPropNumber;
    }
}

