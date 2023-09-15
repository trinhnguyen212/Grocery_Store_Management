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
    public partial class CreateUser : Form
    {
        code.Query_DB qdb = new code.Query_DB();
        public CreateUser()
        {
            InitializeComponent();
        }

       
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if(UName.Text != string.Empty && UEmail.Text != string.Empty && UMobile.Text != string.Empty && UAddress.Text != string.Empty)
            {
                String EMAIL = UEmail.Text;
                if(!qdb.CheckUser(EMAIL))
                {
                    String NAME = UName.Text;
                    String ADDRESS = UAddress.Text;
                    String MOBILE = UMobile.Text;
                    String GENDER = " ";
                    
                    if (UMale.Checked) { GENDER = "Male"; }
                    if(UFemale.Checked) { GENDER = "Female"; }
                    if (qdb.CreateUser(EMAIL, NAME, MOBILE, ADDRESS, GENDER))
                    {
                        MessageBox.Show("User Created");
                       this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("There is some problem in creating user");
                    }
                }
                else
                {
                    MessageBox.Show("User already Exist");

                }
            }
            else
            {
                MessageBox.Show("Validation error");
            }
        }

        private void UFemale_Click(object sender, EventArgs e)
        {



        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UEmail.Text = "";
            UMobile.Text = "";
            UAddress.Text = "";
            UName.Text = "";
        }
    }
}
