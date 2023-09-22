namespace GroceryStore
{
    partial class CreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UName = new System.Windows.Forms.TextBox();
            this.UEmail = new System.Windows.Forms.TextBox();
            this.UMobile = new System.Windows.Forms.TextBox();
            this.UAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UFemale = new System.Windows.Forms.RadioButton();
            this.UMale = new System.Windows.Forms.RadioButton();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.RichTextBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // UName
            // 
            this.UName.BackColor = System.Drawing.Color.White;
            this.UName.Location = new System.Drawing.Point(223, 54);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(229, 20);
            this.UName.TabIndex = 1;
            this.UName.TabStop = false;
            // 
            // UEmail
            // 
            this.UEmail.Location = new System.Drawing.Point(223, 114);
            this.UEmail.Name = "UEmail";
            this.UEmail.Size = new System.Drawing.Size(229, 20);
            this.UEmail.TabIndex = 1;
            // 
            // UMobile
            // 
            this.UMobile.Location = new System.Drawing.Point(223, 219);
            this.UMobile.Name = "UMobile";
            this.UMobile.Size = new System.Drawing.Size(229, 20);
            this.UMobile.TabIndex = 1;
            // 
            // UAddress
            // 
            this.UAddress.Location = new System.Drawing.Point(223, 266);
            this.UAddress.Multiline = true;
            this.UAddress.Name = "UAddress";
            this.UAddress.Size = new System.Drawing.Size(229, 61);
            this.UAddress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UFemale);
            this.groupBox1.Controls.Add(this.UMale);
            this.groupBox1.Location = new System.Drawing.Point(223, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // UFemale
            // 
            this.UFemale.AutoSize = true;
            this.UFemale.Location = new System.Drawing.Point(150, 25);
            this.UFemale.Name = "UFemale";
            this.UFemale.Size = new System.Drawing.Size(59, 17);
            this.UFemale.TabIndex = 0;
            this.UFemale.TabStop = true;
            this.UFemale.Text = "Female";
            this.UFemale.UseVisualStyleBackColor = true;
            this.UFemale.Click += new System.EventHandler(this.UFemale_Click);
            // 
            // UMale
            // 
            this.UMale.AutoSize = true;
            this.UMale.Location = new System.Drawing.Point(24, 25);
            this.UMale.Name = "UMale";
            this.UMale.Size = new System.Drawing.Size(48, 17);
            this.UMale.TabIndex = 0;
            this.UMale.TabStop = true;
            this.UMale.Text = "Male";
            this.UMale.UseVisualStyleBackColor = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnCreateUser.Location = new System.Drawing.Point(377, 356);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(75, 23);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(223, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdit.Location = new System.Drawing.Point(701, 35);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(393, 214);
            this.txtEdit.TabIndex = 5;
            this.txtEdit.Text = "";
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(748, 372);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 6;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(998, 372);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 612);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UAddress);
            this.Controls.Add(this.UMobile);
            this.Controls.Add(this.UEmail);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.TextBox UEmail;
        private System.Windows.Forms.TextBox UMobile;
        private System.Windows.Forms.TextBox UAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UFemale;
        private System.Windows.Forms.RadioButton UMale;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtEdit;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}