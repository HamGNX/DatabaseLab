using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{

    public partial class Form3 : Form
    {
        BindingSource studentBindingSource = new BindingSource();
        public object V { get; }
        
        public Form3(object v)
        {
            InitializeComponent();

            V = v;

        }
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = V;
            dataGridView1.DataSource = studentBindingSource;
        }
    }
}
