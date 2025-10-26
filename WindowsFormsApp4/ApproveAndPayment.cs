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
    public partial class ApproveAndPayment : UserControl
    {
        private SqlConnection connect = new SqlConnection(
            @"Data Source=LAPTOP-KSIVHBN0\SQLEXPRESS;Initial Catalog=MFFSS;Integrated Security=True;");

        public ApproveAndPayment()
        {
            InitializeComponent();
            LoadApplications();
            LoadSubmittedWorks();
        }
        private void LoadApplications()
        {
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT ApplicationID, WorkID, StudentID, Status, AppliedDate FROM WorkApplications", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvWorkApplications.DataSource = dt;
            }
            finally
            {
                connect.Close();
            }
        }
        private void LoadSubmittedWorks()
        {
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT SubmissionID, WorkID, StudentID, WorkName, FilePath, SubmitDate FROM StudentSubmittedWork", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSubmittedWork.DataSource = dt;
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvWorkApplications.SelectedRows.Count == 0) return;

            int applicationID = Convert.ToInt32(dgvWorkApplications.SelectedRows[0].Cells["ApplicationID"].Value);

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM WorkApplications WHERE ApplicationID=@id", connect);
                cmd.Parameters.AddWithValue("@id", applicationID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Application rejected.");
            }
            finally
            {
                connect.Close();
                LoadApplications();
            }
        }

        private void ApproveAndPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnApproveApplication_Click(object sender, EventArgs e)
        {
            if (dgvWorkApplications.SelectedRows.Count == 0) return;

            int applicationID = Convert.ToInt32(dgvWorkApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            int workID = Convert.ToInt32(dgvWorkApplications.SelectedRows[0].Cells["WorkID"].Value);
            string studentID = dgvWorkApplications.SelectedRows[0].Cells["StudentID"].Value.ToString();

            decimal workPayment = GetWorkPayment(workID);

            try
            {
                connect.Open();

                // Update Status
                SqlCommand cmd = new SqlCommand(
                    "UPDATE WorkApplications SET Status='Approved' WHERE ApplicationID=@id", connect);
                cmd.Parameters.AddWithValue("@id", applicationID);
                cmd.ExecuteNonQuery();

                // 50% payment add when approving application
                using (SqlCommand cmdTotalBalance = new SqlCommand(
                    @"IF EXISTS(SELECT 1 FROM StudentAccount WHERE StudentID=@sid)
                      UPDATE StudentAccount SET TotalBalance = TotalBalance + @amount, LastUpdated = GETDATE() WHERE StudentID=@sid
                    ELSE
                      INSERT INTO StudentAccount(StudentID, TotalBalance) VALUES(@sid, @amount)", connect))
                {
                    cmdTotalBalance.Parameters.AddWithValue("@sid", studentID);  // string
                    cmdTotalBalance.Parameters.AddWithValue("@amount", workPayment * 0.5m);
                    cmdTotalBalance.ExecuteNonQuery();
                }


                MessageBox.Show("Application approved and 50% payment added.");
            }
            finally
            {
                connect.Close();
                LoadApplications();
            }
        }

        private void btnApproveSubmission_Click(object sender, EventArgs e)
        {
            if (dgvSubmittedWork.SelectedRows.Count == 0) return;

            int workID = Convert.ToInt32(dgvSubmittedWork.SelectedRows[0].Cells["WorkID"].Value);
            string studentID = dgvSubmittedWork.SelectedRows[0].Cells["StudentID"].Value.ToString();

            decimal workPayment = GetWorkPayment(workID);

            try
            {
                connect.Open();

                // Update StudentAccount (remaining 50%)
                SqlCommand cmdTotalBalance = new SqlCommand(
                    @"IF EXISTS(SELECT 1 FROM StudentAccount WHERE StudentID=@sid)
                      UPDATE StudentAccount SET TotalBalance = TotalBalance + @amount, LastUpdated=GETDATE() WHERE StudentID=@sid
                      ELSE
                      INSERT INTO StudentAccount(StudentID, TotalBalance) VALUES(@sid, @amount)", connect);
                cmdTotalBalance.Parameters.AddWithValue("@sid", studentID);
                cmdTotalBalance.Parameters.AddWithValue("@amount", workPayment * 0.5m);
                cmdTotalBalance.ExecuteNonQuery();

                MessageBox.Show("Submission approved and remaining 50% payment added.");
            }
            finally
            {
                connect.Close();
                LoadSubmittedWorks();
            }
        }

        private void btnRejectSubmission_Click(object sender, EventArgs e)
        {
            if (dgvSubmittedWork.SelectedRows.Count == 0) return;

            int submissionID = Convert.ToInt32(dgvSubmittedWork.SelectedRows[0].Cells["SubmissionID"].Value);

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM StudentSubmittedWork WHERE SubmissionID=@id", connect);
                cmd.Parameters.AddWithValue("@id", submissionID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Submission rejected.");
            }
            finally
            {
                connect.Close();
                LoadSubmittedWorks();
            }

        }
        private decimal GetWorkPayment(int workID)
        {
            decimal payment = 0;
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT PaymentAmount FROM AdminWork WHERE WorkID=@id", connect);
                cmd.Parameters.AddWithValue("@id", workID);
                object result = cmd.ExecuteScalar();
                if (result != null) payment = Convert.ToDecimal(result);
            }
            finally
            {
                connect.Close();
            }
            return payment;
        }
        
    }
}
