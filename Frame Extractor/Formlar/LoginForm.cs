using Frame_Extractor.Models;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frame_Extractor.Formlar
{
    public partial class LoginForm : Form

    {
        
        private string user_name = "deneme@myps.com";
        private string password = "deneme";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtBoxId.Text) || string.IsNullOrEmpty(txtBoxPassword.Text) )
            {
                 MessageBox.Show("Lütfen Bilgilerinizi Tam Giriniz!");
                return;
            }

            if (user_name == txtBoxId.Text && password == txtBoxPassword.Text )
            {
                MessageBox.Show("Başarıyla giriş yapıldı! Yönlendiriliyorsunuz...", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                FirstForm firstForm = new FirstForm();
                firstForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            txtBoxPassword.PasswordChar = '*';
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
