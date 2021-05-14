using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DTO
{
    public class PhieuMuon
    {
        string maPhieuMuon;
        string maDG;
        DateTime? ngayMuon;
        DateTime? ngayTra;
        string maNhanVien;
        string trangThaiTong;
        string maSach;
        int soLuong;

        public PhieuMuon(string MaPhieuMuon, string MaDG, DateTime NgayMuon, DateTime NgayTra, string MaNhanVien, string TrangThaiTong, string MaSach,int SoLuong)
        {
            this.MaPhieuMuon = MaPhieuMuon;
            this.MaDG = MaDG;
            this.NgayMuon = NgayMuon;
            this.NgayTra = NgayTra;
            this.MaNhanVien = MaNhanVien;
            this.TrangThaiTong = TrangThaiTong;
            this.MaSach = MaSach;
            this.SoLuong = SoLuong;

        }

        public PhieuMuon(DataRow row)
        {
            DateTime dt = DateTime.Now;
            this.MaPhieuMuon = row["MaPhieuMuon"].ToString();
            this.MaDG = row["MaDG"].ToString();
            this.NgayMuon = (DateTime)row["NgayMuon"];
            this.NgayTra = (DateTime)row["NgayTra"];
            this.MaNhanVien = row["MaNhanVien"].ToString();
            if ((int) row["TrangThaiTong"] == 0)
            {
                if(this.NgayTra < dt)
                {
                    this.TrangThaiTong = "Quá hạn";
                }
                else
                {
                    this.TrangThaiTong = "Chưa trả";
                }
            }
            else
            {
                this.TrangThaiTong = "Đã trả";
            }
            
            this.MaSach = row["MaSach"].ToString();
            this.SoLuong = (int)row["SoLuong"];
        }


        public string MaPhieuMuon
        {
            get
            {
                return maPhieuMuon;
            }

            set
            {
                maPhieuMuon = value;
            }
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

        public DateTime? NgayMuon
        {
            get
            {
                return ngayMuon;
            }

            set
            {
                ngayMuon = value;
            }
        }

        public DateTime? NgayTra
        {
            get
            {
                return ngayTra;
            }

            set
            {
                ngayTra = value;
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

        

        public string MaSach
        {
            get
            {
                return maSach;
            }

            set
            {
                maSach = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string TrangThaiTong
        {
            get
            {
                return trangThaiTong;
            }

            set
            {
                trangThaiTong = value;
            }
        }
    }
}
