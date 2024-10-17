using MySqlX.XDevAPI.Common;
using System;
using System.Security.Cryptography.X509Certificates;
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
            // Create string to handle date from form
            infoDAO infoDAO = new infoDAO();
            string dateValue = birthDatePick.Value.ToString("yyyy-MM-dd");
                if (!string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(Password.Text) && string.IsNullOrWhiteSpace(Signup_Username.Text) && string.IsNullOrWhiteSpace(Signup_password.Text)
                    && string.IsNullOrWhiteSpace(Signup_Confirm_Password.Text))
                {
                info userInfo = infoDAO.GetUser(Username.Text, Password.Text);
                if (userInfo != null)
                {
                    // If user info is found, show the user page
                    userpage newuserpage = new userpage(infoDAO.getAll());
                    newuserpage.ShowDialog();
                    this.Hide();
                }
                else
                {
                    // Show error if credentials are incorrect
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                }
                else if (!string.IsNullOrWhiteSpace(Signup_Username.Text) && !string.IsNullOrWhiteSpace(Signup_password.Text)
                && !string.IsNullOrWhiteSpace(Signup_Confirm_Password.Text) && string.IsNullOrWhiteSpace(Username.Text) && string.IsNullOrWhiteSpace(Password.Text))
                {
                    info a1 = new info()
                        {
                        ID = 1,
                        fName = fname.Text,
                        LName = lname.Text,
                        Sex = sxCombo.Text,
                        Bdate = dateValue,
                        Email = email.Text,
                        Occup = occupation.Text,
                        User_ID = 1,
                        Signup_ID = 1,
                        Signup_Username = Signup_Username.Text,
                        Signup_Password = Signup_password.Text,
                        Signup_confirm_password = Signup_Confirm_Password.Text
                    };
                    string password = this.Signup_password.Text.Trim();
                    string confirmPassword = this.Signup_Confirm_Password.Text.Trim();
                    if (password == confirmPassword)
                    {
                        if (!string.IsNullOrWhiteSpace(fname.Text) && !string.IsNullOrWhiteSpace(lname.Text) && !string.IsNullOrWhiteSpace(sxCombo.Text) 
                            && !string.IsNullOrWhiteSpace(birthDatePick.Text) && !string.IsNullOrWhiteSpace(email.Text) && !string.IsNullOrWhiteSpace(occupation.Text))
                        {
                            int result = infoDAO.addOneRecord(a1);
                            MessageBox.Show(result + " new row(s) added to information collector.”,");
                            userpage newuserpage = new userpage(infoDAO.getAll());
                            newuserpage.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please fill all the fields in personal information", "Data not filled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your passwords do not match", "Passwords do not match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (string.IsNullOrWhiteSpace(fname.Text) && string.IsNullOrWhiteSpace(lname.Text) && string.IsNullOrWhiteSpace(sxCombo.Text) && string.IsNullOrWhiteSpace(birthDatePick.Text) && string.IsNullOrWhiteSpace(email.Text) && string.IsNullOrWhiteSpace(occupation.Text) || string.IsNullOrWhiteSpace(Signup_Username.Text) && string.IsNullOrWhiteSpace(Signup_password.Text) && string.IsNullOrWhiteSpace(Signup_Confirm_Password.Text))
                {
                    MessageBox.Show("Please fill all the fields in signup and/or Please fill all the fields in personal information", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!string.IsNullOrWhiteSpace(fname.Text) && !string.IsNullOrWhiteSpace(lname.Text) && !string.IsNullOrWhiteSpace(sxCombo.Text) && !string.IsNullOrWhiteSpace(birthDatePick.Text) && !string.IsNullOrWhiteSpace(email.Text) && !string.IsNullOrWhiteSpace(occupation.Text) && string.IsNullOrWhiteSpace(Signup_Username.Text) && string.IsNullOrWhiteSpace(Signup_password.Text) && string.IsNullOrWhiteSpace(Signup_Confirm_Password.Text))
                {
                    MessageBox.Show("Please fill all the fields in signup", "Cannot Sign up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please fill all the fieds in either login or signup section", "Login/Signup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}