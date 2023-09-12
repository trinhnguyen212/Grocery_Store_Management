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
    public partial class Form1 : Form
    {
        code.Query_DB qd = new code.Query_DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Email.Text !=string.Empty && Password.Text != string.Empty)
            {
                qd.EMAIL = Email.Text;
                qd.PASSWORD = Password.Text;

                if (qd.VerifyUser(qd))
                {
                    lblerror.Text = "";
                    MessageBox.Show("Login Success");
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "*** Wrong Username OR Password **";
                    Email.Text = "";
                    Password.Text = "";
                    Email.Focus();
                }
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }
    }
}
