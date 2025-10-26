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


    public partial class StudentsProfile : UserControl
    {
        private SqlConnection connect = new SqlConnection(
        @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;");

        public StudentsProfile()
        {
            InitializeComponent();
            LoadStudents();
        }
        private void LoadStudents()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;"))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT studentName, studentId FROM users WHERE role='Student'", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvStudents.DataSource = dt;

            }
            
        }

        private void StudentsProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void btnViewWork_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                string studentId = dgvStudents.SelectedRows[0].Cells["studentId"].Value.ToString();

                using (SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;"))
                {
                    connect.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        "SELECT TaskName, FilePath, WorkDate FROM MyWork WHERE StudentId=@studentId", connect);
                    adapter.SelectCommand.Parameters.AddWithValue("@studentId", studentId);

                    DataTable dtWork = new DataTable();
                    adapter.Fill(dtWork);
                    dgvWork.DataSource = dtWork;
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a student first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewSkills_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            string studentId = dgvStudents.SelectedRows[0].Cells["studentId"].Value.ToString();
            lstSkills.Items.Clear();

            using (SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;"))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT SkillName FROM Skills WHERE StudentId=@studentId", connect))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstSkills.Items.Add(reader["SkillName"].ToString());
                        }
                    }
                }
                connect.Close();
            }
        }
    }
}
