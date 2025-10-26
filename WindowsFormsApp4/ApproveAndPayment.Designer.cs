namespace WindowsFormsApp4
{
    partial class ApproveAndPayment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnApproveApplication = new System.Windows.Forms.Button();
            this.btnRejectApplication = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvWorkApplications = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSubmittedWork = new System.Windows.Forms.DataGridView();
            this.btnApproveSubmission = new System.Windows.Forms.Button();
            this.btnRejectSubmission = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkApplications)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmittedWork)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accept or Reject";
            // 
            // btnApproveApplication
            // 
            this.btnApproveApplication.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveApplication.Location = new System.Drawing.Point(231, 176);
            this.btnApproveApplication.Name = "btnApproveApplication";
            this.btnApproveApplication.Size = new System.Drawing.Size(167, 53);
            this.btnApproveApplication.TabIndex = 2;
            this.btnApproveApplication.Text = "Approve";
            this.btnApproveApplication.UseVisualStyleBackColor = true;
            this.btnApproveApplication.Click += new System.EventHandler(this.btnApproveApplication_Click);
            // 
            // btnRejectApplication
            // 
            this.btnRejectApplication.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectApplication.Location = new System.Drawing.Point(619, 176);
            this.btnRejectApplication.Name = "btnRejectApplication";
            this.btnRejectApplication.Size = new System.Drawing.Size(166, 53);
            this.btnRejectApplication.TabIndex = 3;
            this.btnRejectApplication.Text = "Reject";
            this.btnRejectApplication.UseVisualStyleBackColor = true;
            this.btnRejectApplication.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvWorkApplications);
            this.panel1.Controls.Add(this.btnApproveApplication);
            this.panel1.Controls.Add(this.btnRejectApplication);
            this.panel1.Location = new System.Drawing.Point(20, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 244);
            this.panel1.TabIndex = 4;
            // 
            // dgvWorkApplications
            // 
            this.dgvWorkApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkApplications.Location = new System.Drawing.Point(67, 0);
            this.dgvWorkApplications.Name = "dgvWorkApplications";
            this.dgvWorkApplications.RowHeadersWidth = 51;
            this.dgvWorkApplications.RowTemplate.Height = 24;
            this.dgvWorkApplications.Size = new System.Drawing.Size(934, 170);
            this.dgvWorkApplications.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSubmittedWork);
            this.panel2.Controls.Add(this.btnApproveSubmission);
            this.panel2.Controls.Add(this.btnRejectSubmission);
            this.panel2.Location = new System.Drawing.Point(20, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 244);
            this.panel2.TabIndex = 5;
            // 
            // dgvSubmittedWork
            // 
            this.dgvSubmittedWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmittedWork.Location = new System.Drawing.Point(67, 0);
            this.dgvSubmittedWork.Name = "dgvSubmittedWork";
            this.dgvSubmittedWork.RowHeadersWidth = 51;
            this.dgvSubmittedWork.RowTemplate.Height = 24;
            this.dgvSubmittedWork.Size = new System.Drawing.Size(934, 170);
            this.dgvSubmittedWork.TabIndex = 4;
            // 
            // btnApproveSubmission
            // 
            this.btnApproveSubmission.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveSubmission.Location = new System.Drawing.Point(231, 176);
            this.btnApproveSubmission.Name = "btnApproveSubmission";
            this.btnApproveSubmission.Size = new System.Drawing.Size(167, 53);
            this.btnApproveSubmission.TabIndex = 2;
            this.btnApproveSubmission.Text = "Approve";
            this.btnApproveSubmission.UseVisualStyleBackColor = true;
            this.btnApproveSubmission.Click += new System.EventHandler(this.btnApproveSubmission_Click);
            // 
            // btnRejectSubmission
            // 
            this.btnRejectSubmission.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectSubmission.Location = new System.Drawing.Point(619, 176);
            this.btnRejectSubmission.Name = "btnRejectSubmission";
            this.btnRejectSubmission.Size = new System.Drawing.Size(166, 53);
            this.btnRejectSubmission.TabIndex = 3;
            this.btnRejectSubmission.Text = "Reject";
            this.btnRejectSubmission.UseVisualStyleBackColor = true;
            this.btnRejectSubmission.Click += new System.EventHandler(this.btnRejectSubmission_Click);
            // 
            // ApproveAndPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ApproveAndPayment";
            this.Size = new System.Drawing.Size(1103, 655);
            this.Load += new System.EventHandler(this.ApproveAndPayment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkApplications)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmittedWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApproveApplication;
        private System.Windows.Forms.Button btnRejectApplication;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvWorkApplications;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSubmittedWork;
        private System.Windows.Forms.Button btnApproveSubmission;
        private System.Windows.Forms.Button btnRejectSubmission;
    }
}
