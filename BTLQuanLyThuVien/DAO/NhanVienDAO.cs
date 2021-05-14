using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DAO
{
    public class NhanVienDAO
    {
        public List<NhanVien> GetListNhanVien()
        {
            string query = "Select a.MaNhanVien, HoTen, DiaChi, UserName,QuyenHan from Account a, NhanVien n Where a.MaNhanVien=n.MaNhanVien";
            DataProvider datap = new DataProvider();
            List<NhanVien> list = new List<NhanVien>();
            DataTable data = datap.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }

        public List<NhanVien> SearchListNhanVienByMaNV(string key)
        {
            string query = "Select a.MaNhanVien, HoTen, DiaChi, UserName,QuyenHan from Account a, NhanVien n Where a.MaNhanVien=n.MaNhanVien and a.MaNhanVien like '"+key+"%'";
            DataProvider datap = new DataProvider();
            List<NhanVien> list = new List<NhanVien>();
            DataTable data = datap.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }

        public List<NhanVien> SearchListNhanVienByTenNV(string key)
        {
            string query = "Select a.MaNhanVien, HoTen, DiaChi, UserName,QuyenHan from Account a, NhanVien n Where a.MaNhanVien=n.MaNhanVien and HoTen like '" + key + "%'";
            DataProvider datap = new DataProvider();
            List<NhanVien> list = new List<NhanVien>();
            DataTable data = datap.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }

        public bool InsertNhanVien(string manv, string hoten, string diachi, string username, int quyenhan)
        {
            DataProvider datap = new DataProvider();
            string query = string.Format("Insert Into NhanVien values('{0}',N'{1}',N'{2}')",manv,hoten,diachi);
            string query1 = string.Format("Insert Into Account values('{0}','1','{1}',{2})", username, manv, quyenhan);
            int data = datap.ExecuteNonQuery(query);
            int data1 = -1;
            if (data > 0)
            {
                DataProvider d = new DataProvider();
                data1 = d.ExecuteNonQuery(query1);
                return true;
            }
            return data1 > 0;

        }

        public string GetMaNVMax()
        {
            DataProvider data = new DataProvider();
            string query = "select top(1) MaNhanVien from NhanVien order By MaNhanVien desc";
            string result = data.ExecuteScalar(query).ToString();
            return result;

        }
        public bool DeleteNhanVien(string manv)
        {
            DataProvider data = new DataProvider();
            string query1 = "Delete Account where MaNhanVien='" + manv + "'";
            string query = "Delete NhanVien where MaNhanVien='" + manv + "'";
            data.ExecuteNonQuery(query1);
            int r = data.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool UpdateNhanVien(string manv, string hoten, string diachi, int quyenhan)
        {
            DataProvider d = new DataProvider();
            string query = string.Format("Update NhanVien Set HoTen=N'{0}', DiaChi=N'{1}' where MaNhanVien='{2}'", hoten, diachi, manv);
            string query1 = string.Format("Update Account Set QuyenHan={0} where MaNhanVien='{1}'", quyenhan, manv);
            d.ExecuteNonQuery(query1);
            int r = d.ExecuteNonQuery(query);
            return r > 0;
        }

        
    }
}
