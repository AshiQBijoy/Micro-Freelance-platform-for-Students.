using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AdminForm : Form
    {
        private string loggedInAdminUsername;
        public AdminForm(string adminUsername)
        {
            InitializeComponent();
            loggedInAdminUsername = adminUsername;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            AdminWorkUpload uc = new AdminWorkUpload(loggedInAdminUsername);
            uc.Dock = DockStyle.Fill;

            LoadControl(uc); 


            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }

        public void LoadControl(UserControl uc)
        {
            mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        private void btnStudentProfile_Click(object sender, EventArgs e)
        {
            LoadControl(new StudentsProfile());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();


            this.Hide();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApproveAndPayment uc = new ApproveAndPayment();
            uc.Dock = DockStyle.Fill;

            // Clear previous controls from mainPanel and add the UserControl
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(uc);
        }
    }
}
