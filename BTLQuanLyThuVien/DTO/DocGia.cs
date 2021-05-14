using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DTO
{
    public class DocGia
    {
        string maDG;
        string hoTen;
        DateTime? ngaySinh;
        int maSV;
        string tenKhoa;
        string diaChi;
        DateTime? ngayLapThe;

        public DocGia (string MaDG, string HoTen,int MaSV, DateTime NgaySinh, string TenKhoa, string DiaChi, DateTime NgayLapThe)
        {
            this.MaDG = MaDG;
            this.HoTen = HoTen;
            this.MaSV = MaSV;
            this.NgaySinh = NgaySinh;
            this.TenKhoa = TenKhoa;
            this.DiaChi = DiaChi;
            this.NgayLapThe = NgayLapThe;
        }

     
        public DocGia(DataRow row)
        {
            this.MaDG = row["MaDG"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.MaSV = (int)row["MaSV"];
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.TenKhoa = row["TenKhoa"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.NgayLapThe = (DateTime)row["NgayLapThe"];
        }

        public string MaDG
        {
            get
            {
                return maDG;
            }

            set
            {
                maDG = value;
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

        public DateTime? NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public string TenKhoa
        {
            get
            {
                return tenKhoa;
            }

            set
            {
                tenKhoa = value;
            }
        }

       

        public DateTime? NgayLapThe
        {
            get
            {
                return ngayLapThe;
            }

            set
            {
                ngayLapThe = value;
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

        public int MaSV
        {
            get
            {
                return maSV;
            }

            set
            {
                maSV = value;
            }
        }
    }
}
