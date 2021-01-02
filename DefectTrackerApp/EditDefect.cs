using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace DefectTrackerApp
{
    public partial class EditDefect : Form
    {
        public EditDefect()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public static string DefectId, ProjectId , DefectTypeId;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPendingReports upr = new UserPendingReports();
            upr.MdiParent = this.MdiParent;
            upr.Show();
        }

        private void EditDefect_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;


            string DefectId = UserPendingReports.DefectId;

            try
            {
                DataTable dtData = new DataTable();
                cmd = new SqlCommand("sp_WinEditDefectPendingReport", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DefectId", DefectId);
                SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
                sqlSda.Fill(dtData);

                DefectId = dtData.Rows[0]["DefectID"].ToString();
                txtAssignedTo.Text = UserPendingReports.UserName;
                txtApplicationName.Text = dtData.Rows[0]["Title"].ToString();
                txtModuleName.Text = dtData.Rows[0]["ModuleName"].ToString();
                txtDefectName.Text = dtData.Rows[0]["DefectName"].ToString();
                txtDefectCategory.Text = dtData.Rows[0]["DefectTypeName"].ToString();
                txtSeverity.Text = dtData.Rows[0]["Priority"].ToString();
                txtAssignedDate.Text = dtData.Rows[0]["PostedDate"].ToString();
                cmbStatus.SelectedItem = "Pending";
                ProjectId = dtData.Rows[0]["ProjectId"].ToString();
                DefectTypeId = dtData.Rows[0]["DefectTypeId"].ToString();

            }
            catch(Exception ex)
                {
                MessageBox.Show("Error:- " + ex.Message);
            }

        }

        private void btnAddDefect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCmd;
                conn.Open();
                DataTable dtData = new DataTable();
                sqlCmd = new SqlCommand("spUpdateDefectStatus", conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@DefectId", UserPendingReports.DefectId);
                sqlCmd.Parameters.AddWithValue("@DefectName", txtDefectName.Text);
                sqlCmd.Parameters.AddWithValue("@userAccountId", WelcomePage.UserAccountId);
                sqlCmd.Parameters.AddWithValue("@ProjectId", ProjectId);
                sqlCmd.Parameters.AddWithValue("@ModuleName", txtModuleName.Text);
                sqlCmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                sqlCmd.Parameters.AddWithValue("@DefectTypeId", DefectTypeId);
                sqlCmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                sqlCmd.Parameters.AddWithValue("@priority", txtSeverity.Text);
                sqlCmd.Parameters.AddWithValue("@EmpId", UserPendingReports.EmpId);
                //DateTime DateTimeValue = DateTime.Now;
                // string assignedDate = DateTimeValue.ToString("MM/dd/yyyy");



                int numRes = sqlCmd.ExecuteNonQuery();
                if (numRes > 0)
                {
                    MessageBox.Show("Record Saved Successfully !!!");
                    WelcomePage upr = new WelcomePage();
                    upr.Show();

                    conn.Close();
                    
                }
                else
                    MessageBox.Show("Please Try Again !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }
    }
}
