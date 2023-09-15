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
    public partial class UpdateProduct : Form
    {
        code.Query_DB qdb = new code.Query_DB();
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            qdb.GetProduct(dataGridView1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(PName.Text !=string.Empty && lblPID.Text!=string.Empty && PPrice.Text!=string.Empty && PQuantity.Text!=string.Empty)
            {
                if (qdb.UpdateProduct(PName.Text, PPrice.Text, PQuantity.Text, Convert.ToInt32(lblPID.Text)))
                {
                    MessageBox.Show("Update Successfully");
                    qdb.GetProduct(dataGridView1);
                    PName.Text = "";
                    lblPID.Text = "";
                    PPrice.Text = "";
                    PQuantity.Text = "";
                    Search.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                    PName.Text = "";
                    lblPID.Text = "";
                    PPrice.Text = "";
                    PQuantity.Text = "";
                    Search.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show("Invalid data entry");
                PName.Text = "";
                lblPID.Text = "";
                PPrice.Text = "";
                PQuantity.Text = "";
                Search.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPID.Text = dataGridView1.SelectedCells[3].Value.ToString();
            PPrice.Text = dataGridView1.SelectedCells[1].Value.ToString();
            PName.Text = dataGridView1.SelectedCells[0].Value.ToString();
            PQuantity.Text = dataGridView1.SelectedCells[2].Value.ToString();
       
           
           

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            qdb.GetProductBySearch(dataGridView1, Search.Text);
        }
    }
}
