namespace WindowsFormsApp4
{
    partial class StudentsProfile
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnViewWork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewSkills = new System.Windows.Forms.Button();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvWork);
            this.panel1.Controls.Add(this.lstSkills);
            this.panel1.Controls.Add(this.btnViewSkills);
            this.panel1.Controls.Add(this.btnViewWork);
            this.panel1.Controls.Add(this.dgvStudents);
            this.panel1.Location = new System.Drawing.Point(33, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 582);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(36, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 89);
            this.panel3.TabIndex = 0;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 95);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(303, 346);
            this.dgvStudents.TabIndex = 0;
            // 
            // btnViewWork
            // 
            this.btnViewWork.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWork.Location = new System.Drawing.Point(698, 465);
            this.btnViewWork.Name = "btnViewWork";
            this.btnViewWork.Size = new System.Drawing.Size(225, 89);
            this.btnViewWork.TabIndex = 1;
            this.btnViewWork.Text = "View Work";
            this.btnViewWork.UseVisualStyleBackColor = true;
            this.btnViewWork.Click += new System.EventHandler(this.btnViewWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Profile";
            // 
            // btnViewSkills
            // 
            this.btnViewSkills.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSkills.Location = new System.Drawing.Point(321, 465);
            this.btnViewSkills.Name = "btnViewSkills";
            this.btnViewSkills.Size = new System.Drawing.Size(234, 89);
            this.btnViewSkills.TabIndex = 2;
            this.btnViewSkills.Text = "View Skills";
            this.btnViewSkills.UseVisualStyleBackColor = true;
            this.btnViewSkills.Click += new System.EventHandler(this.btnViewSkills_Click);
            // 
            // lstSkills
            // 
            this.lstSkills.FormattingEnabled = true;
            this.lstSkills.ItemHeight = 16;
            this.lstSkills.Location = new System.Drawing.Point(321, 95);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(234, 340);
            this.lstSkills.TabIndex = 3;
            // 
            // dgvWork
            // 
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Location = new System.Drawing.Point(561, 95);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.RowHeadersWidth = 51;
            this.dgvWork.RowTemplate.Height = 24;
            this.dgvWork.Size = new System.Drawing.Size(453, 346);
            this.dgvWork.TabIndex = 4;
            // 
            // StudentsProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StudentsProfile";
            this.Size = new System.Drawing.Size(1103, 655);
            this.Load += new System.EventHandler(this.StudentsProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnViewWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewSkills;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.ListBox lstSkills;
    }
}
