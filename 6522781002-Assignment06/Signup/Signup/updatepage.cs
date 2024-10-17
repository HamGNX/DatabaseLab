﻿using System;
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
            infoDAO infoDAO = new infoDAO();
            string dateValue = birthDatePick.Value.ToString("yyyy-MM-dd");
            info a1 = new info()
            {
                ID = V,
                fName = fname.Text,
                LName = lname.Text,
                Sex = sxCombo.Text,
                Bdate = dateValue,
                Email = email.Text,
                Occup = occupation.Text
            };
            int result = infoDAO.updateOneRecord(a1);
            userpage newuserpage = new userpage(infoDAO.getAll());
            newuserpage.ShowDialog();
            this.Hide();


        }
    }
}