using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DAO
{
    public class NgonNguDAO
    {
        public List<NgonNgu> GetListNgonNgu()
        {
            DataProvider datap = new DataProvider();
            List<NgonNgu> list = new List<NgonNgu>();
            string query = "Select * from NgonNgu";
            DataTable data = datap.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                NgonNgu nn = new NgonNgu(item);
                list.Add(nn);
            }
            return list;
        }

        public NgonNgu GetListNgonNguByMaSach(string maSach)
        {
            DataProvider dataP = new DataProvider();
            NgonNgu pl = null;
            string query = "Select n.MaNgonNgu,TenNgonNgu from NgonNgu n,Sach s where n.MaNgonNgu=s.MaNgonNgu and MaSach='" + maSach + "'";
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                pl = new NgonNgu(item);
                return pl;
            }

            return pl;
        }

        public string GetMaxMaNN()
        {
            string query = "select top(1) MaNgonNgu from NgonNgu order by MaNgonNgu desc";
            DataProvider data = new DataProvider();
            string r = data.ExecuteScalar(query).ToString();
            return r ;
        }

        public bool InsertNgonNgu(string mann,string tennn)
        {
            string query = "Insert into NgonNgu values('" + mann + "',N'" + tennn + "')";
            DataProvider data = new DataProvider();
            int r = data.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool EditNgonNgu(string mann, string tennn)
        {
            string query = "Update NgonNgu Set TenNgonNgu=N'"+tennn+"' where MaNgonNgu='"+mann+"'";
            DataProvider data = new DataProvider();
            int r = data.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool DeleteNgonNgu(string mann)
        {
            string query = "Delete NgonNgu where MaNgonNgu='"+mann+"'";
            DataProvider data = new DataProvider();
            int r = data.ExecuteNonQuery(query);
            return r > 0;
        }

        public List<NgonNgu> searchNgonNgu(string key)
        {
            DataProvider datap = new DataProvider();
            List<NgonNgu> list = new List<NgonNgu>();
            string query = "Select * from NgonNgu where MaNgonNgu like '"+key+"%'";
            DataTable data = datap.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NgonNgu nn = new NgonNgu(item);
                list.Add(nn);
            }
            return list;
        }
    }
}
