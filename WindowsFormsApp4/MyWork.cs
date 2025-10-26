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
    public partial class MyWork : UserControl
    {


        private string studentID;
        private SqlConnection connect;

        public MyWork(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;

            connect = new SqlConnection(
                @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;");

            LoadWork();
        }

        private void LoadWorkList()
        {
            string query = "SELECT WorkID, TaskName, FilePath, WorkDate FROM MyWork WHERE StudentId = @studentid";
            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@studentid", studentID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvMyWork.DataSource = table;  // এখানে dgvMyWork ব্যবহার করা হলো
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void lblTaskName_Click(object sender, EventArgs e)
        {

        }

        private void MyWork_Load(object sender, EventArgs e)
        {
            LoadWork();
        }

        private void LoadWork()
        {
            string query = "SELECT WorkID, TaskName, FilePath, WorkDate FROM MyWork WHERE StudentId = @studentid";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@studentid", studentID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // এখানে AutoGenerateColumns true করলে ডাটাবেজের সব কলাম আসবে
                dgvMyWork.AutoGenerateColumns = true;
                dgvMyWork.DataSource = dt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Cannot save: studentID is null!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Please enter a task name.");
                return;
            }

            try
            {
                string insertQuery = "INSERT INTO MyWork (StudentId, TaskName, FilePath, WorkDate) VALUES (@studentid, @task, @file, @date)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@studentid", studentID);
                    cmd.Parameters.AddWithValue("@task", txtTaskName.Text.Trim());
                    cmd.Parameters.AddWithValue("@file", string.IsNullOrEmpty(txtFilePath.Text) ? (object)DBNull.Value : txtFilePath.Text);
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }

                txtTaskName.Clear();
                txtFilePath.Clear();

                LoadWork();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot save: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvMyWork.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a work to remove.");
                return;
            }

            int workId = Convert.ToInt32(dgvMyWork.SelectedRows[0].Cells["WorkID"].Value);

            try
            {
                string deleteQuery = "DELETE FROM MyWork WHERE WorkID = @id";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@id", workId);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }

                LoadWork();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot remove: " + ex.Message);
            }
        }
    }
}
 
