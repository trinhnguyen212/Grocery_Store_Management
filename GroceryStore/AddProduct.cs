using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(PName.Text != string.Empty && PPrice.Text != string.Empty && PQuantity.Text != string.Empty)
            {
                if (qdb.AddProduct(PName.Text, Convert.ToInt32(PPrice.Text), Convert.ToInt32(PQuantity.Text)))
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
            PName.Focus();
        }
    }
}
