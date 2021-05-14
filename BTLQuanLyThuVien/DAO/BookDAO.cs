using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DAO
{
    public class BookDAO
    {
        public List<Book> GetListBook()
        {
            DataProvider datap = new DataProvider();
            List<Book> list = new List<Book>();
            string query = "select MaSach ,NhanDe,TacGia,SoTrang,SoLuongCon,SoLuongTong,TenNgonNgu,TenLoai,NhaXuatBan ,NamSX,LanXB,SoLanMuon,NgayNhap from Sach s,PhanLoai p, NgonNgu n where s.MaLoai=p.MaLoai and s.MaNgonNgu=n.MaNgonNgu";
            DataTable data = datap.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> GetListBookByNhanDe(string key)
        {
            List<Book> list = new List<Book>();
            string query = string.Format("select MaSach,NhanDe,TacGia,SoTrang,SoLuongCon,SoLuongTong,TenNgonNgu,TenLoai,NhaXuatBan ,NamSX,LanXB,SoLanMuon,NgayNhap from Sach s,PhanLoai p, NgonNgu n where s.MaLoai=p.MaLoai and s.MaNgonNgu=n.MaNgonNgu and s.NhanDe like  N'%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> GetListBookByMaSach(string key)
        {
            List<Book> list = new List<Book>();
            string query = string.Format("select MaSach,NhanDe,TacGia,SoTrang,SoLuongCon,SoLuongTong,TenNgonNgu,TenLoai,NhaXuatBan ,NamSX,LanXB,SoLanMuon,NgayNhap from Sach s,PhanLoai p, NgonNgu n where s.MaLoai=p.MaLoai and s.MaNgonNgu=n.MaNgonNgu and s.MaSach like  N'%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> GetListBookByTacGia(string key)
        {
            List<Book> list = new List<Book>();
            string query = string.Format("select MaSach,NhanDe,TacGia,SoTrang,SoLuongCon,SoLuongTong,TenNgonNgu,TenLoai,NhaXuatBan ,NamSX,LanXB,SoLanMuon,NgayNhap from Sach s,PhanLoai p, NgonNgu n where s.MaLoai=p.MaLoai and s.MaNgonNgu=n.MaNgonNgu and s.TacGia like  N'%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public List<Book> GetListBookByTheLoai(string key)
        {
            List<Book> list = new List<Book>();
            string query = string.Format("select MaSach,NhanDe,TacGia,SoTrang,SoLuongCon,SoLuongTong,TenNgonNgu,TenLoai,NhaXuatBan ,NamSX,LanXB,SoLanMuon,NgayNhap from Sach s,PhanLoai p, NgonNgu n where s.MaLoai=p.MaLoai and s.MaNgonNgu=n.MaNgonNgu and p.TenLoai like  N'%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public string GetMaLoaiByTenLoai(string tenloai)
        {
            string query = "select MaLoai from PhanLoai where TenLoai="+tenloai;
            DataProvider data = new DataProvider();
            return data.ExecuteScalar(query).ToString();
        }

        public bool InsertBook(string masach, string nhande, string tacgia, int sotrang, int soluongcon, int soluongtong, int namxb, int lanxb,string nxb,int solanmuon,string maloai,DateTime ngaynhap,string ngonngu)
        {
            string query = string.Format("Insert Into dbo.Sach values ('{0}',N'{1}',N'{2}',{3},{4},{5},{6},{7},N'{8}',{9},'{10}','{11}','{12}')",masach,nhande,tacgia,sotrang,soluongcon,soluongtong,namxb,lanxb,nxb,solanmuon,maloai,ngaynhap,ngonngu);
            DataProvider data = new DataProvider();
            int dataP=data.ExecuteNonQuery(query);
            return dataP > 0;

        }

        public bool EditBook(string masach, string nhande, string tacgia, int sotrang, int soluongtong, int soluongcon, int namxb, int lanxb, string nxb, int solanmuon, string maloai, DateTime ngaynhap, string ngonngu)
        {
            string query = "Update Sach SET NhanDe = N'"+nhande+"', TacGia=N'"+tacgia+"', SoTrang="+sotrang+", SoLuongTong="+soluongtong+", SoLuongCon="+soluongcon+", NamSX="+namxb+", LanXB="+lanxb+", NhaXuatBan=N'"+nxb+"', SolanMuon="+solanmuon+", MaLoai='"+maloai+"', NgayNhap='"+ngaynhap+"', MaNgonNgu='"+ngonngu+"' where MaSach='"+masach+"'";

            DataProvider dataP = new DataProvider();
            int data = dataP.ExecuteNonQuery(query);
            return data > 0;
        }

        public string getMaxMaSach()
        {
            string query = "Select top(1) MaSach from Sach order by MaSach desc";
            DataProvider data = new DataProvider();
            return data.ExecuteScalar(query).ToString();
        }

        public bool DeleteBook(string masach)
        {
            string query = "delete Sach where MaSach='" + masach+"'";
            string query1 = "delete PhieuMuon where MaSach'" + masach + "'";
            DataProvider datap = new DataProvider();
            DataProvider data1 = new DataProvider();
            data1.ExecuteQuery(query1);
            int data = datap.ExecuteNonQuery(query);
            return data > 0;
        }

        public Book GetBookByMaSach(string masach)
        {
            DataProvider datap = new DataProvider();
            string query = "select MaSach,NhanDe,TacGia,SoTrang,SoLuongCon,SoLuongTong,TenNgonNgu,TenLoai,NhaXuatBan ,NamSX,LanXB,SoLanMuon,NgayNhap from Sach s,PhanLoai p, NgonNgu n where s.MaLoai=p.MaLoai and s.MaNgonNgu=n.MaNgonNgu and s.MaSach='"+masach+"'";
            DataTable data = datap.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
               return new Book(item);
            }
            return null;
        }

        public int CheckBookNumberByMaSach(string masach)
        {
            DataProvider dataP = new DataProvider();
            string query = "select SoLuongCon from Sach where MaSach='"+masach+"'";
            int data = (int)dataP.ExecuteScalar(query);
            return data;
        }
    }
}
