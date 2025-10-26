namespace WindowsFormsApp4
{
    partial class MyWork
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
            this.dgvMyWork = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyWork)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMyWork);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblUpload);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblTaskName);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.txtTaskName);
            this.panel1.Location = new System.Drawing.Point(44, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 582);
            this.panel1.TabIndex = 0;
            // 
            // dgvMyWork
            // 
            this.dgvMyWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyWork.Location = new System.Drawing.Point(89, 270);
            this.dgvMyWork.Name = "dgvMyWork";
            this.dgvMyWork.RowHeadersWidth = 51;
            this.dgvMyWork.RowTemplate.Height = 24;
            this.dgvMyWork.Size = new System.Drawing.Size(804, 289);
            this.dgvMyWork.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(166, 145);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 8;
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
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(329, 186);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 36);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(166, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Work";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(44, 56);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(84, 16);
            this.lblTaskName.TabIndex = 2;
            this.lblTaskName.Text = "Task Name :";
            this.lblTaskName.Click += new System.EventHandler(this.lblTaskName_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(329, 94);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(134, 36);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Browse.....";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(166, 53);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(134, 22);
            this.txtTaskName.TabIndex = 0;
            // 
            // MyWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MyWork";
            this.Size = new System.Drawing.Size(1103, 655);
            this.Load += new System.EventHandler(this.MyWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvMyWork;
    }
}
