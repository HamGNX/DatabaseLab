using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrAd_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProf_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ComboBox txtTitle = this.txtTitle;
            TextBox txtFname = this.txtFname;
            TextBox txtLname = this.txtLname;
            TextBox txtEmail = this.txtEmail;
            TextBox txtUser = this.txtUser;
            TextBox txtPass = this.txtPass;
            TextBox txtConPass = this.txtConPass;
            RadioButton radInstruc = this.radInstruc;
            RadioButton radStu = this.radStu;
            RadioButton radTA = this.radTA;

            if (txtTitle.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtFname.Text) ||
                string.IsNullOrWhiteSpace(txtLname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) ||
                string.IsNullOrWhiteSpace(txtConPass.Text))
            {
                MessageBox.Show("Please fill all the fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (!radInstruc.Checked && !radTA.Checked && !radStu.Checked)
            {
                MessageBox.Show("Please select at least one User Group", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPass.Text != txtConPass.Text)
            {
                MessageBox.Show("Password and Confirm Password must be the same", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRole = "";
            if (radInstruc.Checked)
            {
                selectedRole = radInstruc.Text;
            }
            else if (radTA.Checked)
            {
                selectedRole = radTA.Text;
            }
            else if (radStu.Checked)
            {
                selectedRole = radStu.Text;
            }

            Form2 userProfileForm = new Form2();
            string welcomemassage = $"Hi!! {txtFname.Text} {txtLname.Text}";
            userProfileForm.UpdateLabel(welcomemassage);

            string stat = $"We are glad to welcome you as one of the {selectedRole}.";
            userProfileForm.UpdateStat(stat);

            userProfileForm.Show();
            this.Hide();
            userProfileForm.FormClosed += (s, args) => Application.Exit();
        }
    }
}