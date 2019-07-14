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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilityDataSet9.history_fees' table. You can move, or remove it, as needed.
            this.history_feesTableAdapter.Fill(this.utilityDataSet9.history_fees);
            // TODO: This line of code loads data into the 'utilityDataSet8.history_equipment' table. You can move, or remove it, as needed.
            this.history_equipmentTableAdapter.Fill(this.utilityDataSet8.history_equipment);
            // TODO: This line of code loads data into the 'utilityDataSet7.history_instructor' table. You can move, or remove it, as needed.
            this.history_instructorTableAdapter.Fill(this.utilityDataSet7.history_instructor);
            // TODO: This line of code loads data into the 'utilityDataSet6.history_member' table. You can move, or remove it, as needed.
            this.history_memberTableAdapter.Fill(this.utilityDataSet6.history_member);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // delete the selected records from
            // "history_member" table

            // code is here
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // delete the selected records from
            // "history_instructor" table

            // code is here
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {

            // delete the selected records from
            // "history_equipment" table

            // code is here
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            // delete the selected records from
            // "history_fees" table

            // code is here
        }       
    }
}
