
namespace DefectTrackerApp
{
    partial class DefectHistoryPerApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AppName = new System.Windows.Forms.Label();
            this.cbApplicationName = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1320, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Defect History Report ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 284);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2555, 625);
            this.dataGridView1.TabIndex = 2;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Location = new System.Drawing.Point(270, 214);
            this.AppName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(239, 32);
            this.AppName.TabIndex = 4;
            this.AppName.Text = "Application Name";
            // 
            // cbApplicationName
            // 
            this.cbApplicationName.FormattingEnabled = true;
            this.cbApplicationName.Location = new System.Drawing.Point(525, 207);
            this.cbApplicationName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbApplicationName.Name = "cbApplicationName";
            this.cbApplicationName.Size = new System.Drawing.Size(316, 39);
            this.cbApplicationName.TabIndex = 5;
            this.cbApplicationName.SelectedIndexChanged += new System.EventHandler(this.ApplnOnchange);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2462, 952);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 55);
            this.button3.TabIndex = 8;
            this.button3.Text = "Export To Pdf";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 952);
            this.button4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(304, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "Export To Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DefectHistoryPerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2929, 1112);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbApplicationName);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DefectHistoryPerApp";
            this.Text = "DefectHistoryPerApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DefectHistoryPerApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.ComboBox cbApplicationName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}