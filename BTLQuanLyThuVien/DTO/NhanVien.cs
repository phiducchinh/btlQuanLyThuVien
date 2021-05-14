using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DTO
{
    public class NhanVien
    {
        string maNhanVien;
        string hoTen;
        string diaChi;
        string userName;
        string quyenHan;

        public NhanVien(string MaNhanVien, string HoTen,string DiaChi,string UserName,string QuyenHan)
        {
            this.MaNhanVien = MaNhanVien;
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
            this.UserName = UserName;
            this.QuyenHan = QuyenHan;
        }

        public NhanVien(DataRow row)
        {
            this.MaNhanVien = row["MaNhanVien"].ToString(); ;
            this.HoTen = row["HoTen"].ToString(); ;
            this.DiaChi = row["DiaChi"].ToString();
            this.UserName = row["UserName"].ToString();
            int quyenhan = (int)row["QuyenHan"];
            if (quyenhan == 1)
                this.QuyenHan = "Thủ thư";
            else
                this.QuyenHan = "Nhân viên";
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

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
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
    }
}
