﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Signup
{

    public partial class userpage : Form
    {
        public int rowClicked;
        public int id_row;
        BindingSource infobindingSource = new BindingSource();

        // Create a list of info object
        private List<info> result;

        public userpage()
        {
            InitializeComponent();
        }
        public userpage(object v)
        {
            InitializeComponent();
            V = v;
        }
        public object V { get; set; }
        private void userpage_Load(object sender, EventArgs e)
        {
            infobindingSource.DataSource = V;
            userdataGridView.DataSource = infobindingSource;
        }

        private void userdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dataGridView = (DataGridView)sender;
            rowClicked = dataGridView.CurrentRow.Index;
            id_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[0].Value.ToString());


        }

        private void update_Click(object sender, EventArgs e)
        {
            //Create inforDAO object

            //Hide it

            //create updatepage object with proper argument

            //Show dialog
            infoDAO infor = new infoDAO();
            this.Hide();
            updatepage newupdatepage = new updatepage(id_row);
            newupdatepage.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //Create infoDAO object

            // Call deleteOneRecord function and handle it properly

            // Hide it

            //Create userpage object and take all info as argument

            //show dialog
            infoDAO infoDAO = new infoDAO();
            int result = infor.deleteOneRecord(id_row);
            this.Hide();
            userpage newuserpage = new userpage(infor.getAll());
            newuserpage.ShowDialog();
        }
    }
}
