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
    public partial class fQuanLyAccount : Form
    {
        private Account loginAcc;

        public Account LoginAcc
        {
            get
            {
                return loginAcc;
            }

            set
            {
                loginAcc = value;

            }
        }
        public fQuanLyAccount(Account a)
        {
            this.LoginAcc = a;
            InitializeComponent();
        }



        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string reNewPass = txtReNewPass.Text;

            if(newPass!="" && newPass==reNewPass)
            {
                if (txtOldPass.Text != LoginAcc.PassWord)
                {
                    MessageBox.Show("Sai Mật khẩu cũ");
                }
                else
                {
                    LoginDAO login = new LoginDAO();
                    if (login.DoiMatKhau(txtUserName.Text, newPass))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                }

            }

            else
            {
                MessageBox.Show("Mật khẩu không trùng nhau");
            }
        }

        private void fQuanLyAccount_Load(object sender, EventArgs e)
        {
            txtUserName.Text = LoginAcc.UserName;
            txtHoten.Text = LoginAcc.TenNhanVien;
            txtQuyenHan.Text = LoginAcc.QuyenHan;
        }
    }
}
