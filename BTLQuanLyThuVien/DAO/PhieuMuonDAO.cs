using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLQuanLyThuVien.DAO
{
    public class PhieuMuonDAO
    {

       

        public List<PhieuMuon> GetListPhieuMuon()
        {
            DataProvider dataP = new DataProvider();
            List<PhieuMuon> list = new List<PhieuMuon>();
            string query = "select top(10) * from PhieuMuon where TrangThaiTong=0 order by MaPhieuMuon desc";
            DataTable data = dataP.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                PhieuMuon pm = new PhieuMuon(item);
                list.Add(pm);

            }
            return list;
        }

        public List<PhieuMuon> GetListPhieuMuonbyPage(int sotrang ,int trangthai)
        {
            DataProvider dataP = new DataProvider();
            List<PhieuMuon> list = new List<PhieuMuon>();
            string query = "Exec USP_GetListPhieuMuonByPage @page , @trangthai ";
            DataTable data = dataP.ExecuteQuery(query, new object[] { sotrang , trangthai });
            foreach (DataRow item in data.Rows)
            {
                PhieuMuon pm = new PhieuMuon(item);
                list.Add(pm);

            }
            return list;
        }

        public int GetSoLuong(string query)
        {
            DataProvider data = new DataProvider();
            int sl = (int)data.ExecuteScalar(query);
            return sl;
        }

        public string GetMaxMaPhieu()
        {
            string query = "Select top(1) MaPhieuMuon from PhieuMuon order by MaPhieuMuon desc";
            DataProvider data = new DataProvider();
            return data.ExecuteScalar(query).ToString();
        }

        public DateTime GetTimeNgayMuonByMaPhieu(string maphieu)
        {
            string query = "Select NgayMuon from PhieuMuon where MaPhieuMuon='"+maphieu+"'";
            DataProvider data = new DataProvider();
            return (DateTime) data.ExecuteScalar(query);
        }

        public DateTime GetTimeNgayTraByMaPhieu(string maphieu)
        {
            string query = "Select NgayTra from PhieuMuon where MaPhieuMuon='" + maphieu + "'";
            DataProvider data = new DataProvider();
            return (DateTime)data.ExecuteScalar(query);
        }

        public bool InsertPhieuMuon(string maphieumuon, string madg, DateTime ngaymuon,DateTime ngaytra, string manhanvien, int trangthai, string masach, int soluong)
        {
            string query = "Exec USP_InsertPhieuMuon @MaPhieuMuon , @MaDG , @NgayMuon , @NgayTra , @MaNhanVien , @TrangThai , @MaSach , @soluong ";
            DataProvider datap = new DataProvider();
            int data = datap.ExecuteNonQuery(query, new object[] { maphieumuon, madg, ngaymuon, ngaytra, manhanvien, trangthai, masach, soluong });
            return data > 0;
        }

        public bool GiaHan(string maphieu, DateTime giahan)
        {
            string query = string.Format("update PhieuMuon SET NgayTra='{0}' where MaPhieuMuon='{1}'",giahan,maphieu);
            DataProvider data = new DataProvider();
            int result = data.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool TraSach(string masach,string maphieu, int soluong)
        {
            string query = "Exec USP_TraSach @MaPhieu , @Soluong , @MaSach ";
            DataProvider datap = new DataProvider();
            int data = datap.ExecuteNonQuery(query, new object[] {maphieu , soluong , masach });
            return data > 0;
        }

        public List<PhieuMuon> GetListPhieuMuonByMaDG(string madg)
        {
            DataProvider dataP = new DataProvider();
            List<PhieuMuon> list = new List<PhieuMuon>();
            string query = "select * from PhieuMuon where TrangThaiTong=0 and MaDG like '%"+madg+"%'";
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuMuon pm = new PhieuMuon(item);
                list.Add(pm);

            }
            return list;
        }

        public List<PhieuMuon> GetListPhieuMuonByMaSV(string masv)
        {
            DataProvider dataP = new DataProvider();
            List<PhieuMuon> list = new List<PhieuMuon>();
            string query = "select MaPhieuMuon, p.MaDG, NgayMuon,NgayTra,MaNhanVien,TrangThaiTong,MaSach,SoLuong from PhieuMuon p, DocGia d where p.MaDG=d.MaDG and TrangThaiTong=0 and MaSV like '%" + masv + "%'";
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuMuon pm = new PhieuMuon(item);
                list.Add(pm);

            }
            return list;
        }

        public List<PhieuMuon> GetListPhieuMuonByMaPhieu(string maphieu)
        {
            DataProvider dataP = new DataProvider();
            List<PhieuMuon> list = new List<PhieuMuon>();
            string query = "select * from PhieuMuon where TrangThaiTong=0 and MaPhieuMuon like '%" + maphieu + "%'";
            DataTable data = dataP.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuMuon pm = new PhieuMuon(item);
                list.Add(pm);

            }
            return list;
        }

        public void DeletePhieuMuonByMaNV(string manv)
        {
            DataProvider data = new DataProvider();
            string query = "Delete PhieuMuon where MaNhanVien='"+manv+"'";
            int r = data.ExecuteNonQuery(query);
           
        }

       
    }
}
