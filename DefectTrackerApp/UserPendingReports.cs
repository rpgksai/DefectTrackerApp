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
    public partial class UserPendingReports : Form
    {
        public UserPendingReports()
        {
            InitializeComponent();
        }
        public static string UserAccountId, UserName;

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

         public static string DefectId, EmpId;

        private void UserPendingReports_Load(object sender, EventArgs e)
        {
            UserAccountId = WelcomePage.UserAccountId;
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;
             
                cmbUserName.DataSource = FetchEmpNameDetails();
                cmbUserName.DisplayMember = "FullName" ;
                cmbUserName.ValueMember = "EmpId";


            UserName = cmbUserName.Text;
            EmpId = cmbUserName.SelectedItem.ToString();




            if (cmbUserName.SelectedValue.ToString() == UserAccountId)
            {
                //UserAccountId
                dataGridView1.AutoGenerateColumns = true; // dgvEmp is DataGridView name
                dataGridView1.DataSource = FetchDfEmpPendingDetails();
                //add new button column to the DataGridView
                //This column displays a delete icon in each row
                DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
                Editlink.UseColumnTextForLinkValue = true;
                Editlink.HeaderText = "Edit";
                Editlink.DataPropertyName = "lnkColumn";
                Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                Editlink.Text = "Edit";
                dataGridView1.Columns.Add(Editlink);

            }
            else
            {

                dataGridView1.AutoGenerateColumns = true; // dgvEmp is DataGridView name
                dataGridView1.DataSource = FetchEmpPendingDetails();
                
            }
               



        }

        private DataTable FetchEmpPendingDetails()
        {

            DataTable dtData = new DataTable();
            cmd = new SqlCommand("sp_WinAllDefectPendingReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", cmbUserName.SelectedItem.ToString());
            SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
            sqlSda.Fill(dtData);
            //EmpId = dtData.Rows[0][0].ToString();
            return dtData;


        }

        private DataTable FetchDfEmpPendingDetails()
        {

            DataTable dtData = new DataTable();
            cmd = new SqlCommand("sp_WinAllDefectPendingReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserAccountId);
            SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
            sqlSda.Fill(dtData);
            EmpId = dtData.Rows[0][0].ToString();
            return dtData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["DefectId"].Value.ToString());

                DefectId = dataGridView1.Rows[e.RowIndex].Cells["DefectId"].Value.ToString();

                EditDefect f2 = new EditDefect();
                f2.MdiParent = this.MdiParent;
                f2.Show();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomePage setting = new WelcomePage();
            setting.Show();
        }

        private DataTable FetchEmpNameDetails()
        {


            DataTable dtData = new DataTable();
            cmd = new SqlCommand("sp_WinLoginmployeeDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserAccountId", UserAccountId);
            SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
            sqlSda.Fill(dtData);

            
            return dtData;
        }

    }
}
