using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroceryStore
{
    public partial class AddProduct : Form
    {
        code.Query_DB qdb = new code.Query_DB();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            
            if(PName.Text != string.Empty && PPrice.Text != string.Empty && PQuantity.Text != string.Empty && cbxCategory.Text != string.Empty )
            {
               

                if (qdb.AddProduct(cbxCategory.Text.ToString(),PName.Text, Convert.ToInt32(PPrice.Text), Convert.ToInt32(PQuantity.Text)))
                {
                    PName.Text = "";
                    PPrice.Text = "";
                    PQuantity.Text = "";
                    
                    MessageBox.Show("Product add Successfully");
                } 
                else
                {
                    MessageBox.Show("Something Gone Wrong");
                    PName.Text = "";
                    PPrice.Text = "";
                    PQuantity.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Invalid data");
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PName.Text = "";
            PPrice.Text = "";
            PQuantity.Text = "";
            cbxCategory.Text = "Select Product Category";
            lbxDepart.ClearSelected();
            PName.Focus();
        }

       

        private void AddProduct_Load(object sender, EventArgs e)
        {
            qdb.GetDepartment(lbxDepart);
            
        }

        private void lbxDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCategory.Items.Clear();
            cbxCategory.Text = "Select Product Category";
            if (lbxDepart.Text != string.Empty)
            {
               // qdb.GetDepartID(lbxDepart.Text);
              //  label4.Text = qdb.GetDepartID(lbxDepart.Text).ToString();
                qdb.GetCategory(cbxCategory, qdb.GetDepartID(lbxDepart.Text));
            }

          

        }

      
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        
    }
}
