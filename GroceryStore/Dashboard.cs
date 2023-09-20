using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class Dashboard : Form
    {
        code.Query_DB qdb = new code.Query_DB();
        public Dashboard(code.Query_DB qd)
        {
            InitializeComponent();
            qdb = qd;
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUser cu = new CreateUser();
            cu.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct up = new UpdateProduct();
            up.Show();
        }

        private void viewSellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSell vs = new ViewSell();
            vs.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            qdb.GetProduct(dataGridView1);
            qdb.GetUser(dataGridView2);
           // qdb.GetDepartment(cbx);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedCells[1].Value.ToString();
            label7.Text = dataGridView1.SelectedCells[2].Value.ToString();
            //label7.Text = "Total QtyInStock: " + totqty;
            // txtQty.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtQty.Text = string.Empty;
            txtQty.Focus();
            lblID.Text = dataGridView1.SelectedCells[3].Value.ToString();
            label6.Text = dataGridView1.SelectedCells[3].Value.ToString();
         //   label6.Text = "Product ID: " + spid;
            txtPrice.ReadOnly= true;
           txtProductName.Select();    
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            qdb.GetProductByNameSearch(dataGridView1, txtProductName.Text);
        }

       

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBName.Text = dataGridView2.SelectedCells[0].Value.ToString();
            txtBMobile.Text = dataGridView2.SelectedCells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtQty.Text!=string.Empty && Convert.ToInt32(txtQty.Text)>0)
            {
                label6.Text = (Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text)).ToString();
                string[] row = new string[] {lblID.Text,txtProductName.Text,txtPrice.Text,txtQty.Text,label6.Text };
                if (Convert.ToInt32(txtQty.Text) <= Convert.ToInt32(label7.Text))
                {
                    dataGridView3.Rows.Add(row);
                    txtProductName.Text = string.Empty;
                    txtQty.Text = string.Empty;
                    int a = 0;
                    double total = 0;

                    foreach (DataGridViewRow pb in dataGridView3.Rows)
                    {
                        total += Convert.ToDouble(dataGridView3.Rows[a].Cells["Total"].Value);
                        a++;
                    }
                    lblTotPrice.Text = total.ToString();
                    double btotal = Convert.ToInt32(lblTotPrice.Text);
                    double discount = 0;
                    if (txtDiscount.Text != string.Empty && Convert.ToDouble(txtDiscount.Text)> 0.0)

                    {
                        discount = (double)(btotal * Convert.ToDouble(txtDiscount.Text)/100);
                    }
                    else
                    {
                        discount = 0.0;
                    }
                    label9.Text = discount.ToString();
                    lblMinus.Text = "(" + btotal.ToString() + " - " + discount.ToString() + ")";
                    lblFinalPrice.Text ="= " +  (btotal - discount).ToString();
                }
                else
                {
                    MessageBox.Show("Please select less Quantity than stock");
                }
                
                
            }
            else
            {
                MessageBox.Show("Enter Product Quality > 0");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                IEnumerator myEnumerator;
                myEnumerator = checkedListBox1.CheckedIndices.GetEnumerator();
                int y;
                while (myEnumerator.MoveNext() != false)
                {
                    y = (int)myEnumerator.Current;
                    checkedListBox1.SetItemChecked(y, false);
                }
            }

            txtDiscount.Text = checkedListBox1.Text;
        }
    }
}
