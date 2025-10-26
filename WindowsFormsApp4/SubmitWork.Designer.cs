namespace WindowsFormsApp4
{
    partial class SubmitWork
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSubmissions = new System.Windows.Forms.DataGridView();
            this.dtpSubmission = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSubmitWork = new System.Windows.Forms.Button();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtWorkName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmissions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSubmissions);
            this.panel1.Controls.Add(this.dtpSubmission);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblUpload);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.btnSubmitWork);
            this.panel1.Controls.Add(this.lblTaskName);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtWorkName);
            this.panel1.Location = new System.Drawing.Point(46, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 582);
            this.panel1.TabIndex = 1;
            // 
            // dgvSubmissions
            // 
            this.dgvSubmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmissions.Location = new System.Drawing.Point(89, 270);
            this.dgvSubmissions.Name = "dgvSubmissions";
            this.dgvSubmissions.RowHeadersWidth = 51;
            this.dgvSubmissions.RowTemplate.Height = 24;
            this.dgvSubmissions.Size = new System.Drawing.Size(804, 289);
            this.dgvSubmissions.TabIndex = 9;
            // 
            // dtpSubmission
            // 
            this.dtpSubmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSubmission.Location = new System.Drawing.Point(166, 145);
            this.dtpSubmission.Name = "dtpSubmission";
            this.dtpSubmission.Size = new System.Drawing.Size(200, 22);
            this.dtpSubmission.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(86, 145);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date :";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(45, 101);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(83, 16);
            this.lblUpload.TabIndex = 6;
            this.lblUpload.Text = "Upload File :";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(166, 101);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(134, 22);
            this.txtFilePath.TabIndex = 5;
            // 
            // btnSubmitWork
            // 
            this.btnSubmitWork.Location = new System.Drawing.Point(209, 200);
            this.btnSubmitWork.Name = "btnSubmitWork";
            this.btnSubmitWork.Size = new System.Drawing.Size(134, 36);
            this.btnSubmitWork.TabIndex = 3;
            this.btnSubmitWork.Text = "Submit Work";
            this.btnSubmitWork.UseVisualStyleBackColor = true;
            this.btnSubmitWork.Click += new System.EventHandler(this.btnSubmitWork_Click);
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(44, 56);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(85, 16);
            this.lblTaskName.TabIndex = 2;
            this.lblTaskName.Text = "Work Name :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(329, 94);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(134, 36);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse.....";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtWorkName
            // 
            this.txtWorkName.Location = new System.Drawing.Point(166, 53);
            this.txtWorkName.Name = "txtWorkName";
            this.txtWorkName.Size = new System.Drawing.Size(134, 22);
            this.txtWorkName.TabIndex = 0;
            // 
            // SubmitWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SubmitWork";
            this.Size = new System.Drawing.Size(1103, 655);
            this.Load += new System.EventHandler(this.SubmitWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSubmissions;
        private System.Windows.Forms.DateTimePicker dtpSubmission;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSubmitWork;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtWorkName;
    }
}
