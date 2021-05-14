using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DTO
{
    public class SearchBook
    {
        private string maSach;
        private string nhanDe;
        private int soLuongCon;
        private string tacGia;
        private string theLoai;
        private string nhaXuatBan;


        public SearchBook(string maSach, string nhanDe, int soLuongCon, string tacGia,string theLoai,string nhaXuatBan)
        {
            this.MaSach = maSach;
            this.NhanDe = nhanDe;
            this.SoLuongCon = soLuongCon;
            this.TacGia = tacGia;
            this.TheLoai = theLoai;
            this.NhaXuatBan = nhaXuatBan;
        }

        public SearchBook(DataRow row)
        {
            this.MaSach = row["MaSach"].ToString();
            this.NhanDe =row["NhanDe"].ToString();
            this.SoLuongCon =(int) row["SoLuongCon"];
            this.TacGia = row["TacGia"].ToString();
            this.TheLoai = row["TenLoai"].ToString();
            this.NhaXuatBan = row["nhaXuatBan"].ToString();
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

        public string NhaXuatBan
        {
            get
            {
                return nhaXuatBan;
            }

            set
            {
                nhaXuatBan = value;
            }
        }

        public string TheLoai
        {
            get
            {
                return theLoai;
            }

            set
            {
                theLoai = value;
            }
        }
    }
}
