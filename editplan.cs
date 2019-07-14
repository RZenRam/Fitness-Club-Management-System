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
    public partial class editplan : Form
    {
        public editplan()
        {
            InitializeComponent();
        }

        public editplan(string str)
        {
            InitializeComponent();
            groupBox1.Text = "View All";
            bindingNavigator1.Visible = false;
            dataGridView1.ReadOnly = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // write code for update
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // write code for delete
        }

        private void editplan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilityDataSet2.plan' table. You can move, or remove it, as needed.
            this.planTableAdapter.Fill(this.utilityDataSet2.plan);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
