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
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 25);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(1031, 654);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // occupation
            // 
            occupation.Location = new Point(346, 535);
            occupation.Margin = new Padding(6, 6, 6, 6);
            occupation.Name = "occupation";
            occupation.Size = new Size(620, 60);
            occupation.TabIndex = 11;
            // 
            // email
            // 
            email.Location = new Point(346, 441);
            email.Margin = new Padding(6, 6, 6, 6);
            email.Name = "email";
            email.Size = new Size(620, 60);
            email.TabIndex = 10;
            // 
            // birthDatePick
            // 
            birthDatePick.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthDatePick.Location = new Point(346, 346);
            birthDatePick.Margin = new Padding(6, 6, 6, 6);
            birthDatePick.Name = "birthDatePick";
            birthDatePick.Size = new Size(620, 60);
            birthDatePick.TabIndex = 9;
            // 
            // sxCombo
            // 
            sxCombo.FormattingEnabled = true;
            sxCombo.Items.AddRange(new object[] { "Male", "Female" });
            sxCombo.Location = new Point(346, 254);
            sxCombo.Margin = new Padding(6, 6, 6, 6);
            sxCombo.Name = "sxCombo";
            sxCombo.Size = new Size(620, 61);
            sxCombo.TabIndex = 8;
            // 
            // lname
            // 
            lname.Location = new Point(346, 160);
            lname.Margin = new Padding(6, 6, 6, 6);
            lname.Name = "lname";
            lname.Size = new Size(620, 60);
            lname.TabIndex = 7;
            // 
            // fname
            // 
            fname.Location = new Point(346, 74);
            fname.Margin = new Padding(6, 6, 6, 6);
            fname.Name = "fname";
            fname.Size = new Size(620, 60);
            fname.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 545);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(295, 53);
            label7.TabIndex = 5;
            label7.Text = "Occupation: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(164, 459);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 53);
            label6.TabIndex = 4;
            label6.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 369);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(265, 53);
            label5.TabIndex = 3;
            label5.Text = "Birth Date: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(208, 275);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 53);
            label4.TabIndex = 2;
            label4.Text = "Sex:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 176);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(275, 53);
            label3.TabIndex = 1;
            label3.Text = "Last name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 80);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(277, 53);
            label2.TabIndex = 0;
            label2.Text = "First name: ";
            // 
            // submit
            // 
            submit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submit.Location = new Point(765, 691);
            submit.Margin = new Padding(6, 6, 6, 6);
            submit.Name = "submit";
            submit.Size = new Size(232, 78);
            submit.TabIndex = 3;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // updatepage
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 789);
            Controls.Add(submit);
            Controls.Add(groupBox1);
            Margin = new Padding(6, 6, 6, 6);
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