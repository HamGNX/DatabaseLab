namespace Signup
{
    partial class updatepage
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
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Font = new Font("Artifakt Element Heavy", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 319);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // occupation
            // 
            occupation.Location = new Point(163, 261);
            occupation.Name = "occupation";
            occupation.Size = new Size(294, 40);
            occupation.TabIndex = 11;
            // 
            // email
            // 
            email.Location = new Point(163, 215);
            email.Name = "email";
            email.Size = new Size(294, 40);
            email.TabIndex = 10;
            // 
            // birthDatePick
            // 
            birthDatePick.CalendarFont = new Font("Artifakt Element", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthDatePick.Location = new Point(163, 169);
            birthDatePick.Name = "birthDatePick";
            birthDatePick.Size = new Size(294, 40);
            birthDatePick.TabIndex = 9;
            // 
            // sxCombo
            // 
            sxCombo.FormattingEnabled = true;
            sxCombo.Items.AddRange(new object[] { "Male", "Female" });
            sxCombo.Location = new Point(163, 124);
            sxCombo.Name = "sxCombo";
            sxCombo.Size = new Size(294, 40);
            sxCombo.TabIndex = 8;
            // 
            // lname
            // 
            lname.Location = new Point(163, 78);
            lname.Name = "lname";
            lname.Size = new Size(294, 40);
            lname.TabIndex = 7;
            // 
            // fname
            // 
            fname.Location = new Point(163, 36);
            fname.Name = "fname";
            fname.Size = new Size(294, 40);
            fname.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Artifakt Element Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 266);
            label7.Name = "label7";
            label7.Size = new Size(149, 32);
            label7.TabIndex = 5;
            label7.Text = "Occupation: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Artifakt Element Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(77, 224);
            label6.Name = "label6";
            label6.Size = new Size(85, 32);
            label6.TabIndex = 4;
            label6.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Artifakt Element Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 180);
            label5.Name = "label5";
            label5.Size = new Size(137, 32);
            label5.TabIndex = 3;
            label5.Text = "Birth Date: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Artifakt Element Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(98, 134);
            label4.Name = "label4";
            label4.Size = new Size(59, 32);
            label4.TabIndex = 2;
            label4.Text = "Sex:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Artifakt Element Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 86);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 1;
            label3.Text = "Last name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Artifakt Element Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 39);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 0;
            label2.Text = "First name: ";
            // 
            // submit
            // 
            submit.Font = new Font("Artifakt Element", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submit.Location = new Point(360, 337);
            submit.Name = "submit";
            submit.Size = new Size(109, 38);
            submit.TabIndex = 3;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // updatepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 385);
            Controls.Add(submit);
            Controls.Add(groupBox1);
            Name = "updatepage";
            Text = "Update page";
            Load += updatepage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox occupation;
        private TextBox email;
        private DateTimePicker birthDatePick;
        private ComboBox sxCombo;
        private TextBox lname;
        private TextBox fname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button submit;
    }
}