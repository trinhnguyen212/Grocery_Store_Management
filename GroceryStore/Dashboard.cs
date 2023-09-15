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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtQty.Text = dataGridView1.SelectedCells[2].Value.ToString();
            lblID.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtPrice.ReadOnly= true;
           txtProductName.Select();    
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            qdb.GetProductByNameSearch(dataGridView1, txtProductName.Text);
        }
    }
}
