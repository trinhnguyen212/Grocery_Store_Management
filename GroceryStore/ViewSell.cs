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
    public partial class ViewSell : Form
    {
        code.Query_DB qdb = new code.Query_DB();
        public ViewSell()
        {
            InitializeComponent();
        }

        private void ViewSell_Load(object sender, EventArgs e)
        {
            qdb.GetSell(dataGridView1);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            qdb.GetSaleBySearch(dataGridView1,Search.Text);
        }
    }
}
