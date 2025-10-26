using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(
     @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_lable_Click(object sender, EventArgs e)
        {
            Form loginForm = new Form();
            loginForm.Show();

            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Empty fields check
            if (register_username.Text == "" || register_password.Text == "" ||
                register_cPassword.Text == "" || role_comboBox.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Password length check
            if (register_password.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Password match check
            if (register_password.Text.Trim() != register_cPassword.Text.Trim())
            {
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkConnection())
            {
                connect.Open();
            }

            try
            {
                connect.Open();

                // Username duplicate check
                string checkUsernameQuery = "SELECT * FROM users WHERE username = @usern";
                using (SqlCommand cmd = new SqlCommand(checkUsernameQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Username already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Student ID duplicate check (only if Student)
                if (role_comboBox.Text == "Student")
                {
                    string checkStudentIdQuery = "SELECT * FROM users WHERE studentId = @sid";
                    using (SqlCommand cmd = new SqlCommand(checkStudentIdQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@sid", studentId_textBox.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("This Student ID is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Insert into users table and get new user ID
                string insertData = @"INSERT INTO users (username,password,role,studentId,studentName,date) 
                              OUTPUT INSERTED.id 
                              VALUES(@usern,@pass,@role,@studentId,@studentName,@date)";
                int newUserId;
                using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                {
                    insertCmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@role", role_comboBox.Text);

                    if (role_comboBox.Text == "Student")
                    {
                        insertCmd.Parameters.AddWithValue("@studentId", studentId_textBox.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@studentName", studentName_textBox.Text.Trim());
                    }
                    else
                    {
                        insertCmd.Parameters.AddWithValue("@studentId", DBNull.Value);
                        insertCmd.Parameters.AddWithValue("@studentName", DBNull.Value);
                    }

                    insertCmd.Parameters.AddWithValue("@date", DateTime.Now);

                    newUserId = (int)insertCmd.ExecuteScalar(); // ✅ এই ID StudentAccount এ ব্যবহার করা হবে
                }

                // ✅ Auto insert into StudentAccount only if Student
                if (role_comboBox.Text == "Student")
                {
                    string insertStudentAccount = @"INSERT INTO StudentAccount (StudentID, TotalBalance, LastUpdated)
                                            VALUES (@sid, 0, GETDATE())";
                    using (SqlCommand saCmd = new SqlCommand(insertStudentAccount, connect))
                    {
                        saCmd.Parameters.AddWithValue("@sid", newUserId); // users.id
                        saCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to Login Form
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }


        }
        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;


        }

        private void register_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void role_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = role_comboBox.SelectedItem.ToString();

            if (selectedRole == "Student")
            {
                
                studentId_label.Visible = true;
                studentId_textBox.Visible = true;

                studentName_label.Visible = true;
                studentName_textBox.Visible = true;
            }
            else
            {
               
                studentId_label.Visible = false;
                studentId_textBox.Visible = false;

                studentName_label.Visible = false;
                studentName_textBox.Visible = false;
            }



        }

        private void login_label_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
