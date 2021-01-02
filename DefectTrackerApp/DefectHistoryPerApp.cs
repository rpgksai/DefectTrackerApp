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

using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

using iTextSharp.text;
using iTextSharp.text.pdf;


namespace DefectTrackerApp
{
    public partial class DefectHistoryPerApp : Form
    {
        public DefectHistoryPerApp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        string ProjName, ProjectId;


        private void DefectHistoryPerApp_Load(object sender, EventArgs e)
        {

            try

            {

                // string s= System.Configuration.confi
                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugTrackerConnectionString"].ConnectionString;
                SqlCommand cmd = new SqlCommand("select * from tblProjectDetails", conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                cbApplicationName.DataSource = dt;
                cbApplicationName.DisplayMember = "Title";
                cbApplicationName.ValueMember = "ProjectId";
                //cbApplicationName.SelectedText = "--Select--";
                conn.Close();

                if (ProjectId == "0")
                {
                    string AppNm = cbApplicationName.Text;
                    ProjectId = dt.Rows[0][0].ToString(); 
                    dataGridView1.AutoGenerateColumns = true; // dgvEmp is DataGridView name
                    dataGridView1.DataSource = FetchEmpDetails();
                }
                else
                { 
                ProjectId = cbApplicationName.SelectedIndex.ToString();
                dataGridView1.AutoGenerateColumns = true; // dgvEmp is DataGridView name

                dataGridView1.DataSource = FetchEmpDetails();
                    }

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }
        }

       
        
        private void ApplnOnchange(object sender, EventArgs e)
        {
            ProjName = cbApplicationName.Text;

            ProjectId = cbApplicationName.SelectedIndex.ToString();
            dataGridView1.AutoGenerateColumns = true; // dgvEmp is DataGridView name
            dataGridView1.DataSource = FetchEmpDetails();
            
        }


        private DataTable FetchEmpDetails()
        {
                     
   
            DataTable dtData = new DataTable();
            cmd = new SqlCommand("sp_winGetDetsByAppln", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId );
            SqlDataAdapter sqlSda = new SqlDataAdapter(cmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomePage settingsForm = new WelcomePage();
            settingsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                try
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    // Change properties of the Workbook 

                    ExcelApp.Columns.ColumnWidth = 20;

                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    // Storing header part in Excel

                    for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                    {

                        ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                    }



                    // Storing Each row and column value to excel sheet

                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                        for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGridView1[j, i];
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }



                    xlWorkBook.SaveAs("MasterReport.xls", Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    //ExcelApp.ActiveWorkbook.SaveCopyAs("C:\\Report.xls");

                    //ExcelApp.ActiveWorkbook.Saved = true;

                    //ExcelApp.Quit();

                    MessageBox.Show("Excel file created , you can find the file in 'My Documents' Drive Name As MasterReport.xls", "Converted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("No Record Found to Convert, Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }



        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clickme_Onclick(object sender, EventArgs e)
        {
            int selectedIndex = cbApplicationName.SelectedIndex;
            Object selectedItem = cbApplicationName.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());
        }
    }
}
