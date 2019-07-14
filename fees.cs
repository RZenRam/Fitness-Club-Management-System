using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_club
{
    public partial class fees : Form
    {
        Main parent;
        public fees()
        {
            InitializeComponent();
        }

        public fees(Main ref_parent)
        {
            parent = ref_parent;
            InitializeComponent();
        }
        private void fees_Load(object sender, EventArgs e)
        {
           // in this form load
           // first obtained first name + last name
           // put them in to combobox1
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //according to selected combobox1 set the values for combobox2
            // that is the plan type accepted by member (First name + Last Name)

             

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add this data to database
            // in the fees table 
            // also add data in the history_fees table




            // code is here

            // report page
            bill_for_fees add = new bill_for_fees();
            add.Visible = true;
            add.MdiParent = parent;
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        
    }
}
