namespace Hello
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
            this.lblHello = new System.Windows.Forms.Label();
            this.btnClickthis = new System.Windows.Forms.Button();
            this.nextForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(859, 194);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(171, 25);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Click this button.";
            this.lblHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClickthis
            // 
            this.btnClickthis.Location = new System.Drawing.Point(875, 241);
            this.btnClickthis.Name = "btnClickthis";
            this.btnClickthis.Size = new System.Drawing.Size(135, 57);
            this.btnClickthis.TabIndex = 0;
            this.btnClickthis.Text = "Click me";
            this.btnClickthis.UseVisualStyleBackColor = true;
            this.btnClickthis.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextForm
            // 
            this.nextForm.Location = new System.Drawing.Point(132, 749);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(125, 48);
            this.nextForm.TabIndex = 2;
            this.nextForm.Text = "nextForm";
            this.nextForm.UseVisualStyleBackColor = true;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 857);
            this.Controls.Add(this.nextForm);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnClickthis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnClickthis;
        private System.Windows.Forms.Button nextForm;
    }
}

