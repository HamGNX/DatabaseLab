namespace Lab2Hw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLab = new System.Windows.Forms.Label();
            this.btnGrAd = new System.Windows.Forms.Button();
            this.btnGr = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.boxFnavi = new System.Windows.Forms.GroupBox();
            this.backBox = new System.Windows.Forms.PictureBox();
            this.profBox = new System.Windows.Forms.PictureBox();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richtxtDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.boxFnavi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1301, 153);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLab.Font = new System.Drawing.Font("Arial Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab.Location = new System.Drawing.Point(19, 52);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(822, 74);
            this.lblLab.TabIndex = 6;
            this.lblLab.Text = "CSS326 Laboratory System";
            this.lblLab.Click += new System.EventHandler(this.lblLab_Click);
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
            // btnGr
            // 
            this.btnGr.Location = new System.Drawing.Point(6, 179);
            this.btnGr.Name = "btnGr";
            this.btnGr.Size = new System.Drawing.Size(333, 57);
            this.btnGr.TabIndex = 2;
            this.btnGr.Text = "User Group";
            this.btnGr.UseVisualStyleBackColor = true;
            this.btnGr.Click += new System.EventHandler(this.btnGr_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(333, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "User Add-in";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnProf
            // 
            this.btnProf.Location = new System.Drawing.Point(6, 53);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(333, 57);
            this.btnProf.TabIndex = 0;
            this.btnProf.Text = "User Profile";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
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
            this.boxFnavi.Size = new System.Drawing.Size(362, 762);
            this.boxFnavi.TabIndex = 5;
            this.boxFnavi.TabStop = false;
            this.boxFnavi.Text = "Form Navigation";
            // 
            // backBox
            // 
            this.backBox.Image = ((System.Drawing.Image)(resources.GetObject("backBox.Image")));
            this.backBox.Location = new System.Drawing.Point(380, 171);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(933, 762);
            this.backBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backBox.TabIndex = 10;
            this.backBox.TabStop = false;
            this.backBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // profBox
            // 
            this.profBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profBox.Image = ((System.Drawing.Image)(resources.GetObject("profBox.Image")));
            this.profBox.Location = new System.Drawing.Point(1066, 679);
            this.profBox.Name = "profBox";
            this.profBox.Size = new System.Drawing.Size(201, 200);
            this.profBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profBox.TabIndex = 11;
            this.profBox.TabStop = false;
            this.profBox.Click += new System.EventHandler(this.profBox_Click);
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.BackColor = System.Drawing.Color.IndianRed;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.Location = new System.Drawing.Point(426, 224);
            this.lblNameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(83, 48);
            this.lblNameUser.TabIndex = 12;
            this.lblNameUser.Text = "Hi!!";
            this.lblNameUser.Click += new System.EventHandler(this.lblNameUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.richtxtDescription);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(422, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(853, 142);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // richtxtDescription
            // 
            this.richtxtDescription.BackColor = System.Drawing.Color.Silver;
            this.richtxtDescription.Enabled = false;
            this.richtxtDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtDescription.Location = new System.Drawing.Point(12, 34);
            this.richtxtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richtxtDescription.Multiline = false;
            this.richtxtDescription.Name = "richtxtDescription";
            this.richtxtDescription.ReadOnly = true;
            this.richtxtDescription.Size = new System.Drawing.Size(814, 42);
            this.richtxtDescription.TabIndex = 1;
            this.richtxtDescription.Text = " We are glad to welcome you as one of the .";
            this.richtxtDescription.TextChanged += new System.EventHandler(this.richtxtDescription_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 944);
            this.Controls.Add(this.profBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.boxFnavi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.boxFnavi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Button btnGrAd;
        private System.Windows.Forms.Button btnGr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.GroupBox boxFnavi;
        private System.Windows.Forms.PictureBox backBox;
        private System.Windows.Forms.PictureBox profBox;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richtxtDescription;
    }
}