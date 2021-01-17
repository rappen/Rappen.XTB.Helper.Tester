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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntityFilter = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.xrmDataTextBox1 = new Rappen.XTB.Helpers.Controls.XRMDataTextBox();
            this.xrmDataComboBox1 = new Rappen.XTB.Helpers.Controls.XRMDataComboBox();
            this.xrmEntityComboBox1 = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.rbPropGrid = new System.Windows.Forms.RadioButton();
            this.rbPropText = new System.Windows.Forms.RadioButton();
            this.rbPropView = new System.Windows.Forms.RadioButton();
            this.rbPropEntities = new System.Windows.Forms.RadioButton();
            this.xrmGridView1 = new Rappen.XTB.Helpers.Controls.XRMGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xrmGridView1)).BeginInit();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
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
            this.propertyGrid1.Size = new System.Drawing.Size(302, 576);
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
            this.splitContainer1.Panel2.Controls.Add(this.xrmGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 576);
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
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txtEntityFilter);
            this.splitContainer2.Panel1.Controls.Add(this.btnExecute);
            this.splitContainer2.Panel1.Controls.Add(this.lblConnection);
            this.splitContainer2.Panel1.Controls.Add(this.btnConnect);
            this.splitContainer2.Panel1.Controls.Add(this.xrmDataTextBox1);
            this.splitContainer2.Panel1.Controls.Add(this.xrmDataComboBox1);
            this.splitContainer2.Panel1.Controls.Add(this.xrmEntityComboBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rbPropGrid);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropText);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropView);
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Panel2.Controls.Add(this.rbPropEntities);
            this.splitContainer2.Size = new System.Drawing.Size(662, 576);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
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
            this.txtEntityFilter.Location = new System.Drawing.Point(12, 70);
            this.txtEntityFilter.Name = "txtEntityFilter";
            this.txtEntityFilter.Size = new System.Drawing.Size(291, 20);
            this.txtEntityFilter.TabIndex = 20;
            this.txtEntityFilter.TextChanged += new System.EventHandler(this.txtEntityFilter_TextChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExecute.Location = new System.Drawing.Point(12, 540);
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
            // xrmDataTextBox1
            // 
            this.xrmDataTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xrmDataTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.xrmDataTextBox1.DisplayFormat = "fetchxml";
            this.xrmDataTextBox1.Entity = null;
            this.xrmDataTextBox1.EntityReference = null;
            this.xrmDataTextBox1.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.xrmDataTextBox1.Location = new System.Drawing.Point(12, 151);
            this.xrmDataTextBox1.LogicalName = null;
            this.xrmDataTextBox1.Multiline = true;
            this.xrmDataTextBox1.Name = "xrmDataTextBox1";
            this.xrmDataTextBox1.Service = null;
            this.xrmDataTextBox1.Size = new System.Drawing.Size(291, 230);
            this.xrmDataTextBox1.TabIndex = 50;
            // 
            // xrmDataComboBox1
            // 
            this.xrmDataComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xrmDataComboBox1.DisplayFormat = "";
            this.xrmDataComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmDataComboBox1.FormattingEnabled = true;
            this.xrmDataComboBox1.Location = new System.Drawing.Point(12, 124);
            this.xrmDataComboBox1.Name = "xrmDataComboBox1";
            this.xrmDataComboBox1.Service = null;
            this.xrmDataComboBox1.Size = new System.Drawing.Size(291, 21);
            this.xrmDataComboBox1.TabIndex = 40;
            this.xrmDataComboBox1.SelectedIndexChanged += new System.EventHandler(this.xrmDataComboBox1_SelectedIndexChanged);
            // 
            // xrmEntityComboBox1
            // 
            this.xrmEntityComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xrmEntityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmEntityComboBox1.FormattingEnabled = true;
            this.xrmEntityComboBox1.Location = new System.Drawing.Point(12, 96);
            this.xrmEntityComboBox1.Name = "xrmEntityComboBox1";
            this.xrmEntityComboBox1.Size = new System.Drawing.Size(291, 21);
            this.xrmEntityComboBox1.TabIndex = 30;
            this.xrmEntityComboBox1.SelectedIndexChanged += new System.EventHandler(this.xrmEntityComboBox1_SelectedIndexChanged);
            // 
            // rbPropGrid
            // 
            this.rbPropGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPropGrid.AutoSize = true;
            this.rbPropGrid.Location = new System.Drawing.Point(331, 44);
            this.rbPropGrid.Name = "rbPropGrid";
            this.rbPropGrid.Size = new System.Drawing.Size(14, 13);
            this.rbPropGrid.TabIndex = 6;
            this.rbPropGrid.UseVisualStyleBackColor = true;
            this.rbPropGrid.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropText
            // 
            this.rbPropText.AutoSize = true;
            this.rbPropText.Location = new System.Drawing.Point(3, 154);
            this.rbPropText.Name = "rbPropText";
            this.rbPropText.Size = new System.Drawing.Size(14, 13);
            this.rbPropText.TabIndex = 2;
            this.rbPropText.UseVisualStyleBackColor = true;
            this.rbPropText.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropView
            // 
            this.rbPropView.AutoSize = true;
            this.rbPropView.Location = new System.Drawing.Point(3, 127);
            this.rbPropView.Name = "rbPropView";
            this.rbPropView.Size = new System.Drawing.Size(14, 13);
            this.rbPropView.TabIndex = 1;
            this.rbPropView.UseVisualStyleBackColor = true;
            this.rbPropView.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // rbPropEntities
            // 
            this.rbPropEntities.AutoSize = true;
            this.rbPropEntities.Location = new System.Drawing.Point(3, 99);
            this.rbPropEntities.Name = "rbPropEntities";
            this.rbPropEntities.Size = new System.Drawing.Size(14, 13);
            this.rbPropEntities.TabIndex = 0;
            this.rbPropEntities.UseVisualStyleBackColor = true;
            this.rbPropEntities.CheckedChanged += new System.EventHandler(this.rbProp_CheckedChanged);
            // 
            // xrmGridView1
            // 
            this.xrmGridView1.AllowUserToOrderColumns = true;
            this.xrmGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrmGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.xrmGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.xrmGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xrmGridView1.ColumnOrder = "";
            this.xrmGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xrmGridView1.FilterColumns = "";
            this.xrmGridView1.Location = new System.Drawing.Point(0, 0);
            this.xrmGridView1.Name = "xrmGridView1";
            this.xrmGridView1.RowHeadersVisible = false;
            this.xrmGridView1.Service = null;
            this.xrmGridView1.ShowFriendlyNames = true;
            this.xrmGridView1.ShowIdColumn = false;
            this.xrmGridView1.ShowIndexColumn = false;
            this.xrmGridView1.ShowLocalTimes = true;
            this.xrmGridView1.Size = new System.Drawing.Size(431, 576);
            this.xrmGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 598);
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
            ((System.ComponentModel.ISupportInitialize)(this.xrmGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rappen.XTB.Helpers.Controls.XRMDataTextBox xrmDataTextBox1;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox xrmEntityComboBox1;
        private System.Windows.Forms.Button btnConnect;
        private Rappen.XTB.Helpers.Controls.XRMDataComboBox xrmDataComboBox1;
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
        private Rappen.XTB.Helpers.Controls.XRMGridView xrmGridView1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntityFilter;
    }
}

