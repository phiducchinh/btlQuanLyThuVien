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
    public partial class fMuonTra : Form
    {
        BindingSource listMuon = new BindingSource();
        BindingSource listTK = new BindingSource();


        private Account loginAccount;
        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }

            set
            {
                loginAccount = value;

            }
        }

        public fMuonTra(Account acc)
        {
            
            this.LoginAccount = acc;
            InitializeComponent();
            Loadtt();
        }


        #region method
        void Loadtt()
        {
            dgvMuon.DataSource = listMuon;
            dgvThongKe.DataSource = listTK;
            ShowMuon();
            BindingTTPhieuMuon();
            addMaDGToCB();
            addMaSachToCB();
            showTkMuonAll();
            BindingTK();
        }

        void ShowMuon()
        {
            PhieuMuonDAO pm = new PhieuMuonDAO();
            listMuon.DataSource = pm.GetListPhieuMuon();
        }

        void BindingTTPhieuMuon()
        {
            txtMaSachMuon.DataBindings.Add(new Binding("Text", dgvMuon.DataSource, "MaSach", true, DataSourceUpdateMode.Never));
            txtMaPhieuMuon.DataBindings.Add(new Binding("Text", dgvMuon.DataSource, "MaPhieuMuon", true, DataSourceUpdateMode.Never));
            txtCTMaPhieuMuon.DataBindings.Add(new Binding("Text", dgvMuon.DataSource, "MaPhieuMuon", true, DataSourceUpdateMode.Never));
            numSLMuon.DataBindings.Add(new Binding("Value", dgvMuon.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
            txtSLMuon.DataBindings.Add(new Binding("Text", dgvMuon.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));

        }

        void BindingTK()
        {
            txtMaSachTk.DataBindings.Add(new Binding("Text", listTK, "MaSach", true, DataSourceUpdateMode.Never));
            txtMaDGTk.DataBindings.Add(new Binding("Text", listTK, "MaDG", true, DataSourceUpdateMode.Never));
            txtMaPMTK.DataBindings.Add(new Binding("Text", listTK, "MaPhieuMuon", true, DataSourceUpdateMode.Never));
            dtNgayMuontk.DataBindings.Add(new Binding("Value", listTK, "NgayMuon", true, DataSourceUpdateMode.Never));
            dtNgayTratk.DataBindings.Add(new Binding("Value", listTK, "NgayTra", true, DataSourceUpdateMode.Never));
            txtSLTK.DataBindings.Add(new Binding("Text", listTK, "SoLuong", true, DataSourceUpdateMode.Never));

        }

        void addMaSachToCB()
        {
            BookDAO book = new BookDAO();
            cbMaSachMuon.DataSource = book.GetListBook();
            cbMaSachMuon.DisplayMember = "MaSach";

        }

        void addMaDGToCB()
        {
            DocGiaDAO dg = new DocGiaDAO();
            cbMaDGMuon.DataSource = dg.GetListDocGia();
            cbMaDGMuon.DisplayMember = "MaDG";
        }

        void LoadTimeMuon()
        {
            DateTime today = DateTime.Now;
            dateTimeCTMuonMuon.Value = today;
            dateTimeCTTraMuon.Value = today.AddMonths(3);
        }

        string TaoMoiMaPhieu()
        {
            PhieuMuonDAO pm = new PhieuMuonDAO();
            string old = pm.GetMaxMaPhieu();
            old = old.TrimStart('P');
            int newCode = int.Parse(old);
            newCode += 1;
            string code = "P";
            if (newCode < 10)
            {
                code = code + "00" + newCode;
            }
            else if (newCode < 100)
            {
                code = code + "0" + newCode;
            }
            else
            {
                code = code + newCode;
            }
            return code;
        }

        void showTkMuonAll()
        {
            PhieuMuonDAO pm = new PhieuMuonDAO();
            listTK.DataSource = pm.GetListPhieuMuonbyPage(1, 0);
            string query = "Select count(*) from PhieuMuon Where TrangThaiTong=0";
            DateTime dt = DateTime.Now;
            string query1 = "Select count(*) from PhieuMuon Where TrangThaiTong=0 and NgayTra < '" + dt.ToString() + "'";
            int sodongquahan = pm.GetSoLuong(query1);
            int sodong = pm.GetSoLuong(query);
            thanhtrangthai.Items[0].Text += sodong.ToString();
            thanhtrangthai.Items[1].Text += sodongquahan.ToString();

            foreach (DataGridViewRow row in dgvThongKe.Rows)
                
                if (row.Cells[7].Value.ToString()=="Quá hạn")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
        }

        



        int PhanTrang()
        {
            PhieuMuonDAO pm = new PhieuMuonDAO();
            int sodong = 0;
            
                if (ckhQuaHan.Checked == false)
                {
                    string query = "Select count(*) from PhieuMuon Where TrangThaiTong=0";
                    sodong = pm.GetSoLuong(query);
                }else if (ckhQuaHan.Checked == true)
                {
                    DateTime dt = DateTime.Now;
                    string query = "Select count(*) from PhieuMuon Where TrangThaiTong=0 and NgayTra < '"+dt.ToString()+"'";
                    sodong = pm.GetSoLuong(query);
                }
           
            
            int sotrang = sodong / 10;
            if (sodong % 10 != 0)
            {
                sotrang += 1;

            }
            return sotrang;
        }



        #endregion

        #region event

        private void txtMaSachMuon_TextChanged(object sender, EventArgs e)
        {
            string masach = txtMaSachMuon.Text;
            BookDAO b = new BookDAO();
            Book book = b.GetBookByMaSach(masach);
            txtNXBMuon.Text = book.NhaXB;
            txtTenSachMuon.Text = book.NhanDe;
            txtTacGiaMuon.Text = book.TacGia;
        }

        private void btnTaoMoiPhieuMuon_Click(object sender, EventArgs e)
        {
            btnMuon.Enabled = true;
            btnTra.Enabled = false;
            btnGiaHan.Enabled = false;
            LoadTimeMuon();
            txtMaPhieuMuon.Text = TaoMoiMaPhieu();
            txtCTMaPhieuMuon.Text = txtMaPhieuMuon.Text;
            panel3.Enabled = false;

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            btnMuon.Enabled = false;
            btnTra.Enabled = true;
            btnGiaHan.Enabled = true;
            panel3.Enabled = true;
            PhieuMuonDAO pm = new PhieuMuonDAO();
            string maphieumuon = txtCTMaPhieuMuon.Text;
            string madg = (cbMaDGMuon.SelectedItem as DocGia).MaDG;
            DateTime ngaymuon = dateTimeCTMuonMuon.Value;
            DateTime ngaytra = dateTimeCTTraMuon.Value;
            string manhanvien = LoginAccount.MaNhanVien;
            int trangthai = 0;
            string masach = (cbMaSachMuon.SelectedItem as Book).MaSach;
            int soluong = (int)numSLMuon.Value;

            BookDAO book = new BookDAO();
            if (book.CheckBookNumberByMaSach(masach) < soluong)
            {
                MessageBox.Show("Sách không đủ");
            }
            else
            {
                if (pm.InsertPhieuMuon(maphieumuon, madg, ngaymuon, ngaytra, manhanvien, trangthai, masach, soluong))
                {
                    MessageBox.Show("Thêm Thành công");
                    ShowMuon();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
            }

        }

        private void txtCTMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PhieuMuonDAO pm = new PhieuMuonDAO();
                DateTime dt = new DateTime();
                dt = pm.GetTimeNgayMuonByMaPhieu(txtCTMaPhieuMuon.Text);
                dateTimeCTMuonMuon.Value = dt;
                dt = pm.GetTimeNgayTraByMaPhieu(txtCTMaPhieuMuon.Text);
                dateTimeCTTraMuon.Value = dt;
            }
            catch
            {

            }

        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            string maphieu = txtCTMaPhieuMuon.Text;
            DateTime giahan = dateTimeCTTraMuon.Value.AddMonths(1);

            if (MessageBox.Show(string.Format("Bạn có muốn Gia hạn thêm cho Mã phiếu: {0} đến ngày: {1}", maphieu, giahan.ToString()), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                PhieuMuonDAO pm = new PhieuMuonDAO();
                if (pm.GiaHan(maphieu, giahan))
                {
                    MessageBox.Show("Gia Hạn thành công");
                    ShowMuon();
                }
                else
                {
                    MessageBox.Show("Gia hạn không thành công");
                }
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            string maphieu = txtCTMaPhieuMuon.Text;
            string madg = (cbMaDGMuon.SelectedItem as DocGia).MaDG;
            int soluong = (int) numSLMuon.Value;
            string masach = txtMaSachMuon.Text;
            PhieuMuonDAO pm = new PhieuMuonDAO();
            if(MessageBox.Show(string.Format("Bạn có muốn trả cuốn sách: {0} của độc giả: {1} ,SL:{2}",masach,madg,soluong.ToString()),"Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (pm.TraSach(masach, maphieu, soluong))
                {
                    MessageBox.Show("Trả thành công");
                    ShowMuon();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi trả");
                }
            }
        }

        private void txtMaPhieuMuon_TextChanged(object sender, EventArgs e)
        {
            string madg = dgvMuon.SelectedCells[0].OwningRow.Cells["MaDG"].Value.ToString();
            int i = 0;
            int index = -1;
            foreach (DocGia item in cbMaDGMuon.Items)
            {
                if (item.MaDG == madg)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbMaDGMuon.SelectedIndex = index;
        }

        private void txtSearchMuon_TextChanged(object sender, EventArgs e)
        {
            PhieuMuonDAO pm = new PhieuMuonDAO();
            if (radMaDGMuon.Checked == true)
            {
                dgvMuon.DataSource = pm.GetListPhieuMuonByMaDG(txtSearchMuon.Text);
            }
            if (radMaPhieuMuon.Checked == true)
            {
                dgvMuon.DataSource = pm.GetListPhieuMuonByMaPhieu(txtSearchMuon.Text);
            }
            
               
        }

        private void ckbChuaTra_CheckedChanged(object sender, EventArgs e)
        {
            txtPage.Text = "1";

            PhieuMuonDAO pm = new PhieuMuonDAO();
            if (ckhQuaHan.Checked == false)
            {
                listTK.DataSource = pm.GetListPhieuMuonbyPage(1, 0);
            }
            else if (ckhQuaHan.Checked == true)
            {
                listTK.DataSource = pm.GetListPhieuMuonbyPage(1, 1);

            }


        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            txtPage.Text = "1";
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            int LastPage = PhanTrang();
            txtPage.Text = LastPage.ToString();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            int nowPage = int.Parse(txtPage.Text);
            if (nowPage > 1)
            {
                nowPage -= 1;
                txtPage.Text = nowPage.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int nowPage = int.Parse(txtPage.Text);

            int LastPage = PhanTrang();

            if (nowPage < LastPage)
            {
                nowPage += 1;
                txtPage.Text = nowPage.ToString();
            }

        }


        private void txtPage_TextChanged(object sender, EventArgs e)
        {

            PhieuMuonDAO pm = new PhieuMuonDAO();
            if (ckhQuaHan.Checked == false)
            {
                PhanTrang();
                int nowPage = int.Parse(txtPage.Text);
                listTK.DataSource = pm.GetListPhieuMuonbyPage(nowPage, 0);
            }
            else if (ckhQuaHan.Checked == true)
            {
                PhanTrang();
                int nowPage = int.Parse(txtPage.Text);
                listTK.DataSource = pm.GetListPhieuMuonbyPage(nowPage, 1);
            }

        }

        private void txtMaSachTk_TextChanged(object sender, EventArgs e)
        {
            BookDAO book = new BookDAO();
            Book b = book.GetBookByMaSach(txtMaSachTk.Text);
            txtTenSachTk.Text = b.NhanDe;
            txtTenTGTK.Text = b.TacGia;
            txtNXBTK.Text = b.NhaXB;
        }

        private void txtMaDGTk_TextChanged(object sender, EventArgs e)
        {
            DocGiaDAO dg = new DocGiaDAO();
            DocGia d = dg.GetNameDG(txtMaDGTk.Text);
            txtTenDGtk.Text = d.HoTen;
            txtMsvtk.Text = d.MaSV.ToString();
        }

        private void dgvThongKe_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvThongKe.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dgvThongKe.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            if (dgvThongKe.Rows[e.RowIndex].Cells[7].Value.ToString() == "Quá hạn")
            {
                dgvThongKe.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }


        }

        private void dgvMuon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvMuon.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dgvMuon.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        #endregion


    }
}
