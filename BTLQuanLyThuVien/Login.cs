using BTLQuanLyThuVien.DAO;
using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQuanLyThuVien
{
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();
        }
        
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUserName.Text;
            password = txtPassWord.Text;

         
            LoginDAO login = new LoginDAO();
            
            if (login.Login(username, password))
            {
                Account AccountLogin = login.GetAccountByUserName(username);
                btnLogin.Tag = AccountLogin;

                fManagement f = new fManagement(AccountLogin);
                f.Tag = (sender as Button).Tag ;
                this.Hide();
                
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
           

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DialogResult d= MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel);
            if ( d != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel=true;

            }
            else if(d== System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            */
            

        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked == true)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
