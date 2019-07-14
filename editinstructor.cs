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
    public partial class editinstructor : Form
    {
        public editinstructor()
        {
            InitializeComponent();
        }

        public editinstructor(string str)
        {
            InitializeComponent();

            groupBox1.Text = "Delete Information";
            bindingNavigator1.Visible = false;
            dataGridView1.ReadOnly = true;            
        }

        private void editinstructor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilityDataSet4.instructor' table. You can move, or remove it, as needed.
            this.instructorTableAdapter.Fill(this.utilityDataSet4.instructor);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // update the value which are edit
            // in the "instructor" table


            // code is here
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            // delete the row which are edit
            // in the "instructor" table


            // code is here

        }
    }
}
