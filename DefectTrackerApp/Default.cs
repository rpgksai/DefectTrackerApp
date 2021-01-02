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
    public partial class Default : Form
    {
        //Connection String  
        //string cs = "Data Source=.;Initial Catalog=Sample;Integrated Security=true;";

        public static string UserAccountId;

        public Default()
        {
            InitializeComponent();
        }

        private void Default_Load(object sender, EventArgs e)
        {
            try

            {
                      }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }
                      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;
            SqlCommand cmd = new SqlCommand("select * from [dbo].[tblUserLoginDetails] where UserName=@UserName and UserPassword =@Password", con);
            cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                UserAccountId = dt.Rows[0]["EmpId"].ToString();
                WelcomePage settingsForm = new WelcomePage();
                settingsForm.Show();

               // Response.Redirect()
            }

            else
            {

                MessageBox.Show("Please enter Correct Username and Password");
            }

        }
    }
}
