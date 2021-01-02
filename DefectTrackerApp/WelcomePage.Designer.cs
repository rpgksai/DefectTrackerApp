
namespace DefectTrackerApp
{
    partial class WelcomePage
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
            this.lblUserAccountName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defectReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDefectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defectHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defectReportApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defectHistoryReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserAccountName
            // 
            this.lblUserAccountName.AutoSize = true;
            this.lblUserAccountName.Location = new System.Drawing.Point(3, 29);
            this.lblUserAccountName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserAccountName.Name = "lblUserAccountName";
            this.lblUserAccountName.Size = new System.Drawing.Size(0, 32);
            this.lblUserAccountName.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.defectReportsToolStripMenuItem,
            this.defectHistoryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1868, 52);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(123, 48);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // defectReportsToolStripMenuItem
            // 
            this.defectReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDefectsToolStripMenuItem});
            this.defectReportsToolStripMenuItem.Name = "defectReportsToolStripMenuItem";
            this.defectReportsToolStripMenuItem.Size = new System.Drawing.Size(141, 48);
            this.defectReportsToolStripMenuItem.Text = "Defects";
            // 
            // addDefectsToolStripMenuItem
            // 
            this.addDefectsToolStripMenuItem.Name = "addDefectsToolStripMenuItem";
            this.addDefectsToolStripMenuItem.Size = new System.Drawing.Size(346, 54);
            this.addDefectsToolStripMenuItem.Text = "Add Defects";
            this.addDefectsToolStripMenuItem.Click += new System.EventHandler(this.addDefectsToolStripMenuItem_Click);
            // 
            // defectHistoryToolStripMenuItem
            // 
            this.defectHistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defectReportApplicationToolStripMenuItem,
            this.defectHistoryReportsToolStripMenuItem});
            this.defectHistoryToolStripMenuItem.Name = "defectHistoryToolStripMenuItem";
            this.defectHistoryToolStripMenuItem.Size = new System.Drawing.Size(230, 48);
            this.defectHistoryToolStripMenuItem.Text = "Defect History";
            // 
            // defectReportApplicationToolStripMenuItem
            // 
            this.defectReportApplicationToolStripMenuItem.Name = "defectReportApplicationToolStripMenuItem";
            this.defectReportApplicationToolStripMenuItem.Size = new System.Drawing.Size(529, 54);
            this.defectReportApplicationToolStripMenuItem.Text = "Defect Report/Application";
            this.defectReportApplicationToolStripMenuItem.Click += new System.EventHandler(this.defectReportApplicationToolStripMenuItem_Click);
            // 
            // defectHistoryReportsToolStripMenuItem
            // 
            this.defectHistoryReportsToolStripMenuItem.Name = "defectHistoryReportsToolStripMenuItem";
            this.defectHistoryReportsToolStripMenuItem.Size = new System.Drawing.Size(529, 54);
            this.defectHistoryReportsToolStripMenuItem.Text = "Defect History Reports";
            this.defectHistoryReportsToolStripMenuItem.Click += new System.EventHandler(this.defectHistoryReportsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(137, 48);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 1112);
            this.Controls.Add(this.lblUserAccountName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "WelcomePage";
            this.Text = "Bug Tracker  Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserAccountName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defectReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDefectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defectHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defectReportApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defectHistoryReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}