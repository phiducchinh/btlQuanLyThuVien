using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DAO
{
    public class PhanLoaiDAO
    {
        public List<PhanLoai> GetListPhanLoai()
        {
            DataProvider dataP = new DataProvider();
            List<PhanLoai> list = new List<PhanLoai>();
            string query = "Select * From PhanLoai";
            DataTable data = dataP.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                PhanLoai pl = new PhanLoai(item);
                list.Add(pl);
            }
            return list;
        }

        public PhanLoai GetListPhanLoaiByMaSach(string maSach)
        {
            DataProvider dataP = new DataProvider();
            PhanLoai pl = null;
            string query = "Select p.MaLoai,TenLoai from PhanLoai p ,Sach s where p.MaLoai=s.MaLoai and MaSach='" + maSach+"'";
            DataTable data = dataP.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                pl = new PhanLoai(item);
                return pl;
            }

            return pl;
        }

        public string GetMaxMaPL()
        {
            string query = "select top(1) MaLoai from PhanLoai order by MaLoai desc";
            DataProvider data = new DataProvider();
            string r = data.ExecuteScalar(query).ToString();
            return r;
        }

        public bool InsertNgonNgu(string mann, string tennn)
        {
            string query = "Insert into PhanLoai values('" + mann + "',N'" + tennn + "')";
            DataProvider data = new DataProvider();
            int r = data.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool EditNgonNgu(string mann, string tennn)
        {
            string query = "Update PhanLoai Set TenLoai=N'" + tennn + "' where MaLoai='" + mann + "'";
            DataProvider data = new DataProvider();
            int r = data.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool DeleteNgonNgu(string mann)
        {
            string query = "Delete PhanLoai where MaLoai='" + mann + "'";
            DataProvider data = new DataProvider();
            int r = data.ExecuteNonQuery(query);
            return r > 0;
        }

        public List<PhanLoai> SearchPhanLoai(string mapl)
        {
            DataProvider dataP = new DataProvider();
            List<PhanLoai> list = new List<PhanLoai>();
            string query = "Select * From PhanLoai where MaLoai like '"+mapl+"%'";
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhanLoai pl = new PhanLoai(item);
                list.Add(pl);
            }
            return list;
        }
    }
}
