using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class SubmitWork : UserControl
    {
       
       
        private string connectionString = @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;";

        public SubmitWork(string studentId)
        {
            InitializeComponent();
            LoadSubmittedWorks();



        }

        private void SubmitWork_Load(object sender, EventArgs e)
        {
            LoadSubmittedWorks();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnSubmitWork_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWorkName.Text))
            {
                MessageBox.Show("Work Name is required!");
                return;
            }

            int studentID = int.Parse(Session.StudentID);  // session থেকে student ID নাও
            string workName = txtWorkName.Text.Trim();
            string filePath = txtFilePath.Text.Trim();

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Step 1: সর্বোচ্চ WorkID বের করো
                    SqlCommand cmdMaxID = new SqlCommand("SELECT ISNULL(MAX(WorkID), 0) FROM StudentSubmittedWork", connect);
                    int maxWorkID = (int)cmdMaxID.ExecuteScalar();
                    int newWorkID = maxWorkID + 1; // নতুন WorkID

                    // Step 2: Insert query
                    SqlCommand cmdInsert = new SqlCommand(
                        "INSERT INTO StudentSubmittedWork (WorkID, StudentID, WorkName, FilePath, SubmitDate) " +
                        "VALUES (@workID, @studentID, @workName, @filePath, GETDATE())", connect);

                    cmdInsert.Parameters.AddWithValue("@workID", newWorkID);
                    cmdInsert.Parameters.AddWithValue("@studentID", studentID);
                    cmdInsert.Parameters.AddWithValue("@workName", workName);
                    cmdInsert.Parameters.AddWithValue("@filePath", filePath);

                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Work submitted successfully! WorkID: " + newWorkID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting work: " + ex.Message);
            }

        }
        private void LoadSubmissions()
        {
           
        }
        private void LoadSubmittedWorks()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT WorkID, WorkName, FilePath, SubmitDate FROM StudentSubmittedWork WHERE StudentID=@studentId";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@studentId", int.Parse(Session.StudentID));

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvSubmissions.DataSource = dt;
                        dgvSubmissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading submitted works: " + ex.Message);
            }

        }
    }
}
    

