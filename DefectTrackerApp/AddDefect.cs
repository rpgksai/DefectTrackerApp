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
    public partial class AddDefect : Form
    {
        public AddDefect()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

         string ProjName, ProjectId;
        public static string  EmpId;

        private void AddDefect_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;

            GetAllApplication();
            GetAllDefectTypes();
            cmbStatus.SelectedText = "Pending";
            DateTime DateTimeValue = DateTime.Now;
            txtDate.Text = DateTimeValue.ToString("MM/dd/yyyy");

            
        }


        public void  GetAllApplication()
        {
            try

            {
               // conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;

                SqlCommand cmd = new SqlCommand("select * from tblProjectDetails", conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                cbApplicationName.DataSource = dt;
                ProjectId = dt.Rows[0][0].ToString();
                cbApplicationName.DisplayMember = "Title";
                cbApplicationName.ValueMember = "ProjectId";
                cbApplicationName.Text = "--Select--";
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void GetAllDefectTypes()
        {
            try

            {
                DataTable dt1 = new DataTable();

               // conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;
                SqlCommand comd = new SqlCommand("select * from tblDefectTypes", conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(comd);
                sda.Fill(dt1);
                cmbDefectType.DataSource = dt1;
                cmbDefectType.DisplayMember = "DefectTypeName";
                cmbDefectType.ValueMember = "DefectTypeId";
                //cbApplicationName.SelectedText = "--Select--";
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

               private void btnAddDefect_Click(object sender, EventArgs e)
        {

         if (string.IsNullOrWhiteSpace(txtModuleName.Text))
            {
                MessageBox.Show("Enter Module Name !!!");
                txtModuleName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtDefectName.Text))
            {
                MessageBox.Show("Enter Defect Name !!!");
                txtDefectName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtSeverity.Text))
            {
                MessageBox.Show("Enter Severity !!!");
                txtSeverity.Select();
            }
            else if (cbApplicationName.Text == "--Select--")
            {

                MessageBox.Show("Enter Application Name  !!!");
                cbApplicationName.Select();

            }
            else
            {
                try
                {
                    SqlCommand sqlCmd;
                   
                    conn.Open();
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("sp_WinAddNewDefects", conn);  
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ProjectId", cbApplicationName.SelectedValue.ToString());
                                   
                   
                    sqlCmd.Parameters.AddWithValue("@DefectName", txtDefectName.Text);
                    sqlCmd.Parameters.AddWithValue("@userAccountId", WelcomePage.UserAccountId.ToString());


                    sqlCmd.Parameters.AddWithValue("@ModuleName", txtModuleName.Text);
                    sqlCmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    sqlCmd.Parameters.AddWithValue("@DefectTypeId", cmbDefectType.SelectedValue.ToString());
                   if(cmbAssignedTo.SelectedValue.ToString() == "Null" )
                    {
                        sqlCmd.Parameters.AddWithValue("@EmpId", EmpId);
                    }
                    else
                    {
                        sqlCmd.Parameters.AddWithValue("@EmpId", cmbAssignedTo.SelectedValue);

                    }
                    
                    sqlCmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    sqlCmd.Parameters.AddWithValue("@priority", txtSeverity.Text);



                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Saved Successfully !!!");
                        conn.Close();
                        ClearAllData();
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

        private void ClearAllData()
        {
            txtSeverity.Text = "";
            txtDefectName.Text = "";
            txtDescription.Text = "";
            txtModuleName.Text = "";
            cmbDefectType.SelectedIndex = -1;
           // EmployeeId = "";
           }

        private void cmbApplnName_onSelected(object sender, EventArgs e)
        {

            if (ProjectId == "0")
            {
                ProjectId = dt.Rows[0][0].ToString();
                cmbAssignedTo.DataSource = FetchEmpDetails();
                cmbAssignedTo.DisplayMember = "FullName";
                cmbAssignedTo.ValueMember = "EmpId";
               
            }
            else
            {
                               
                ProjName = cbApplicationName.Text;

                ProjectId = cbApplicationName.SelectedIndex.ToString();


                cmbAssignedTo.DataSource = FetchEmpDetails();
                cmbAssignedTo.DisplayMember = "FullName";
                cmbAssignedTo.ValueMember = "EmpId";

            }

            /*
            try

            {
                DataTable dtProj = new DataTable();

                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;

                SqlCommand cmdProj = new SqlCommand("select B.EmpId, B.FirstName + '' + B.LastName as FullName from [dbo].[EmployeeProjectDetails] A" +
                "join[dbo].[tblUsersEmployeesDetails] B on A.EmployeeId = B.EmpId where ProjectId = '" + ProjectId + "'", conn);
                conn.Open();
                SqlDataAdapter sdaProj = new SqlDataAdapter(cmdProj);
                sdaProj.Fill(dtProj);
                cmbAssignedTo.DataSource = dtProj;
                cmbAssignedTo.DisplayMember = "FullName";
                cmbAssignedTo.ValueMember = "EmpId";
                //cbApplicationName.SelectedText = "--Select--";
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            } */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomePage setting = new WelcomePage();
            setting.MdiParent=this.MdiParent;
            setting.Show();
        }

        private DataTable FetchEmpDetails()
        {

            DataTable dtData = new DataTable();
            cmd = new SqlCommand("sp_winGetempbyApp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
            sqlSda.Fill(dtData);
            //EmpId = dtData.Rows[0][0].ToString();
            return dtData;
        }

    }
}
