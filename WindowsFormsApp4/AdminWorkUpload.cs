using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AdminWorkUpload : UserControl
    {
        private string adminUser;
        

        public AdminWorkUpload(string username)
        {
            InitializeComponent();
            adminUser = username;
            LoadWorks();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminWorkUpload_Load(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text) ||
        string.IsNullOrWhiteSpace(txtTaskDescription.Text) ||
        numPayment.Value <= 0)
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(
                    @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;"))
                {
                    connect.Open();

                    string query = @"INSERT INTO AdminWork 
                            (TaskName, TaskDescription, Deadline, PaymentAmount, FilePath, AdminUser) 
                            VALUES (@taskName, @taskDesc, @deadline, @payment, @filePath, @adminUser)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@taskName", txtTaskName.Text.Trim());
                        cmd.Parameters.AddWithValue("@taskDesc", txtTaskDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@deadline", dtpDeadline.Value);
                        cmd.Parameters.AddWithValue("@payment", numPayment.Value);

                        
                        cmd.Parameters.AddWithValue("@filePath",
                            string.IsNullOrWhiteSpace(txtFilePath.Text) ? (object)DBNull.Value : txtFilePath.Text.Trim());

                        cmd.Parameters.AddWithValue("@adminUser", adminUser);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Work uploaded successfully by " + adminUser, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                txtTaskName.Clear();
                txtTaskDescription.Clear();
                txtFilePath.Clear();
                dtpDeadline.Value = DateTime.Now;
                numPayment.Value = 0;

                
                LoadWorks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading work: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ClearForm()
        {
            txtTaskName.Clear();
            txtTaskDescription.Clear();
            txtFilePath.Clear();
            numPayment.Value = 0;
            dtpDeadline.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            txtFilePath.Clear();

            
            txtFilePath.Focus();
        }
        private void LoadWorks()
        {
            using (SqlConnection connect = new SqlConnection(
                @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;"))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                  "SELECT TaskName, TaskDescription, Deadline, PaymentAmount, FilePath, AdminUser FROM AdminWork", connect);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvWorkList.AutoGenerateColumns = true;
                dgvWorkList.DataSource = dt;
            }
        }
    }
}
