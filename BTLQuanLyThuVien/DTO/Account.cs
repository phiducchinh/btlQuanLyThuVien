using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DTO
{
    public class Account
    {
        string userName;
        string passWord;
        string maNhanVien;
        string tenNhanVien;
        string quyenHan;

        public Account(string username,string passWord, string maNhanVien, string tenNhanVien, string quyenHan)
        {
            this.UserName = userName;
            this.PassWord = passWord;
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.QuyenHan = quyenHan;
        }

        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.PassWord = row["PassWord"].ToString();
            this.MaNhanVien = row["MaNhanVien"].ToString();
            this.TenNhanVien = row["HoTen"].ToString();
            int quyenhan = (int)row["QuyenHan"];
            if (quyenhan == 1)
                this.QuyenHan = "Thủ thư";
            else
                this.QuyenHan = "Nhân viên";

        }
        

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public string QuyenHan
        {
            get
            {
                return quyenHan;
            }

            set
            {
                quyenHan = value;
            }
        }

        public string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }

            set
            {
                tenNhanVien = value;
            }
        }
    }
}
