
namespace DefectTrackerApp
{
    partial class AddDefect
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnAddDefect = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.Label();
            this.lblAssignedDate = new System.Windows.Forms.Label();
            this.cmbAssignedTo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbApplicationName = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.Stat = new System.Windows.Forms.Label();
            this.txtSeverity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApplnName = new System.Windows.Forms.Label();
            this.cmbDefectType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDefectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(850, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Defect";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.btnAddDefect);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.D);
            this.groupBox1.Controls.Add(this.lblAssignedDate);
            this.groupBox1.Controls.Add(this.cmbAssignedTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtModuleName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbApplicationName);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.Stat);
            this.groupBox1.Controls.Add(this.txtSeverity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblApplnName);
            this.groupBox1.Controls.Add(this.cmbDefectType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDefectName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1784, 801);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bug Tracker";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(1205, 400);
            this.txtDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(260, 38);
            this.txtDate.TabIndex = 21;
            // 
            // btnAddDefect
            // 
            this.btnAddDefect.Location = new System.Drawing.Point(1392, 708);
            this.btnAddDefect.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddDefect.Name = "btnAddDefect";
            this.btnAddDefect.Size = new System.Drawing.Size(200, 55);
            this.btnAddDefect.TabIndex = 19;
            this.btnAddDefect.Text = "Add Defect";
            this.btnAddDefect.UseVisualStyleBackColor = true;
            this.btnAddDefect.Click += new System.EventHandler(this.btnAddDefect_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(469, 510);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(996, 154);
            this.txtDescription.TabIndex = 18;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(133, 529);
            this.D.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(158, 32);
            this.D.TabIndex = 17;
            this.D.Text = "Description";
            // 
            // lblAssignedDate
            // 
            this.lblAssignedDate.AutoSize = true;
            this.lblAssignedDate.Location = new System.Drawing.Point(896, 384);
            this.lblAssignedDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAssignedDate.Name = "lblAssignedDate";
            this.lblAssignedDate.Size = new System.Drawing.Size(200, 32);
            this.lblAssignedDate.TabIndex = 15;
            this.lblAssignedDate.Text = "Assigned Date";
            // 
            // cmbAssignedTo
            // 
            this.cmbAssignedTo.FormattingEnabled = true;
            this.cmbAssignedTo.Location = new System.Drawing.Point(469, 384);
            this.cmbAssignedTo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbAssignedTo.Name = "cmbAssignedTo";
            this.cmbAssignedTo.Size = new System.Drawing.Size(316, 39);
            this.cmbAssignedTo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Assigned To";
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(1205, 43);
            this.txtModuleName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(260, 38);
            this.txtModuleName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(896, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Module Name";
            // 
            // cbApplicationName
            // 
            this.cbApplicationName.FormattingEnabled = true;
            this.cbApplicationName.Location = new System.Drawing.Point(469, 43);
            this.cbApplicationName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbApplicationName.Name = "cbApplicationName";
            this.cbApplicationName.Size = new System.Drawing.Size(316, 39);
            this.cbApplicationName.TabIndex = 10;
            this.cbApplicationName.SelectedIndexChanged += new System.EventHandler(this.cmbApplnName_onSelected);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending"});
            this.cmbStatus.Location = new System.Drawing.Point(1205, 289);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(316, 39);
            this.cmbStatus.TabIndex = 9;
            // 
            // Stat
            // 
            this.Stat.AutoSize = true;
            this.Stat.Location = new System.Drawing.Point(896, 289);
            this.Stat.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(96, 32);
            this.Stat.TabIndex = 8;
            this.Stat.Text = "Status";
            // 
            // txtSeverity
            // 
            this.txtSeverity.Location = new System.Drawing.Point(469, 272);
            this.txtSeverity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSeverity.Name = "txtSeverity";
            this.txtSeverity.Size = new System.Drawing.Size(260, 38);
            this.txtSeverity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Severity";
            // 
            // lblApplnName
            // 
            this.lblApplnName.AutoSize = true;
            this.lblApplnName.Location = new System.Drawing.Point(125, 62);
            this.lblApplnName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblApplnName.Name = "lblApplnName";
            this.lblApplnName.Size = new System.Drawing.Size(239, 32);
            this.lblApplnName.TabIndex = 4;
            this.lblApplnName.Text = "Application Name";
            // 
            // cmbDefectType
            // 
            this.cmbDefectType.FormattingEnabled = true;
            this.cmbDefectType.Location = new System.Drawing.Point(1205, 165);
            this.cmbDefectType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbDefectType.Name = "cmbDefectType";
            this.cmbDefectType.Size = new System.Drawing.Size(316, 39);
            this.cmbDefectType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Defect Category";
            // 
            // txtDefectName
            // 
            this.txtDefectName.Location = new System.Drawing.Point(469, 167);
            this.txtDefectName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDefectName.Name = "txtDefectName";
            this.txtDefectName.Size = new System.Drawing.Size(260, 38);
            this.txtDefectName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Defect Title";
            // 
            // AddDefect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 1112);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddDefect";
            this.Text = "AddDefect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddDefect_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddDefect;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label lblAssignedDate;
        private System.Windows.Forms.ComboBox cmbAssignedTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbApplicationName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label Stat;
        private System.Windows.Forms.TextBox txtSeverity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApplnName;
        private System.Windows.Forms.ComboBox cmbDefectType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDefectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
    }
}