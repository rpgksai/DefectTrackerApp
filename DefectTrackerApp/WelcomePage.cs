using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefectTrackerApp
{
    public partial class WelcomePage : Form
    {

        public static string UserAccountId;

        public WelcomePage()
        {
            InitializeComponent();
        }

        
        private void WelcomePage_Load(object sender, EventArgs e)
        {
            UserAccountId = Default.UserAccountId;
            UserPendingReports newMDIChild = new UserPendingReports();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();

        }

   
       
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPendingReports newMDIChild = new UserPendingReports();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void addDefectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDefect newMDIChild = new AddDefect();
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void defectReportApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefectHistoryPerApp newMDIChild = new DefectHistoryPerApp();
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void defectHistoryReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefectHistory newMDIChild = new DefectHistory();
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
