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
    public partial class StudentForm : Form
    {


        private string currentStudentName;
        private string currentUsername;
        private string currentStudentID;

        public StudentForm(string studentName, string username, string studentID)
        {
            InitializeComponent();

            currentStudentName = studentName;
            currentUsername = username;
            currentStudentID = studentID;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Panel এ আগে যা আছে তা মুছে দাও
            panelContainer.Controls.Clear();

            // MyProfile UserControl তৈরি
            // ধরো তোমার Student info variables আছে: currentStudentName, currentUsername, currentStudentID
            MyProfile myProfileUC = new MyProfile(currentStudentName, currentUsername, currentStudentID);


            // Panel-এ fill করে add করো
            myProfileUC.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(myProfileUC);

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

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            MyWork myWorkUC = new MyWork(currentStudentID);

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myWorkUC);
            myWorkUC.Dock = DockStyle.Fill;


        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentWorkApply workApplyUC = new StudentWorkApply(currentStudentID);

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(workApplyUC);
            workApplyUC.Dock = DockStyle.Fill;
        }

        private void btnSubmitWork_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentStudentID))
            {
                MessageBox.Show("Student ID is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SubmitWork submitWorkUC = new SubmitWork(currentStudentID);
            submitWorkUC.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(submitWorkUC);

        }

        public static class Session
        {
            public static string StudentID { get; set; }
            public static string StudentName { get; set; }
            public static string Username { get; set; }
        }
    }
}
