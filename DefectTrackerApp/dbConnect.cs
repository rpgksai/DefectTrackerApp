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
    class dbConnect
    {

        public static SqlConnection myCon = null;

        public void CreateConnection()
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;

            
            myCon.Open();

        }
    }
}
