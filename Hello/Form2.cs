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
    public partial class Form2 : Form
    {
        static List<Student> st = new List<Student>();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //create an object for the fields
            Student a1 = new Student
            {
                Name = this.txtName.Text,
                Student_ID = Convert.ToInt64(this.txtId.Text)
            };
            //add values to the student object
            st.Add(a1);

            Form3 form3 = new Form3(st);

            form3.ShowDialog();
        }
    }
}