namespace WindowsFormsApp4
{
    partial class RegisterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.button1 = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.role_comboBox = new System.Windows.Forms.ComboBox();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_cPassword = new System.Windows.Forms.TextBox();
            this.login_lable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.studentId_textBox = new System.Windows.Forms.TextBox();
            this.studentName_textBox = new System.Windows.Forms.TextBox();
            this.studentId_label = new System.Windows.Forms.Label();
            this.studentName_label = new System.Windows.Forms.Label();
            this.login_label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(749, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(84, 175);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(232, 30);
            this.register_password.TabIndex = 2;
            this.register_password.TextChanged += new System.EventHandler(this.register_password_TextChanged);
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(84, 118);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(232, 27);
            this.register_username.TabIndex = 1;
            this.register_username.TextChanged += new System.EventHandler(this.register_username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(252, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Account";
            // 
            // login_label
            // 
            this.login_label.BackColor = System.Drawing.Color.White;
            this.login_label.Controls.Add(this.studentName_label);
            this.login_label.Controls.Add(this.studentId_label);
            this.login_label.Controls.Add(this.studentName_textBox);
            this.login_label.Controls.Add(this.studentId_textBox);
            this.login_label.Controls.Add(this.pictureBox4);
            this.login_label.Controls.Add(this.role_comboBox);
            this.login_label.Controls.Add(this.register_showPass);
            this.login_label.Controls.Add(this.pictureBox3);
            this.login_label.Controls.Add(this.pictureBox2);
            this.login_label.Controls.Add(this.pictureBox1);
            this.login_label.Controls.Add(this.register_cPassword);
            this.login_label.Controls.Add(this.login_lable);
            this.login_label.Controls.Add(this.label2);
            this.login_label.Controls.Add(this.register_btn);
            this.login_label.Controls.Add(this.register_password);
            this.login_label.Controls.Add(this.register_username);
            this.login_label.Controls.Add(this.label1);
            this.login_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(34, 45);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(737, 449);
            this.login_label.TabIndex = 2;
            this.login_label.Paint += new System.Windows.Forms.PaintEventHandler(this.login_label_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(473, 118);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // role_comboBox
            // 
            this.role_comboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_comboBox.FormattingEnabled = true;
            this.role_comboBox.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.role_comboBox.Location = new System.Drawing.Point(519, 118);
            this.role_comboBox.Name = "role_comboBox";
            this.role_comboBox.Size = new System.Drawing.Size(197, 27);
            this.role_comboBox.TabIndex = 12;
            this.role_comboBox.SelectedIndexChanged += new System.EventHandler(this.role_comboBox_SelectedIndexChanged);
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPass.Location = new System.Drawing.Point(141, 269);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(175, 27);
            this.register_showPass.TabIndex = 11;
            this.register_showPass.Text = "Show Password";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // register_cPassword
            // 
            this.register_cPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cPassword.Location = new System.Drawing.Point(84, 233);
            this.register_cPassword.Name = "register_cPassword";
            this.register_cPassword.PasswordChar = '*';
            this.register_cPassword.Size = new System.Drawing.Size(232, 30);
            this.register_cPassword.TabIndex = 7;
            // 
            // login_lable
            // 
            this.login_lable.AutoSize = true;
            this.login_lable.BackColor = System.Drawing.Color.Transparent;
            this.login_lable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lable.ForeColor = System.Drawing.Color.RoyalBlue;
            this.login_lable.Location = new System.Drawing.Point(418, 419);
            this.login_lable.Name = "login_lable";
            this.login_lable.Size = new System.Drawing.Size(98, 20);
            this.login_lable.TabIndex = 6;
            this.login_lable.Text = "Sign in here";
            this.login_lable.Click += new System.EventHandler(this.login_lable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Already have an account?";
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(223, 347);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(275, 53);
            this.register_btn.TabIndex = 3;
            this.register_btn.Text = "SignUp";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // studentId_textBox
            // 
            this.studentId_textBox.Location = new System.Drawing.Point(519, 171);
            this.studentId_textBox.Name = "studentId_textBox";
            this.studentId_textBox.Size = new System.Drawing.Size(197, 34);
            this.studentId_textBox.TabIndex = 14;
            // 
            // studentName_textBox
            // 
            this.studentName_textBox.Location = new System.Drawing.Point(519, 234);
            this.studentName_textBox.Name = "studentName_textBox";
            this.studentName_textBox.Size = new System.Drawing.Size(197, 34);
            this.studentName_textBox.TabIndex = 15;
            // 
            // studentId_label
            // 
            this.studentId_label.AutoSize = true;
            this.studentId_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentId_label.Location = new System.Drawing.Point(418, 181);
            this.studentId_label.Name = "studentId_label";
            this.studentId_label.Size = new System.Drawing.Size(95, 20);
            this.studentId_label.TabIndex = 16;
            this.studentId_label.Text = "Student ID";
            this.studentId_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // studentName_label
            // 
            this.studentName_label.AutoSize = true;
            this.studentName_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName_label.Location = new System.Drawing.Point(388, 239);
            this.studentName_label.Name = "studentName_label";
            this.studentName_label.Size = new System.Drawing.Size(125, 20);
            this.studentName_label.TabIndex = 17;
            this.studentName_label.Text = "Student Name";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(815, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.login_label.ResumeLayout(false);
            this.login_label.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel login_label;
        private System.Windows.Forms.Label login_lable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox register_cPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.ComboBox role_comboBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox studentName_textBox;
        private System.Windows.Forms.TextBox studentId_textBox;
        private System.Windows.Forms.Label studentId_label;
        private System.Windows.Forms.Label studentName_label;
    }
}