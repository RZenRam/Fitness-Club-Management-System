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
    public partial class addequipment : Form
    {
        public addequipment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add all data to "equipment" table
            // as well as in history_equipment


        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            try
            {
                int tot_quantity = Convert.ToInt32(textBox3.Text);
                int price_per_quantity = Convert.ToInt32(textBox4.Text);
                textBox5.Text = (tot_quantity * price_per_quantity) + "";
            }
            catch(Exception ee)
            {
                MessageBox.Show("Enter the data properly");
            }
        }
    }
}
