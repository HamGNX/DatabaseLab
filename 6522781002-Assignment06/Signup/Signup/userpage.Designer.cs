namespace Signup
{
    partial class userpage
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
            userdataGridView = new DataGridView();
            update = new Button();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)userdataGridView).BeginInit();
            SuspendLayout();
            // 
            // userdataGridView
            // 
            userdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userdataGridView.Location = new Point(12, 12);
            userdataGridView.Name = "userdataGridView";
            userdataGridView.RowHeadersWidth = 51;
            userdataGridView.RowTemplate.Height = 29;
            userdataGridView.Size = new Size(1046, 235);
            userdataGridView.TabIndex = 0;
            userdataGridView.CellClick += userdataGridView_CellClick;
            // 
            // update
            // 
            update.BackColor = SystemColors.ButtonFace;
            update.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(149, 256);
            update.Name = "update";
            update.Size = new Size(153, 42);
            update.TabIndex = 1;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.BackColor = SystemColors.ButtonFace;
            delete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(748, 256);
            delete.Name = "delete";
            delete.Size = new Size(153, 42);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // userpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 310);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(userdataGridView);
            Name = "userpage";
            Text = "User page";
            Load += userpage_Load;
            ((System.ComponentModel.ISupportInitialize)userdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userdataGridView;
        private Button update;
        private Button delete;
    }
}