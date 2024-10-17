using System;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Signup
{
    public partial class signup : Form
    {


        public signup()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            List<info> info_try = new List<info>();
            // Create string to handle date from form
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


            // Create a info object to handle datas gained from form
            

            //Create infoDAO object


            // Call addOneRecord function. Remember it return a integer to show number of record added 


            // Show int message in a MessageBox

            // Hide it
            this.Hide();

            //Create object for newuserpage

            // Show dialog

        }
    }
}