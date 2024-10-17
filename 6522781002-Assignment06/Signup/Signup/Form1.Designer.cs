namespace Signup
{
    partial class signup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            occupation = new TextBox();
            email = new TextBox();
            birthDatePick = new DateTimePicker();
            sxCombo = new ComboBox();
            lname = new TextBox();
            fname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            submit = new Button();
            groupBox2 = new GroupBox();
            Password = new TextBox();
            Username = new TextBox();
            label12 = new Label();
            label13 = new Label();
            groupBox3 = new GroupBox();
            Signup_Confirm_Password = new TextBox();
            label10 = new Label();
            Signup_password = new TextBox();
            Signup_Username = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(379, 42);
            label1.TabIndex = 0;
            label1.Text = "lnformation Collector";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(occupation);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(birthDatePick);
            groupBox1.Controls.Add(sxCombo);
            groupBox1.Controls.Add(lname);
            groupBox1.Controls.Add(fname);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 319);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // occupation
            // 
            occupation.Location = new Point(163, 261);
            occupation.Name = "occupation";
            occupation.Size = new Size(294, 34);
            occupation.TabIndex = 11;
            // 
            // email
            // 
            email.Location = new Point(163, 215);
            email.Name = "email";
            email.Size = new Size(294, 34);
            email.TabIndex = 10;
            // 
            // birthDatePick
            // 
            birthDatePick.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthDatePick.Location = new Point(163, 169);
            birthDatePick.Name = "birthDatePick";
            birthDatePick.Size = new Size(294, 34);
            birthDatePick.TabIndex = 9;
            // 
            // sxCombo
            // 
            sxCombo.FormattingEnabled = true;
            sxCombo.Items.AddRange(new object[] { "Male", "Female" });
            sxCombo.Location = new Point(163, 124);
            sxCombo.Name = "sxCombo";
            sxCombo.Size = new Size(294, 37);
            sxCombo.TabIndex = 8;
            // 
            // lname
            // 
            lname.Location = new Point(163, 78);
            lname.Name = "lname";
            lname.Size = new Size(294, 34);
            lname.TabIndex = 7;
            // 
            // fname
            // 
            fname.Location = new Point(163, 36);
            fname.Name = "fname";
            fname.Size = new Size(294, 34);
            fname.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 266);
            label7.Name = "label7";
            label7.Size = new Size(159, 29);
            label7.TabIndex = 5;
            label7.Text = "Occupation: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(77, 224);
            label6.Name = "label6";
            label6.Size = new Size(93, 29);
            label6.TabIndex = 4;
            label6.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 180);
            label5.Name = "label5";
            label5.Size = new Size(142, 29);
            label5.TabIndex = 3;
            label5.Text = "Birth Date: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(98, 134);
            label4.Name = "label4";
            label4.Size = new Size(64, 29);
            label4.TabIndex = 2;
            label4.Text = "Sex:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 86);
            label3.Name = "label3";
            label3.Size = new Size(146, 29);
            label3.TabIndex = 1;
            label3.Text = "Last name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 39);
            label2.Name = "label2";
            label2.Size = new Size(150, 29);
            label2.TabIndex = 0;
            label2.Text = "First name: ";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ButtonFace;
            submit.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            submit.Location = new Point(287, 419);
            submit.Name = "submit";
            submit.Size = new Size(586, 44);
            submit.TabIndex = 2;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Window;
            groupBox2.Controls.Add(Password);
            groupBox2.Controls.Add(Username);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(492, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 135);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            // 
            // Password
            // 
            Password.Location = new Point(251, 78);
            Password.Name = "Password";
            Password.Size = new Size(294, 34);
            Password.TabIndex = 7;
            // 
            // Username
            // 
            Username.Location = new Point(251, 36);
            Username.Name = "Username";
            Username.Size = new Size(294, 34);
            Username.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(113, 86);
            label12.Name = "label12";
            label12.Size = new Size(135, 29);
            label12.TabIndex = 1;
            label12.Text = "Password:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(110, 39);
            label13.Name = "label13";
            label13.Size = new Size(146, 29);
            label13.TabIndex = 0;
            label13.Text = "Username: ";
            label13.Click += label13_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Window;
            groupBox3.Controls.Add(Signup_Confirm_Password);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(Signup_password);
            groupBox3.Controls.Add(Signup_Username);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(492, 228);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(575, 185);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Singup";
            // 
            // Signup_Confirm_Password
            // 
            Signup_Confirm_Password.Location = new Point(251, 132);
            Signup_Confirm_Password.Name = "Signup_Confirm_Password";
            Signup_Confirm_Password.Size = new Size(294, 34);
            Signup_Confirm_Password.TabIndex = 9;
            Signup_Confirm_Password.TextChanged += textBox5_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(6, 137);
            label10.Name = "label10";
            label10.Size = new Size(233, 29);
            label10.TabIndex = 8;
            label10.Text = "Confirm Password:";
            // 
            // Signup_password
            // 
            Signup_password.Location = new Point(251, 85);
            Signup_password.Name = "Signup_password";
            Signup_password.Size = new Size(294, 34);
            Signup_password.TabIndex = 7;
            // 
            // Signup_Username
            // 
            Signup_Username.Location = new Point(251, 37);
            Signup_Username.Name = "Signup_Username";
            Signup_Username.Size = new Size(294, 34);
            Signup_Username.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(104, 92);
            label8.Name = "label8";
            label8.Size = new Size(135, 29);
            label8.TabIndex = 1;
            label8.Text = "Password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(99, 40);
            label9.Name = "label9";
            label9.Size = new Size(146, 29);
            label9.TabIndex = 0;
            label9.Text = "Username: ";
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 475);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(submit);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "signup";
            Text = "Sign-up form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker birthDatePick;
        private ComboBox sxCombo;
        private TextBox lname;
        private TextBox fname;
        private TextBox occupation;
        private TextBox email;
        private Button submit;
        private GroupBox groupBox2;
        private TextBox Password;
        private TextBox Username;
        private Label label12;
        private Label label13;
        private GroupBox groupBox3;
        private TextBox Signup_Confirm_Password;
        private Label label10;
        private TextBox Signup_password;
        private TextBox Signup_Username;
        private Label label8;
        private Label label9;
    }
}