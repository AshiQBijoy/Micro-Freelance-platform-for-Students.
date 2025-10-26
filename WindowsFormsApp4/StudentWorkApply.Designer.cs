namespace WindowsFormsApp4
{
    partial class StudentWorkApply
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
            this.dgvWorks = new System.Windows.Forms.DataGridView();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work List";
            // 
            // dgvWorks
            // 
            this.dgvWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorks.Location = new System.Drawing.Point(80, 85);
            this.dgvWorks.Name = "dgvWorks";
            this.dgvWorks.RowHeadersWidth = 51;
            this.dgvWorks.RowTemplate.Height = 24;
            this.dgvWorks.Size = new System.Drawing.Size(909, 400);
            this.dgvWorks.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(436, 514);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(252, 73);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // StudentWorkApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.dgvWorks);
            this.Controls.Add(this.label1);
            this.Name = "StudentWorkApply";
            this.Size = new System.Drawing.Size(1103, 655);
            this.Load += new System.EventHandler(this.StudentWorkApply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWorks;
        private System.Windows.Forms.Button btnApply;
    }
}
