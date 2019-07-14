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
    public partial class editequipment : Form
    {
        public editequipment()
        {
            InitializeComponent();
        }

        public editequipment(string str)
        {
            InitializeComponent();
            groupBox1.Text = "View All";
            bindingNavigator1.Visible = false;
            dataGridView1.ReadOnly = true;
        }

        private void editequipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilityDataSet5.equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.utilityDataSet5.equipment);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // update data to "equipment" table
            // code is here
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // delete selected row from "equipment" table
            // code is here

        }
    }
}
