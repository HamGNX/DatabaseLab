using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Hw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnProf_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 UserAdd_in = new Form1();
            UserAdd_in.Show();
            this.Hide();
            UserAdd_in.FormClosed += (s, args) => Application.Exit();
        }

        private void btnGr_Click(object sender, EventArgs e)
        {

        }

        private void btnGrAd_Click(object sender, EventArgs e)
        {

        }

        private void profBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblLab_Click(object sender, EventArgs e)
        {

        }

        private void lblNameUser_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           richtxtDescription.BackColor = Color.IndianRed;
        }

        private void richtxtDescription_TextChanged(object sender, EventArgs e)
        {

        }
        public void UpdateLabel(string text)
        {
           lblNameUser.Text = text;
        }

        public void UpdateStat(string text)
        {
           richtxtDescription.Text = text;
        }


    }
}
