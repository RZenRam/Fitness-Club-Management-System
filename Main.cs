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
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
          /*  try
            {
                Database db = new Database();
                db.open();
               // string str = "create table fees(ID AutoNumber,mid Number,name Text,plantype Text,dateoftransaction Text,amount Text,primary key(ID),foreign key(mid) references member(ID))";
// string str = "create table fees(ID AutoNumber,mid Number,name Text,plantype Text,dateoftransaction Text,amount Text,primary key(ID),foreign key(mid) references member(ID))";

                string str = "create table temp(id Number,name Text)";
                db.execute(str);
                MessageBox.Show("Creating ....");
                db.close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message + "");
            }
            this.Dispose();*/
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            notifyIcon1.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void quiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            notifyIcon1.Visible = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add member to data base

            addpladfn add = new addpladfn();
            add.MdiParent = this;
            add.Visible = true;
            add.Show();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editmember add= new  editmember();
            add.MdiParent = this;
            add.Visible = true;
            add.Show();

        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editmember add = new editmember("only");           
            add.MdiParent = this;
            add.Visible = true;          
            add.Show();            
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addplan add = new addplan();
            add.MdiParent = this;
            add.Visible = true;
            add.Show(); 
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editplan add = new editplan();
            add.MdiParent = this;
            add.Visible = true;
            add.Show(); 
        }

        private void viewAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            editplan add = new editplan("only");
            add.MdiParent = this;
            add.Visible = true;
            add.Show(); 
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addinstructor add = new  addinstructor();
            add.MdiParent = this;
            add.Visible = true;
            add.Show(); 
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            editinstructor add = new  editinstructor();
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void viewAllToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            editinstructor add = new editinstructor("only");
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            addequipment add = new  addequipment();
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            editequipment add = new editequipment();
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editequipment add = new editequipment("only");
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History add = new History();
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Content add = new Content();
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus add = new aboutus();
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void instructorPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void memberShipFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fees add = new fees(this);
            add.MdiParent = this;
            add.Visible = true;
            add.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.01;
            if (this.Opacity >= 0.98)
            {
                timer1.Enabled = false;
            }
        }
    }
}
