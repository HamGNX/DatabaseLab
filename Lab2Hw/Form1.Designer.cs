namespace Lab2Hw
{
    partial class Form1
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
            this.boxFnavi = new System.Windows.Forms.GroupBox();
            this.lblLab = new System.Windows.Forms.Label();
            this.boxUserInf = new System.Windows.Forms.GroupBox();
            this.btnProf = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGr = new System.Windows.Forms.Button();
            this.boxAccInf = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.ComboBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblConPass = new System.Windows.Forms.Label();
            this.lblUserGr = new System.Windows.Forms.Label();
            this.radInstruc = new System.Windows.Forms.RadioButton();
            this.radTA = new System.Windows.Forms.RadioButton();
            this.radStu = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGrAd = new System.Windows.Forms.Button();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.boxFnavi.SuspendLayout();
            this.boxUserInf.SuspendLayout();
            this.boxAccInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxFnavi
            // 
            this.boxFnavi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.boxFnavi.Controls.Add(this.btnGrAd);
            this.boxFnavi.Controls.Add(this.btnGr);
            this.boxFnavi.Controls.Add(this.btnAdd);
            this.boxFnavi.Controls.Add(this.btnProf);
            this.boxFnavi.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFnavi.Location = new System.Drawing.Point(12, 171);
            this.boxFnavi.Name = "boxFnavi";
            this.boxFnavi.Size = new System.Drawing.Size(345, 762);
            this.boxFnavi.TabIndex = 0;
            this.boxFnavi.TabStop = false;
            this.boxFnavi.Text = "Form Navigation";
            this.boxFnavi.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLab.Font = new System.Drawing.Font("Arial Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab.Location = new System.Drawing.Point(19, 52);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(822, 74);
            this.lblLab.TabIndex = 1;
            this.lblLab.Text = "CSS326 Laboratory System";
            this.lblLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxUserInf
            // 
            this.boxUserInf.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.boxUserInf.Controls.Add(this.txtEmail);
            this.boxUserInf.Controls.Add(this.txtSname);
            this.boxUserInf.Controls.Add(this.txtFname);
            this.boxUserInf.Controls.Add(this.txtTitle);
            this.boxUserInf.Controls.Add(this.lblEmail);
            this.boxUserInf.Controls.Add(this.lblLname);
            this.boxUserInf.Controls.Add(this.lblFname);
            this.boxUserInf.Controls.Add(this.lblTitle);
            this.boxUserInf.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUserInf.Location = new System.Drawing.Point(363, 172);
            this.boxUserInf.Name = "boxUserInf";
            this.boxUserInf.Size = new System.Drawing.Size(933, 342);
            this.boxUserInf.TabIndex = 2;
            this.boxUserInf.TabStop = false;
            this.boxUserInf.Text = "User Information";
            // 
            // btnProf
            // 
            this.btnProf.Location = new System.Drawing.Point(6, 53);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(333, 57);
            this.btnProf.TabIndex = 0;
            this.btnProf.Text = "User Profile";
            this.btnProf.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "User Add-in";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnGr
            // 
            this.btnGr.Location = new System.Drawing.Point(6, 179);
            this.btnGr.Name = "btnGr";
            this.btnGr.Size = new System.Drawing.Size(333, 57);
            this.btnGr.TabIndex = 2;
            this.btnGr.Text = "User Group";
            this.btnGr.UseVisualStyleBackColor = true;
            // 
            // boxAccInf
            // 
            this.boxAccInf.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.boxAccInf.Controls.Add(this.txtConPass);
            this.boxAccInf.Controls.Add(this.btnSubmit);
            this.boxAccInf.Controls.Add(this.txtPass);
            this.boxAccInf.Controls.Add(this.txtUser);
            this.boxAccInf.Controls.Add(this.radStu);
            this.boxAccInf.Controls.Add(this.radTA);
            this.boxAccInf.Controls.Add(this.radInstruc);
            this.boxAccInf.Controls.Add(this.lblUserGr);
            this.boxAccInf.Controls.Add(this.lblConPass);
            this.boxAccInf.Controls.Add(this.lblPass);
            this.boxAccInf.Controls.Add(this.lblUser);
            this.boxAccInf.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAccInf.Location = new System.Drawing.Point(363, 519);
            this.boxAccInf.Name = "boxAccInf";
            this.boxAccInf.Size = new System.Drawing.Size(933, 414);
            this.boxAccInf.TabIndex = 3;
            this.boxAccInf.TabStop = false;
            this.boxAccInf.Text = "Account Information";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(263, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(148, 123);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(211, 44);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(149, 186);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(208, 44);
            this.lblLname.TabIndex = 2;
            this.lblLname.Text = "Last Name";
            this.lblLname.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(239, 249);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(118, 44);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtTitle
            // 
            this.txtTitle.FormattingEnabled = true;
            this.txtTitle.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs."});
            this.txtTitle.Location = new System.Drawing.Point(364, 56);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(152, 52);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(364, 120);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(520, 50);
            this.txtFname.TabIndex = 5;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(364, 183);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(520, 50);
            this.txtSname.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(364, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(520, 50);
            this.txtEmail.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(157, 59);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(200, 44);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Username";
            this.lblUser.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(161, 125);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(196, 44);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Password";
            // 
            // lblConPass
            // 
            this.lblConPass.AutoSize = true;
            this.lblConPass.Location = new System.Drawing.Point(9, 188);
            this.lblConPass.Name = "lblConPass";
            this.lblConPass.Size = new System.Drawing.Size(348, 44);
            this.lblConPass.TabIndex = 12;
            this.lblConPass.Text = "Confirm Password";
            this.lblConPass.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblUserGr
            // 
            this.lblUserGr.AutoSize = true;
            this.lblUserGr.Location = new System.Drawing.Point(133, 258);
            this.lblUserGr.Name = "lblUserGr";
            this.lblUserGr.Size = new System.Drawing.Size(224, 44);
            this.lblUserGr.TabIndex = 13;
            this.lblUserGr.Text = "User Group";
            this.lblUserGr.Click += new System.EventHandler(this.label9_Click);
            // 
            // radInstruc
            // 
            this.radInstruc.AutoSize = true;
            this.radInstruc.Location = new System.Drawing.Point(364, 254);
            this.radInstruc.Name = "radInstruc";
            this.radInstruc.Size = new System.Drawing.Size(222, 48);
            this.radInstruc.TabIndex = 14;
            this.radInstruc.TabStop = true;
            this.radInstruc.Text = "Instructor";
            this.radInstruc.UseVisualStyleBackColor = true;
            // 
            // radTA
            // 
            this.radTA.AutoSize = true;
            this.radTA.Location = new System.Drawing.Point(592, 254);
            this.radTA.Name = "radTA";
            this.radTA.Size = new System.Drawing.Size(97, 48);
            this.radTA.TabIndex = 15;
            this.radTA.TabStop = true;
            this.radTA.Text = "TA";
            this.radTA.UseVisualStyleBackColor = true;
            // 
            // radStu
            // 
            this.radStu.AutoSize = true;
            this.radStu.Location = new System.Drawing.Point(695, 254);
            this.radStu.Name = "radStu";
            this.radStu.Size = new System.Drawing.Size(189, 48);
            this.radStu.TabIndex = 16;
            this.radStu.TabStop = true;
            this.radStu.Text = "Student";
            this.radStu.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(364, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(173, 62);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1284, 153);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnGrAd
            // 
            this.btnGrAd.Location = new System.Drawing.Point(6, 242);
            this.btnGrAd.Name = "btnGrAd";
            this.btnGrAd.Size = new System.Drawing.Size(333, 101);
            this.btnGrAd.TabIndex = 3;
            this.btnGrAd.Text = "User Group\r\nAdd-in";
            this.btnGrAd.UseVisualStyleBackColor = true;
            this.btnGrAd.Click += new System.EventHandler(this.btnGrAd_Click);
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(364, 188);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(520, 50);
            this.txtConPass.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(364, 125);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(520, 50);
            this.txtPass.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(364, 62);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(520, 50);
            this.txtUser.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 945);
            this.Controls.Add(this.boxAccInf);
            this.Controls.Add(this.boxUserInf);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.boxFnavi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "User Add-in";
            this.boxFnavi.ResumeLayout(false);
            this.boxUserInf.ResumeLayout(false);
            this.boxUserInf.PerformLayout();
            this.boxAccInf.ResumeLayout(false);
            this.boxAccInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxFnavi;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Button btnGr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.GroupBox boxUserInf;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox boxAccInf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.ComboBox txtTitle;
        private System.Windows.Forms.Label lblUserGr;
        private System.Windows.Forms.Label lblConPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.RadioButton radStu;
        private System.Windows.Forms.RadioButton radTA;
        private System.Windows.Forms.RadioButton radInstruc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGrAd;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
    }
}

