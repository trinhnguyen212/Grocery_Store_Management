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
    class Query_DB
    {
        BusinessLogic bl = new BusinessLogic();
        
        public int ID
        { 
            get;
            set; 
        }

        public String EMAIL 
        { 
            get; 
            set; 
        }
        public String PASSWORD
        {
            get; 
            set;
        }
        public int TYPE
        {
            get;
            set;
        }

        //For Login
        public bool VerifyUser(Query_DB qdb)
        {
            bool temp = false;
            string query = string.Format("select count(*) from Admin where Email='{0}' and Password = '{1}'", qdb.EMAIL, qdb.PASSWORD);
            OleDbDataReader rec = bl.SelectQuery(query);
            while(rec.Read())
            {
                if (rec[0].ToString().Equals("1"))
                {
                    temp = true;
                }
            }
            return temp;
        }
    }
}
