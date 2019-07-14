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
    public partial class editmember : Form
    {
        Database db;
        int n = 0, i = 0, j = 1;

        public editmember()
        {
            InitializeComponent();
        }

        public editmember(string str)
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            bindingNavigator1.Visible = false;
            groupBox1.Text = "View All Data";
        }

        private void editmember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'utilityDataSet3.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.utilityDataSet1.member);
            // TODO: This line of code loads data into the 'utilityDataSet1.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.utilityDataSet1.member);
            db = new Database();
            db.open();
            db.oda = new System.Data.OleDb.OleDbDataAdapter("select * from member",db.str);
            db.oda.Fill(db.ds, "install");
            db.dt = db.ds.Tables["install"];//         db.close();  
            n = db.dt.Rows.Count;
          //  navigation();
        }

        void clearall()
        {
/*
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();       */
        }

        /*void navigation()
        {
            if (i >= 0 && i < n)
            {                
                clearall();
                DataRow dr = db.dt.Rows[i];
                if (dr!=null)
                {
                    label5.Text = "" + i++;
                    textBox1.Text = dr[0].ToString();
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                }
                                
                dr = db.dt.Rows[i];
                if (dr != null)
                {
                    label6.Text = "" + i++;
                    textBox4.Text = dr[0].ToString();
                    textBox5.Text = dr[1].ToString();
                    textBox6.Text = dr[2].ToString();
                }
                                
                dr = db.dt.Rows[i];
                if (dr != null)
                {
                    label7.Text = "" + i++;
                    textBox7.Text = dr[0].ToString();
                    textBox8.Text = dr[1].ToString();
                    textBox9.Text = dr[2].ToString();
                }
                               
                dr = db.dt.Rows[i];
                if (dr != null)
                {
                    label8.Text = "" + i++;
                    textBox10.Text = dr[0].ToString();
                    textBox11.Text = dr[1].ToString();
                    textBox12.Text = dr[2].ToString();
                }            
            }        
        }*/

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

                               
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //write code for delete
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            i = 0;         
         //   navigation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i -= 8;
            if (i <= 0)
            {
                i = 0;
            }
          //  navigation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = n - 4;            
            navigation();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }*/
    }
}
