namespace WindowsFormsApp4
{
    partial class MyProfile
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsernameTitle = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentIdTitle = new System.Windows.Forms.Label();
            this.lblSkillsTitle = new System.Windows.Forms.Label();
            this.lblSelectedSkillsTitle = new System.Windows.Forms.Label();
            this.comboBoxSkills = new System.Windows.Forms.ComboBox();
            this.buttonAddSkills = new System.Windows.Forms.Button();
            this.listBoxSelectedSkills = new System.Windows.Forms.ListBox();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalBalance = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTotalBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRemoveSkill);
            this.panel1.Controls.Add(this.listBoxSelectedSkills);
            this.panel1.Controls.Add(this.buttonAddSkills);
            this.panel1.Controls.Add(this.comboBoxSkills);
            this.panel1.Controls.Add(this.lblSelectedSkillsTitle);
            this.panel1.Controls.Add(this.lblSkillsTitle);
            this.panel1.Controls.Add(this.lblStudentID);
            this.panel1.Controls.Add(this.lblStudentIdTitle);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblUsernameTitle);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblNameTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(53, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 520);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitle.Location = new System.Drawing.Point(384, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Profile";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.Location = new System.Drawing.Point(82, 148);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(93, 27);
            this.lblNameTitle.TabIndex = 1;
            this.lblNameTitle.Text = "Name  :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(264, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(264, 225);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 27);
            this.lblUsername.TabIndex = 4;
            // 
            // lblUsernameTitle
            // 
            this.lblUsernameTitle.AutoSize = true;
            this.lblUsernameTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTitle.Location = new System.Drawing.Point(82, 225);
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            this.lblUsernameTitle.Size = new System.Drawing.Size(143, 27);
            this.lblUsernameTitle.TabIndex = 3;
            this.lblUsernameTitle.Text = "Username  :";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblStudentID.Location = new System.Drawing.Point(264, 296);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(0, 27);
            this.lblStudentID.TabIndex = 6;
            // 
            // lblStudentIdTitle
            // 
            this.lblStudentIdTitle.AutoSize = true;
            this.lblStudentIdTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentIdTitle.Location = new System.Drawing.Point(82, 296);
            this.lblStudentIdTitle.Name = "lblStudentIdTitle";
            this.lblStudentIdTitle.Size = new System.Drawing.Size(147, 27);
            this.lblStudentIdTitle.TabIndex = 5;
            this.lblStudentIdTitle.Text = "Student ID  :";
            // 
            // lblSkillsTitle
            // 
            this.lblSkillsTitle.AutoSize = true;
            this.lblSkillsTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillsTitle.Location = new System.Drawing.Point(82, 372);
            this.lblSkillsTitle.Name = "lblSkillsTitle";
            this.lblSkillsTitle.Size = new System.Drawing.Size(285, 27);
            this.lblSkillsTitle.TabIndex = 7;
            this.lblSkillsTitle.Text = "Skills (Choose from list) ";
            // 
            // lblSelectedSkillsTitle
            // 
            this.lblSelectedSkillsTitle.AutoSize = true;
            this.lblSelectedSkillsTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSkillsTitle.Location = new System.Drawing.Point(592, 148);
            this.lblSelectedSkillsTitle.Name = "lblSelectedSkillsTitle";
            this.lblSelectedSkillsTitle.Size = new System.Drawing.Size(122, 27);
            this.lblSelectedSkillsTitle.TabIndex = 8;
            this.lblSelectedSkillsTitle.Text = "My Skills  ";
            // 
            // comboBoxSkills
            // 
            this.comboBoxSkills.FormattingEnabled = true;
            this.comboBoxSkills.Items.AddRange(new object[] {
            "C#",
            "Java",
            "C++",
            "Python",
            "SQL",
            "HTML/CSS"});
            this.comboBoxSkills.Location = new System.Drawing.Point(87, 429);
            this.comboBoxSkills.Name = "comboBoxSkills";
            this.comboBoxSkills.Size = new System.Drawing.Size(138, 24);
            this.comboBoxSkills.TabIndex = 9;
            this.comboBoxSkills.SelectedIndexChanged += new System.EventHandler(this.comboBoxSkills_SelectedIndexChanged);
            // 
            // buttonAddSkills
            // 
            this.buttonAddSkills.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddSkills.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddSkills.FlatAppearance.BorderSize = 0;
            this.buttonAddSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSkills.ForeColor = System.Drawing.Color.White;
            this.buttonAddSkills.Location = new System.Drawing.Point(253, 419);
            this.buttonAddSkills.Name = "buttonAddSkills";
            this.buttonAddSkills.Size = new System.Drawing.Size(114, 43);
            this.buttonAddSkills.TabIndex = 10;
            this.buttonAddSkills.Text = "Add Skills";
            this.buttonAddSkills.UseVisualStyleBackColor = false;
            this.buttonAddSkills.Click += new System.EventHandler(this.buttonAddSkills_Click);
            // 
            // listBoxSelectedSkills
            // 
            this.listBoxSelectedSkills.FormattingEnabled = true;
            this.listBoxSelectedSkills.ItemHeight = 16;
            this.listBoxSelectedSkills.Location = new System.Drawing.Point(597, 190);
            this.listBoxSelectedSkills.Name = "listBoxSelectedSkills";
            this.listBoxSelectedSkills.Size = new System.Drawing.Size(177, 148);
            this.listBoxSelectedSkills.TabIndex = 11;
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveSkill.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnRemoveSkill.FlatAppearance.BorderSize = 0;
            this.btnRemoveSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSkill.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSkill.Location = new System.Drawing.Point(253, 468);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(114, 43);
            this.btnRemoveSkill.TabIndex = 12;
            this.btnRemoveSkill.Text = "Remove Skills";
            this.btnRemoveSkill.UseVisualStyleBackColor = false;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "My Balance :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotalBalance
            // 
            this.txtTotalBalance.Location = new System.Drawing.Point(652, 422);
            this.txtTotalBalance.Name = "txtTotalBalance";
            this.txtTotalBalance.ReadOnly = true;
            this.txtTotalBalance.Size = new System.Drawing.Size(100, 22);
            this.txtTotalBalance.TabIndex = 14;
            this.txtTotalBalance.TextChanged += new System.EventHandler(this.txtTotalBalance_TextChanged);
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MyProfile";
            this.Size = new System.Drawing.Size(1103, 655);
            this.Load += new System.EventHandler(this.MyProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentIdTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblSkillsTitle;
        private System.Windows.Forms.Label lblSelectedSkillsTitle;
        private System.Windows.Forms.Button buttonAddSkills;
        private System.Windows.Forms.ComboBox comboBoxSkills;
        private System.Windows.Forms.ListBox listBoxSelectedSkills;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.TextBox txtTotalBalance;
        private System.Windows.Forms.Label label1;
    }
}
