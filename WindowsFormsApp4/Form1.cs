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


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(
     @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_lable_Click(object sender, EventArgs e)
        {
            RegisterForm regFrom = new RegisterForm();
            regFrom.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;


        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM [users] WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string role = table.Rows[0]["role"].ToString();

                            MessageBox.Show("Login successful as " + role, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (role == "Admin")
                            {
                                string adminUsername = table.Rows[0]["username"].ToString();
                                AdminForm adminForm = new AdminForm(adminUsername);
                                adminForm.Show();
                                this.Hide();
                            }
                            else if (role == "Student")
                            {
                                string studentName = table.Rows[0]["studentName"].ToString();
                                string username = table.Rows[0]["username"].ToString();
                                string studentID = table.Rows[0]["studentId"].ToString();

                                // Session set
                                Session.StudentID = studentID;
                                Session.StudentName = studentName;
                                Session.Username = username;

                                StudentForm studentForm = new StudentForm(studentName, username, studentID);
                                studentForm.Show();
                                this.Hide();

                            }

                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
