using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup
{
    public partial class updatepage : Form
    {
        public updatepage()
        {
            InitializeComponent();
        }
        public updatepage(int v)
        {
            InitializeComponent();
            V = v;
        }
        public int V { get; set; }
        private void updatepage_Load(object sender, EventArgs e)
        {


        }

        private void submit_Click(object sender, EventArgs e)
        {
            string dateValue = birthDatePick.Value.ToString("yyyy-MM-dd");
            info a1 = new info()
            {
                ID = 1,
                fName = fname.Text,
                LName = lname.Text,
                Sex = sxCombo.Text,
                Bdate = dateValue,
                Email = email.Text,
                Occup = occupation.Text,
            };

            infoDAO infor = new infoDAO();
            int result = infor.addOneRecord(a1);
            MessageBox.Show(result + " new row(s) added.");
            this.Hide();
            userpage newuserpage = new userpage(infor.getAll());
            newuserpage.ShowDialog();
            // Create string to handle date from form

            // Create a info object to handle datas gained from form


            //Create infoDAO object


            // Call addOneRecord function. Remember it return a integer to show number of record added 


            // Show int message in a MessageBox

            // Hide it

            //Create object for newuserpage

            // Show dialog


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
