using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;

namespace GroceryStore.code
{
    class BusinessLogic
    {
        string con = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        OleDbConnection cn;
        OleDbCommand cmd;

        //connection open method
        void openConnection() 
        {
            cn = new OleDbConnection(con);
            cn.Open();
        }

        //close connection method
        void closeConnection() 
        { 
            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        
        }


        //get record from database
        public OleDbDataReader SelectQuery(String query)
        {
            openConnection();
            cmd = new OleDbCommand(query, cn);
            return cmd.ExecuteReader();
        }

        //Insert , update, delete method
        public int NonQuery (String query)
        {
            openConnection();
            cmd = new OleDbCommand(query, cn);
            int temp = cmd.ExecuteNonQuery();
            closeConnection();
            return temp;
        }


        //bind combobox
        public void FillComboBox(ComboBox cb, String query)
        {
             openConnection();
            OleDbDataReader rec = SelectQuery(query);
            while (rec.Read())
            {
                cb.Items.Add(rec[0].ToString());
            }

        }

        //Bind Gridview

        public void filldataGrid(DataGridView dg, String query) 
        {
            openConnection();
            cmd = new OleDbCommand(query, cn);
            OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dg.DataSource = ds.Tables[0];
        }
    }

   
}
