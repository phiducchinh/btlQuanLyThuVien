using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DAO
{
    public class LoginDAO
    {
        public bool Login(string username,string password)
        {
            DataProvider data = new DataProvider();
            string query = "exec USP_Login @UserName , @PassWord ";
            DataTable result = data.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string username)
        {
            DataProvider dataP = new DataProvider();
            string query = "select UserName, PassWord, a.MaNhanVien,Hoten,QuyenHan from Account a, NhanVien n where a.MaNhanVien=n.MaNhanVien and UserName= '" + username + "'";
            DataTable data = new DataTable();
            data = dataP.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public List<Account> GetListAccount()
        {
            DataProvider dataP = new DataProvider();
            List<Account> list = new List<Account>();
            string query = "Select Distinct QuyenHan,UserName, PassWord,a.MaNhanVien,HoTen from Account a,NhanVien n where a.MaNhanVien=n.MaNhanVien and  a.MaNhanVien in ('NV01','NV03')";
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account pl = new Account(item);
                list.Add(pl);
            }
            return list;
        }

        public bool DoiMatKhau(string username, string pass)
        {
            string query= "exec USP_DoiMatKhau @userName , @newPass";
            DataProvider data = new DataProvider();
            int r = data.ExecuteNonQuery(query, new object[] { username, pass });
            return r>0;
        }

        public bool DoiMatKhauAdmin(string username)
        {
            string query = "exec USP_DoiMatKhau @userName , @newPass";
            DataProvider data = new DataProvider();
            int r = data.ExecuteNonQuery(query, new object[] { username, "1" });
            return r > 0;
        }


    }
}
