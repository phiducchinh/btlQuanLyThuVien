using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DAO
{
    public class DocGiaDAO
    {
        public List<DocGia> GetListDocGia()
        {
            DataProvider datap = new DataProvider();
            List<DocGia> list = new List<DocGia>();
            string query = "select * from DocGia";
            DataTable data = datap.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DocGia dg = new DocGia(item);
                list.Add(dg);
            }
            return list;
        }

        public string getMaxMaDG()
        {
            string query = "Select top(1) MaDG from DocGia order by MaDG desc";
            DataProvider data = new DataProvider();
            return data.ExecuteScalar(query).ToString();
        }

        public bool DeleteDG(string madg)
        {
            string query = "delete DocGia where MaDG='" + madg+ "'";
            DataProvider datap = new DataProvider();
            int data = datap.ExecuteNonQuery(query);
            return data > 0;
        }
        public bool InsertDG(string madg, string hoten,int masv, DateTime ngaysinh, string tenkhoa, string diachi, DateTime ngaylapthe)
        {
            string query = string.Format("Insert Into DocGia values ('{0}',N'{1}',{2},'{3}',N'{4}',N'{5}','{6}')",madg,hoten,masv,ngaysinh,tenkhoa,diachi,ngaylapthe);
            DataProvider data = new DataProvider();
            int dataP = data.ExecuteNonQuery(query);
            return dataP > 0;
        }
        
        public bool EditDG(string madg, string hoten, int masv, DateTime ngaysinh, string tenkhoa, string diachi, DateTime ngaylapthe)
        {
            string query = string.Format("Update DocGia SET HoTen=N'{0}', MaSV={1}, NgaySinh='{2}', TenKhoa=N'{3}', DiaChi=N'{4}', NgayLapThe='{5}' where MaDG='{6}' ", hoten, masv, ngaysinh, tenkhoa, diachi, ngaylapthe, madg);
            DataProvider data = new DataProvider();
            int dataP = data.ExecuteNonQuery(query);
            return dataP > 0;
        }

        public List<DocGia> GetListDGByMaDG(string key)
        {
            List<DocGia> list = new List<DocGia>();
            string query = string.Format("select * from DocGia where MaDG like  '%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DocGia book = new DocGia(item);
                list.Add(book);
            }
            return list;
        }

        public List<DocGia> GetListDGByMaSV(string key)
        {
            List<DocGia> list = new List<DocGia>();
            string query = string.Format("select * from DocGia where MaSV like  N'%{0}%'", key);
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DocGia book = new DocGia(item);
                list.Add(book);
            }
            return list;
        }

        public DocGia GetNameDG(string madg)
        {
            string query = string.Format("select * from DocGia where MaDG ='"+madg+"'");
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            DocGia dg = null;
            foreach (DataRow item in data.Rows)
            {
                return dg = new DocGia(item);
            }
            return dg;

        }

        public DocGia GetNameDGByMsv(string madg)
        {
            string query = string.Format("select * from DocGia where MaSV ='" + madg + "'");
            DataProvider dataP = new DataProvider();
            DataTable data = dataP.ExecuteQuery(query);
            DocGia dg = null;
            foreach (DataRow item in data.Rows)
            {
                return dg = new DocGia(item);
            }
            return dg;

        }
    }
}
