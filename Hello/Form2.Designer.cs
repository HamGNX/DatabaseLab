namespace Hello
{
    partial class Form2
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbSchool = new System.Windows.Forms.ComboBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.conInfGroup = new System.Windows.Forms.GroupBox();
            this.checkDatabasemn = new System.Windows.Forms.CheckBox();
            this.chcIndus = new System.Windows.Forms.CheckBox();
            this.chcAi = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblLevel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.infoBox.SuspendLayout();
            this.conInfGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 53);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(148, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Student Name";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 117);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(112, 25);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Student ID";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.lblLevel);
            this.infoBox.Controls.Add(this.radioButton2);
            this.infoBox.Controls.Add(this.radioButton1);
            this.infoBox.Controls.Add(this.listBox1);
            this.infoBox.Controls.Add(this.lblLocation);
            this.infoBox.Controls.Add(this.lblSchool);
            this.infoBox.Controls.Add(this.cmbSchool);
            this.infoBox.Controls.Add(this.txtId);
            this.infoBox.Controls.Add(this.txtName);
            this.infoBox.Controls.Add(this.NameLabel);
            this.infoBox.Controls.Add(this.IdLabel);
            this.infoBox.Location = new System.Drawing.Point(127, 41);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(471, 411);
            this.infoBox.TabIndex = 2;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Student Information";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 31);
            this.txtName.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 114);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 31);
            this.txtId.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(504, 780);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 40);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbSchool
            // 
            this.cmbSchool.FormattingEnabled = true;
            this.cmbSchool.Items.AddRange(new object[] {
            "BCET",
            "CET",
            "ICT",
            "MSME",
            "MT"});
            this.cmbSchool.Location = new System.Drawing.Point(172, 181);
            this.cmbSchool.Name = "cmbSchool";
            this.cmbSchool.Size = new System.Drawing.Size(200, 33);
            this.cmbSchool.TabIndex = 5;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(6, 184);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(78, 25);
            this.lblSchool.TabIndex = 6;
            this.lblSchool.Text = "School";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(6, 281);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(94, 25);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location";
            // 
            // conInfGroup
            // 
            this.conInfGroup.Controls.Add(this.dateTimePicker1);
            this.conInfGroup.Controls.Add(this.chcAi);
            this.conInfGroup.Controls.Add(this.chcIndus);
            this.conInfGroup.Controls.Add(this.checkDatabasemn);
            this.conInfGroup.Location = new System.Drawing.Point(127, 482);
            this.conInfGroup.Name = "conInfGroup";
            this.conInfGroup.Size = new System.Drawing.Size(471, 274);
            this.conInfGroup.TabIndex = 6;
            this.conInfGroup.TabStop = false;
            this.conInfGroup.Text = "Conference Information";
            // 
            // checkDatabasemn
            // 
            this.checkDatabasemn.AutoSize = true;
            this.checkDatabasemn.Location = new System.Drawing.Point(38, 47);
            this.checkDatabasemn.Name = "checkDatabasemn";
            this.checkDatabasemn.Size = new System.Drawing.Size(267, 29);
            this.checkDatabasemn.TabIndex = 0;
            this.checkDatabasemn.Text = "Database Management";
            this.checkDatabasemn.UseVisualStyleBackColor = true;
            // 
            // chcIndus
            // 
            this.chcIndus.AutoSize = true;
            this.chcIndus.Location = new System.Drawing.Point(38, 92);
            this.chcIndus.Name = "chcIndus";
            this.chcIndus.Size = new System.Drawing.Size(167, 29);
            this.chcIndus.TabIndex = 1;
            this.chcIndus.Text = "Industrial 4.0";
            this.chcIndus.UseVisualStyleBackColor = true;
            // 
            // chcAi
            // 
            this.chcAi.AutoSize = true;
            this.chcAi.Location = new System.Drawing.Point(38, 138);
            this.chcAi.Name = "chcAi";
            this.chcAi.Size = new System.Drawing.Size(235, 29);
            this.chcAi.TabIndex = 2;
            this.chcAi.Text = "Artificial Intelligence";
            this.chcAi.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Rangsit",
            "Bangkadi",
            "Other"});
            this.listBox1.Location = new System.Drawing.Point(172, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 79);
            this.listBox1.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(172, 365);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 29);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BSc";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(286, 365);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 29);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "MSc";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(6, 365);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(64, 25);
            this.lblLevel.TabIndex = 12;
            this.lblLevel.Text = "Level";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 31);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 853);
            this.Controls.Add(this.conInfGroup);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.infoBox);
            this.Name = "Form2";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.conInfGroup.ResumeLayout(false);
            this.conInfGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbSchool;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.GroupBox conInfGroup;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chcAi;
        private System.Windows.Forms.CheckBox chcIndus;
        private System.Windows.Forms.CheckBox checkDatabasemn;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}