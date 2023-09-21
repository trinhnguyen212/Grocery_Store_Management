using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;

namespace GroceryStore.code
{
    public class Query_DB
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


        public bool CheckUser(String email)
        {
            bool temp = false;
            string query = string.Format("select count(*) from UserData where UEmail = '{0}'", email);
            OleDbDataReader rec = bl.SelectQuery(query);
            while (rec.Read())
            {
                if (Convert.ToInt32(rec[0].ToString()) >= 1)
                {
                    temp= true;
                }
            }
            return temp;
        }

        public bool CreateUser (String email, String name, String mobile, String address, String gender)
        {
            bool temp = false;
            String query = String.Format("insert into UserData values({0}+1,'{1}','{2}','{3}','{4}','{5}')", GetMaxID("UserData"),email, name, mobile,address, gender);
            if(bl.NonQuery(query) == 1)
            {
                temp= true;
            }
            return temp;
        }

        public int GetMaxID(String tab) 
        {
            String query = String.Format("Select Max(id) From {0}", tab);
            OleDbDataReader rec = bl.SelectQuery(query);
            while (rec.Read())
            {
                if (!rec[0].ToString().Equals(""))
                {
                    return Convert.ToInt32(rec[0].ToString());
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        public bool AddProduct(string cate, String name, int price, int qty,Image image)
        {
            
            String query = String.Format("insert into Product values ({0} + 1,{1},'{2}', {3},{4}, {5})", GetMaxID("Product"), GetCategoryID(cate), name, price, qty, image);
            if (bl.NonQuery(query) == 1) 
            {
                return true;
            }
            return false;
        }

        public void GetProduct(DataGridView dg)
        {
            string query = "select PName,PPrice,Pquantity, ID as pid from Product";
            bl.filldataGrid(dg, query);
        }

        public void GetDepartment(ListBox lb)
        {
            string query = "select * from Department";
            bl.FillListBox(lb, query);
           // lb.ValueMember = "ID";

        }

        

        public void GetCategory(ComboBox cb, int departid)
        {
            string query = string.Format("select Category from Category where Category.DepartmentID = {0}",departid);
            bl.FillComboBox(cb, query);
        }

        public int GetDepartID(string tabname)
        {
            String query = String.Format("Select ID From Department where DepartName='{0}'", tabname);
            OleDbDataReader rec = bl.SelectQuery(query);
            while (rec.Read())
            {
                if (!rec[0].ToString().Equals(""))
                {
                    return Convert.ToInt32(rec[0].ToString());
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        public int GetCategoryID(string tabname)
        {
            String query = String.Format("Select ID From Category where Category='{0}'", tabname);
            OleDbDataReader rec = bl.SelectQuery(query);
            while (rec.Read())
            {
                if (!rec[0].ToString().Equals(""))
                {
                    return Convert.ToInt32(rec[0].ToString());
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        public bool UpdateProduct(String name, String price, String qty, int id)
        {
            string query = string.Format("update Product set [PName]='{0}', [PPrice]={1}, [PQuantity]={2} where ID={3}", name, price, qty, id);

            if (bl.NonQuery(query) == 1) 
            
            {
                return true;
            }

            return false;
        }

        public void GetProductBySearch(DataGridView dg, String se)
        {
            string query = "select PName, PPrice, PQuantity, ID as pid from Product where PName like('%" + se + "%')"; 
            bl.filldataGrid(dg, query);
                
        }


        public void GetSell(DataGridView dg)
        {
            string query = "Select UName,Date,Discount,Total,Sell.ID as Pid, Email as ad from Sell, UserData, Admin where Sell.Uid=UserData.ID AND Admin.ID=Sell.ABy";
            bl.filldataGrid(dg, query);
        }

        public void GetSaleBySearch(DataGridView dg, String se)
        {
            string query = "select UName, Date, Discount, Total, Sell.ID as Pid, Email as ad from Sell, UserData, Admin where Sell.Uid=UserData.ID AND  Admin.ID = Sell.Aby AND  UName like ('%" + se + "%') ";
            bl.filldataGrid(dg, query);
        }

        public Query_DB GetUserDetails(Query_DB cdb)
        {
            string query = string.Format("select ID,Email,Password,Type from Admin where Email='{0}' AND Password='{1}' ", cdb.EMAIL,cdb.PASSWORD);
            OleDbDataReader dr = bl.SelectQuery(query);
            while(dr.Read())
            {
                if (!dr[0].ToString().Equals("") && Convert.ToInt32(dr[0].ToString())>=1)
                {
                    Query_DB utb = new Query_DB();
                    utb.ID = Convert.ToInt32(dr[0].ToString());
                    utb.EMAIL = dr[1].ToString();
                    utb.PASSWORD = dr[2].ToString();
                    utb.TYPE = Convert.ToInt32(dr[3].ToString());
                    return utb;
                }
            }
            return null;
        }

        public void GetUser(DataGridView dg)
        {
            string query = "Select UName, UMobile From UserData";
            bl.filldataGrid(dg, query);
        }

        public void GetProductByNameSearch(DataGridView dg, String se) 
        {
            string query = "select PName, PPrice,Pquantity, ID as pid from Product where PName like ('%" + se + "%')";
            bl.filldataGrid(dg, query); 
        }



    }
}
