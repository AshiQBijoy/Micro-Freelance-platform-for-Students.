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
    public partial class StudentWorkApply : UserControl
    {
        private string studentId;
        private SqlConnection connect = new SqlConnection(
            @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;");

        public StudentWorkApply(string loggedInStudentId)
        {
            InitializeComponent();
            studentId = loggedInStudentId;
        }
        private void LoadWorks()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(
           "SELECT WorkID, TaskName, TaskDescription, Deadline, PaymentAmount " +
           "FROM AdminWork " +
           "WHERE WorkID NOT IN (SELECT WorkID FROM WorkApplications WHERE StudentID = @studentId)", connect))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@studentId", studentId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvWorks.DataSource = dt;
            }
        }

        private void StudentWorkApply_Load(object sender, EventArgs e)
        {
            LoadWorks();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvWorks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a work first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int workId = Convert.ToInt32(dgvWorks.SelectedRows[0].Cells["WorkID"].Value);

            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO WorkApplications (WorkID, StudentID, Status, AppliedDate) " +
                "VALUES (@workId, @studentId, 'Pending', GETDATE())", connect))
            {
                cmd.Parameters.AddWithValue("@workId", workId);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }

            MessageBox.Show("Your application has been submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWorks();
        }
    }
}
