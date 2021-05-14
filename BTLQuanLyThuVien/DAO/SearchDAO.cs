using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DAO
{
    public class SearchDAO
    {
        public List<SearchBook> GetListBookByNhanDe(string key)
        {
            List<SearchBook> list = new List<SearchBook>();
            string query = string.Format("Select MaSach , NhanDe, TacGia, SoLuongCon, TenLoai, NhaXuatBan from Sach s , PhanLoai p where s.MaLoai = p.MaLoai and s.NhanDe like  N'%{0}%'",key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                SearchBook search = new SearchBook(item);
                list.Add(search);
            }
            return list;
        }

        public List<SearchBook> GetListBookByMaSach(string key)
        {
            List<SearchBook> list = new List<SearchBook>();
            string query = string.Format("Select MaSach , NhanDe, TacGia, SoLuongCon, TenLoai, NhaXuatBan from Sach s , PhanLoai p where s.MaLoai = p.MaLoai and s.MaSach like  N'%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SearchBook search = new SearchBook(item);
                list.Add(search);
            }
            return list;
        }

        public List<SearchBook> GetListBookByTacGia(string key)
        {
            List<SearchBook> list = new List<SearchBook>();
            string query = string.Format("Select MaSach , NhanDe, TacGia, SoLuongCon, TenLoai, NhaXuatBan from Sach s , PhanLoai p where s.MaLoai = p.MaLoai and s.TacGia like  N'%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SearchBook search = new SearchBook(item);
                list.Add(search);
            }
            return list;
        }

        public List<SearchBook> GetListBookByTheLoai(string key)
        {
            List<SearchBook> list = new List<SearchBook>();
            string query = string.Format("Select MaSach , NhanDe, TacGia, SoLuongCon, TenLoai, NhaXuatBan from Sach s , PhanLoai p where s.MaLoai = p.MaLoai and p.TenLoai like  N'%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SearchBook search = new SearchBook(item);
                list.Add(search);
            }
            return list;
        }
    }
}
