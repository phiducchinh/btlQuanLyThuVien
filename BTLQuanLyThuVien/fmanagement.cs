using BTLQuanLyThuVien.DAO;
using BTLQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQuanLyThuVien
{
    public partial class fManagement : Form
    {
        private Account loginAcc;

        public Account LoginAcc
        {
            get
            {
                return loginAcc;
            }

            set
            {
                loginAcc = value;
              
            }
        }

        public fManagement(Account acc)
        {
            this.LoginAcc = acc;
            InitializeComponent();
            load();
        }
        

        #region method
        void load()
        {
            ChangeAccount(LoginAcc.QuyenHan);
        }

        void ChangeAccount(string qh)
        {
            adminToolStripMenuItem.Enabled = qh == "Thủ thư";
            mượnTrảSáchToolStripMenuItem.Enabled = qh == "Thủ thư";
            if(LoginAcc.TenNhanVien!="")
            quảnLýTàiKhoảnToolStripMenuItem.Text += " (" + LoginAcc.TenNhanVien + ")";
        }

        void addColumnBook()
        {
            lvSearch.Columns.Add("Mã sách");
            lvSearch.Columns.Add("Nhan đề");
            lvSearch.Columns.Add("Tác giả");
            lvSearch.Columns.Add("SL còn");
            lvSearch.Columns.Add("Thể loại");
            lvSearch.Columns.Add("NXB");
        }

        void addColumPhieuMuon()
        {
            lvSearch.Columns.Add("Mã PM");
            lvSearch.Columns.Add("Mã DG");
            lvSearch.Columns.Add("Mã Sách");
            lvSearch.Columns.Add("SL");
            lvSearch.Columns.Add("Ngày mượn");
            lvSearch.Columns.Add("Ngày trả");

        }
        void taohang()
        {
            thanhtrangthai1.Items[0].Text = "";
            for (int i = 0; i < lvSearch.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lvSearch.Items[i].BackColor = Color.LightGray;
                }
            }
            lvSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            int j = lvSearch.Items.Count;
            thanhtrangthai1.Items[0].Text +="Số bản ghi tìm được: "+ j.ToString();
        }


        void SearchByNhanDe(string key)
        {
            lvSearch.Columns.Clear();
            lvSearch.Items.Clear();
            SearchDAO search = new SearchDAO();
            List<SearchBook> list = search.GetListBookByNhanDe(key);
            addColumnBook();
            foreach (SearchBook item in list)
            {
                ListViewItem lsv = new ListViewItem(item.MaSach.ToString());
                lsv.SubItems.Add(item.NhanDe.ToString());
                lsv.SubItems.Add(item.TacGia.ToString());
                lsv.SubItems.Add(item.SoLuongCon.ToString());
                lsv.SubItems.Add(item.TheLoai.ToString());
                lsv.SubItems.Add(item.NhaXuatBan.ToString());
                lvSearch.Items.Add(lsv);
            }
            taohang();

        }

        void SearchByMaSach(string key)
        {
            lvSearch.Columns.Clear();
            lvSearch.Items.Clear();
            SearchDAO search = new SearchDAO();
            List<SearchBook> list = search.GetListBookByMaSach(key);
            addColumnBook();
            foreach (SearchBook item in list)
            {
                ListViewItem lsv = new ListViewItem(item.MaSach.ToString());
                lsv.SubItems.Add(item.NhanDe.ToString());
                lsv.SubItems.Add(item.TacGia.ToString());
                lsv.SubItems.Add(item.SoLuongCon.ToString());
                lsv.SubItems.Add(item.TheLoai.ToString());
                lsv.SubItems.Add(item.NhaXuatBan.ToString());
                lvSearch.Items.Add(lsv);
            }
            taohang();
        }


        void SearchByTacGia(string key)
        {
            lvSearch.Columns.Clear();
            lvSearch.Items.Clear();
            SearchDAO search = new SearchDAO();
            List<SearchBook> list = search.GetListBookByTacGia(key);
            addColumnBook();
            foreach (SearchBook item in list)
            {
                ListViewItem lsv = new ListViewItem(item.MaSach.ToString());
                lsv.SubItems.Add(item.NhanDe.ToString());
                lsv.SubItems.Add(item.TacGia.ToString());
                lsv.SubItems.Add(item.SoLuongCon.ToString());
                lsv.SubItems.Add(item.TheLoai.ToString());
                lsv.SubItems.Add(item.NhaXuatBan.ToString());
                lvSearch.Items.Add(lsv);
            }
            taohang();
        }

        void SearchByTheLoai(string key)
        {
            lvSearch.Columns.Clear();
            lvSearch.Items.Clear();
            SearchDAO search = new SearchDAO();
            List<SearchBook> list = search.GetListBookByTheLoai(key);
            addColumnBook();
            foreach (SearchBook item in list)
            {
                ListViewItem lsv = new ListViewItem(item.MaSach.ToString());
                lsv.SubItems.Add(item.NhanDe.ToString());
                lsv.SubItems.Add(item.TacGia.ToString());
                lsv.SubItems.Add(item.SoLuongCon.ToString());
                lsv.SubItems.Add(item.TheLoai.ToString());
                lsv.SubItems.Add(item.NhaXuatBan.ToString());
                lvSearch.Items.Add(lsv);
            }
            taohang();
            
        }

        void SearchByMaDG(string madg)
        {
            PhieuMuonDAO pm = new PhieuMuonDAO();
            addColumPhieuMuon();
            List<PhieuMuon> list = pm.GetListPhieuMuonByMaDG(madg);
            foreach (PhieuMuon item in list)
            {
               
                ListViewItem lsv = new ListViewItem(item.MaPhieuMuon.ToString());
                
                lsv.SubItems.Add(item.MaDG.ToString());
                lsv.SubItems.Add(item.MaSach.ToString());
                lsv.SubItems.Add(item.SoLuong.ToString());
                lsv.SubItems.Add(item.NgayMuon.ToString());
                lsv.SubItems.Add(item.NgayTra.ToString());
                
                lvSearch.Items.Add(lsv);
            }
            taohang();
           
        }

        void SearchByMaSV(string masv)
        {
            PhieuMuonDAO pm = new PhieuMuonDAO();
            addColumPhieuMuon();
            List<PhieuMuon> list = pm.GetListPhieuMuonByMaSV(masv);
            foreach (PhieuMuon item in list)
            {

                ListViewItem lsv = new ListViewItem(item.MaPhieuMuon.ToString());

                lsv.SubItems.Add(item.MaDG.ToString());
                lsv.SubItems.Add(item.MaSach.ToString());
                lsv.SubItems.Add(item.SoLuong.ToString());
                lsv.SubItems.Add(item.NgayMuon.ToString());
                lsv.SubItems.Add(item.NgayTra.ToString());
                lvSearch.Items.Add(lsv);
            }
            taohang();

        }
        void showw()
        {
            
        }

        #endregion

        #region event
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.ShowDialog();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (LoginAcc == null)
            {

                fLogin f = new fLogin();
                f.Show();
               
            }
            else
            {
                fMuonTra f = new fMuonTra(LoginAcc);
                f.ShowDialog();
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (LoginAcc == null)
            {
                fLogin f = new fLogin();
                
                f.Show();
            }
            else
            {
                
                fAdmin f = new fAdmin();
                f.ShowDialog();
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            
            f.Show();
            this.Hide();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            if (rabBookName.Checked == true)
            {
                SearchByNhanDe(txtSearchBook.Text);
               
            }
            if (rabBookCode.Checked == true)
            {
                SearchByMaSach(txtSearchBook.Text);
            }
            if (rabTG.Checked == true)
            {
                SearchByTacGia(txtSearchBook.Text);
            }
            if (rabTheLoai.Checked == true)
            {
                SearchByTheLoai(txtSearchBook.Text);
            }
            
        }

        private void btnSearchPeople_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            lvSearch.Columns.Clear();
            lvSearch.Items.Clear();
            if (radMaDG.Checked == true)
            {
                SearchByMaDG(txtSearchPeople.Text);
                DocGiaDAO dg = new DocGiaDAO();
                DocGia docgia = dg.GetNameDG(txtSearchPeople.Text);
                txtName.Text = docgia.HoTen;
            }
            if (rabMaSV.Checked == true)
            {
                DocGiaDAO dg = new DocGiaDAO();
                DocGia docgia = dg.GetNameDGByMsv(txtSearchPeople.Text);
                txtName.Text = docgia.HoTen;
                SearchByMaSV(txtSearchPeople.Text);

            }
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyAccount f = new fQuanLyAccount(LoginAcc);
            f.ShowDialog();
        }

        private void fManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }





        #endregion

        private void lvSearch_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string m = "";
            
            foreach (ListViewItem items in lvSearch.SelectedItems)
            {
                m = items.SubItems[1].Text;
            }
            //if (m != "")
                
        }
    }
}
