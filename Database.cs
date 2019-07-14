using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Fitness_club
{
    public class Database
    {
        public OleDbConnection con;
        public string str = "Data Source=localhost;Initial Catalog=Utility;Integrated Security=True";
        public OleDbDataAdapter oda;
        public DataSet ds;
        public DataTable dt;
        
        public Database()
        {
            con = new OleDbConnection();
            con.ConnectionString = str;
            ds = new DataSet();
            dt = new DataTable();
        }
        public void open()
        {
            con.Open();
        }

        public void execute(string com)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;           
            cmd.CommandText = com;          
            cmd.ExecuteNonQuery();          
        }

        public void close()
        {
            con.Close();
        }

        
    }
}
