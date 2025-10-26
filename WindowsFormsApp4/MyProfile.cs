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
    public partial class MyProfile : UserControl
    {


        private string studentID;       
        private string studentName;
        private string username;

        SqlConnection connect = new SqlConnection(
            @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;");


        public MyProfile(string studentName, string username, string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.studentName = studentName;
            this.username = username;

            lblName.Text = studentName;
            lblUsername.Text = username;
            lblStudentID.Text = studentID;



        }

        private void InitializeSkills()
        {
            comboBoxSkills.Items.Clear();
            comboBoxSkills.Items.AddRange(new string[] { "C#", "Java", "Python", "JavaScript", "SQL" });
        }


        private void MyProfile_Load(object sender, EventArgs e)
        {
            lblName.Text = studentName;
            lblUsername.Text = username;
            lblStudentID.Text = studentID;

            InitializeSkills();
            LoadSkillsFromDatabase(this.studentID);
            LoadStudentBalance(this.studentID);
        }
        private void LoadStudentBalance(string studentID)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT TotalBalance FROM StudentAccount WHERE StudentID=@sid", connect);
                cmd.Parameters.AddWithValue("@sid", studentID);

                object result = cmd.ExecuteScalar();

                txtTotalBalance.Text = result != null
                    ? Convert.ToDecimal(result).ToString("0.00")
                    : "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading balance: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }






        private void LoadSkillsFromDatabase(string studentID)
        {
            listBoxSelectedSkills.Items.Clear();
            using (SqlCommand cmd = new SqlCommand("SELECT SkillName FROM Skills WHERE StudentId = @studentid", connect))
            {
                cmd.Parameters.AddWithValue("@studentid", studentID);
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBoxSelectedSkills.Items.Add(reader["SkillName"].ToString());
                }
                connect.Close();
            }
        }

        private void buttonAddSkills_Click(object sender, EventArgs e)
        {
            if (comboBoxSkills.SelectedItem != null)
            {
                string skill = comboBoxSkills.SelectedItem.ToString();

                // DB তে insert
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Skills (StudentId, SkillName) VALUES (@studentid, @skill)", connect))
                {
                    cmd.Parameters.AddWithValue("@studentid", this.studentID);
                    cmd.Parameters.AddWithValue("@skill", skill);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }

                // ListBox এ দেখানো
                listBoxSelectedSkills.Items.Add(skill);
            }

        }

        private void comboBoxSkills_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {


            if (listBoxSelectedSkills.SelectedItem != null)
            {
                string skillToRemove = listBoxSelectedSkills.SelectedItem.ToString();
                listBoxSelectedSkills.Items.Remove(skillToRemove);

                using (SqlConnection connect = new SqlConnection(
                    @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;"))
                {
                    connect.Open();
                    string deleteQuery = "DELETE FROM Skills WHERE StudentId = @studentId AND SkillName = @skillName";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@studentId", this.studentID);
                        cmd.Parameters.AddWithValue("@skillName", skillToRemove);
                        cmd.ExecuteNonQuery();
                    }
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a skill to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalBalance_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
