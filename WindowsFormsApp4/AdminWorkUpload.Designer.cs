namespace WindowsFormsApp4
{
    partial class AdminWorkUpload
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.numPayment = new System.Windows.Forms.NumericUpDown();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblTaskDescripition = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.dgvWorkList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Work Upload";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.lblFile);
            this.panel1.Controls.Add(this.numPayment);
            this.panel1.Controls.Add(this.lblPaymentAmount);
            this.panel1.Controls.Add(this.dtpDeadline);
            this.panel1.Controls.Add(this.lblDeadline);
            this.panel1.Controls.Add(this.txtTaskDescription);
            this.panel1.Controls.Add(this.lblTaskDescripition);
            this.panel1.Controls.Add(this.txtTaskName);
            this.panel1.Controls.Add(this.lblTaskName);
            this.panel1.Location = new System.Drawing.Point(16, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 245);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(909, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 47);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(720, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 47);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(541, 160);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(136, 47);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(871, 89);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(111, 38);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtFilePath.Location = new System.Drawing.Point(683, 92);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(153, 31);
            this.txtFilePath.TabIndex = 9;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(542, 97);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(135, 23);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = " Upload File :";
            // 
            // numPayment
            // 
            this.numPayment.Location = new System.Drawing.Point(736, 42);
            this.numPayment.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numPayment.Name = "numPayment";
            this.numPayment.Size = new System.Drawing.Size(120, 22);
            this.numPayment.TabIndex = 7;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAmount.Location = new System.Drawing.Point(542, 41);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(186, 23);
            this.lblPaymentAmount.TabIndex = 6;
            this.lblPaymentAmount.Text = "Payment Amount :";
            this.lblPaymentAmount.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Location = new System.Drawing.Point(135, 161);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(258, 23);
            this.dtpDeadline.TabIndex = 5;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(13, 160);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(107, 23);
            this.lblDeadline.TabIndex = 4;
            this.lblDeadline.Text = "Deadline :";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtTaskDescription.Location = new System.Drawing.Point(210, 97);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(153, 33);
            this.txtTaskDescription.TabIndex = 3;
            // 
            // lblTaskDescripition
            // 
            this.lblTaskDescripition.AutoSize = true;
            this.lblTaskDescripition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskDescripition.Location = new System.Drawing.Point(13, 100);
            this.lblTaskDescripition.Name = "lblTaskDescripition";
            this.lblTaskDescripition.Size = new System.Drawing.Size(191, 23);
            this.lblTaskDescripition.TabIndex = 2;
            this.lblTaskDescripition.Text = "Task Descripition :";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtTaskName.Location = new System.Drawing.Point(160, 38);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(153, 31);
            this.txtTaskName.TabIndex = 1;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(13, 41);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(130, 23);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Task Name :";
            // 
            // dgvWorkList
            // 
            this.dgvWorkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkList.Location = new System.Drawing.Point(121, 350);
            this.dgvWorkList.Name = "dgvWorkList";
            this.dgvWorkList.RowHeadersWidth = 51;
            this.dgvWorkList.RowTemplate.Height = 24;
            this.dgvWorkList.Size = new System.Drawing.Size(847, 261);
            this.dgvWorkList.TabIndex = 2;
            // 
            // AdminWorkUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvWorkList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AdminWorkUpload";
            this.Size = new System.Drawing.Size(1103, 655);
            this.Load += new System.EventHandler(this.AdminWorkUpload_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblTaskDescripition;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.NumericUpDown numPayment;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvWorkList;
    }
}
