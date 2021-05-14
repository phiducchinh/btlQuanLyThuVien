using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DTO
{
    public class Book
    {
        private string maSach;
        private string nhanDe;
        private string tacGia;
        private int soTrang;
        private int soLuongTong;
        private int soLuongCon;
        private int namXB;
        private int lanXB;
        private string nhaXB;
        private int soLanMuon;
        private string tenLoai;
        private DateTime? ngayNhap;
        private string TenNgonNgu;

        public Book(string MaSach, string NhanDe, string TacGia, int SoTrang, int SoLuongTong, int SoLuongCon, int NamXB, int LanXB, string NhaXB,int SolanMuon, DateTime NgayNhap, string TenNgonNgu, string TenLoai="")
        {
            this.MaSach = MaSach;
            this.NhanDe = NhanDe;
            this.TacGia = TacGia;
            this.SoTrang = SoTrang;
            this.SoLuongTong = SoLuongTong;
            this.SoLuongCon = SoLuongCon;
            this.NamXB = NamXB;
            this.LanXB = LanXB;
            this.NhaXB = NhaXB;
            this.SoLanMuon = SolanMuon;
            this.TenLoai = TenLoai;
            this.NgayNhap = NgayNhap;
            this.TenNgonNgu = TenNgonNgu;
        }
        public Book(DataRow row)
        {
            this.MaSach = row["MaSach"].ToString();
            this.NhanDe = row["NhanDe"].ToString();
            this.TacGia = row["TacGia"].ToString();
            this.SoTrang = (int) row["SoTrang"];
            this.SoLuongTong =(int) row["SoLuongTong"];
            this.SoLuongCon = (int) row["SoLuongCon"];
            this.NamXB = (int) row["NamSX"];
            this.LanXB = (int) row["LanXB"];
            this.NhaXB = row["NhaXuatBan"].ToString();
            this.SoLanMuon = (int) row["SolanMuon"];
            this.TenLoai = row["TenLoai"].ToString();
            this.NgayNhap = (DateTime?) row["NgayNhap"];
            this.TenNgonNgu =row["TenNgonNgu"].ToString();

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

        public string NhanDe
        {
            get
            {
                return nhanDe;
            }

            set
            {
                nhanDe = value;
            }
        }

        public string TacGia
        {
            get
            {
                return tacGia;
            }

            set
            {
                tacGia = value;
            }
        }

        public int SoTrang
        {
            get
            {
                return soTrang;
            }

            set
            {
                soTrang = value;
            }
        }

        public int SoLuongTong
        {
            get
            {
                return soLuongTong;
            }

            set
            {
                soLuongTong = value;
            }
        }

        public int SoLuongCon
        {
            get
            {
                return soLuongCon;
            }

            set
            {
                soLuongCon = value;
            }
        }

        public int NamXB
        {
            get
            {
                return namXB;
            }

            set
            {
                namXB = value;
            }
        }

        public string NhaXB
        {
            get
            {
                return nhaXB;
            }

            set
            {
                nhaXB = value;
            }
        }

        public int SoLanMuon
        {
            get
            {
                return soLanMuon;
            }

            set
            {
                soLanMuon = value;
            }
        }

        public string TenLoai
        {
            get
            {
                return tenLoai;
            }

            set
            {
                tenLoai = value;
            }
        }

        public DateTime? NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }

        public int LanXB
        {
            get
            {
                return lanXB;
            }

            set
            {
                lanXB = value;
            }
        }

        public string TenNgonNgu1
        {
            get
            {
                return TenNgonNgu;
            }

            set
            {
                TenNgonNgu = value;
            }
        }
    }
}
