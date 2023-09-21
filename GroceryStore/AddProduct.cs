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
           Bitmap BmpImage = new Bitmap(pictureBox1.Image);
            
            if(PName.Text != string.Empty && PPrice.Text != string.Empty && PQuantity.Text != string.Empty && cbxCategory.Text != string.Empty )
            {
               

                if (qdb.AddProduct(cbxCategory.Text.ToString(),PName.Text, Convert.ToInt32(PPrice.Text), Convert.ToInt32(PQuantity.Text), BmpImage))
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using(OpenFileDialog fileDialog = new OpenFileDialog() { Filter="JPEG|*.jpg", ValidateNames=false}) 
                {
                    if (fileDialog.ShowDialog()== DialogResult.OK)
                    {
                        pictureBox1.Image =new Bitmap(fileDialog.FileName); 
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName, format);
            }

        }
    }
}
