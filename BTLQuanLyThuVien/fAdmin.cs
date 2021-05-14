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
    public partial class fAdmin : Form
    {
        BindingSource bookList = new BindingSource();
        BindingSource docgiaList = new BindingSource();
        BindingSource nhanvienList = new BindingSource();
        BindingSource nnList = new BindingSource();
        BindingSource tlList = new BindingSource();


        public fAdmin()
        {
            InitializeComponent();
            show();
        }
        #region method

        void show()
        {
            dgvBook.DataSource = bookList;
            dgvDocGia.DataSource = docgiaList;
            dgvNhanVien.DataSource = nhanvienList;
            dgvNN.DataSource = nnList;
            dgvTL.DataSource = tlList;
            ShowBook();
            ShowDG();
            AddBindingBook();
            AddBindDG();
            LoadCbPhanLoai();
            LoadCbNgonNgu();
            ShowNhanVien();
            AddBindingNV();
            ShowPL();
            ShowNN();
            AddBindingNN();
            AddBindingTL();
        }

        void ShowDG()
        {
            DocGiaDAO dg = new DocGiaDAO();
            docgiaList.DataSource = dg.GetListDocGia();
        }

        void ShowBook()
        {
            BookDAO book = new BookDAO();
            bookList.DataSource= book.GetListBook();
            
        }

        void AddBindingBook()
        {
            txtMaSach.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "MaSach", true, DataSourceUpdateMode.Never));
            txtNhanDe.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "NhanDe", true, DataSourceUpdateMode.Never));
            txtTacGia.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "TacGia", true, DataSourceUpdateMode.Never));
            txtSLMuon.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "SoLanMuon", true, DataSourceUpdateMode.Never));
            numSLCon.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "SoLuongCon", true, DataSourceUpdateMode.Never));
            numSoTrang.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "SoTrang", true, DataSourceUpdateMode.Never));
            numSLTong.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "SoLuongTong", true, DataSourceUpdateMode.Never));
            txtNhaXB.DataBindings.Add(new Binding("Text", dgvBook.DataSource, "NhaXB", true, DataSourceUpdateMode.Never));
            numLanXB.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "LanXB", true, DataSourceUpdateMode.Never));
            numNamXB.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "NamXB", true, DataSourceUpdateMode.Never));
            dateTimeNgayNhap.DataBindings.Add(new Binding("Value", dgvBook.DataSource, "NgayNhap", true, DataSourceUpdateMode.Never));
        }

        void AddBindDG()
        {

            txtMaDG.DataBindings.Add(new Binding("Text", dgvDocGia.DataSource, "MaDG", true, DataSourceUpdateMode.Never));
            txtTenDG.DataBindings.Add(new Binding("Text", dgvDocGia.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtMsv.DataBindings.Add(new Binding("Text", dgvDocGia.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
            txtDC.DataBindings.Add(new Binding("Text", dgvDocGia.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtTenKhoa.DataBindings.Add(new Binding("Text", dgvDocGia.DataSource, "TenKhoa", true, DataSourceUpdateMode.Never));

        }

        void AddBindingNV()
        {
            txtMaNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "MaNhanVien", true, DataSourceUpdateMode.Never));
            txtHoTenNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            txtDCNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtUsername.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            

         }

        void AddBindingNN()
        {
            txtMaNN.DataBindings.Add(new Binding("Text", dgvNN.DataSource, "MaNgonNgu", true, DataSourceUpdateMode.Never));
            txtTenNN.DataBindings.Add(new Binding("Text", dgvNN.DataSource, "TenNgonNgu", true, DataSourceUpdateMode.Never));

        }

        void AddBindingTL()
        {
            txtMaTL.DataBindings.Add(new Binding("Text", dgvTL.DataSource, "MaLoai", true, DataSourceUpdateMode.Never));
            txtTenTL.DataBindings.Add(new Binding("Text", dgvTL.DataSource, "TenLoai", true, DataSourceUpdateMode.Never));

        }

        void LoadCbPhanLoai()
        {
            PhanLoaiDAO phanloai = new PhanLoaiDAO();
            cbTheLoai.DataSource = phanloai.GetListPhanLoai();
            cbTheLoai.DisplayMember = "TenLoai";
        }

        void LoadCbNgonNgu()
        {
            NgonNguDAO nn = new NgonNguDAO();
            cbNgonNgu.DataSource = nn.GetListNgonNgu();
            cbNgonNgu.DisplayMember = "TenNgonNgu";
        }

        List<Book> SearchByNhanDe(string nhande)
        {
            BookDAO book = new BookDAO();
            List<Book> list = new List<Book>();
            list = book.GetListBookByNhanDe(nhande);
            return list;
        }

        List<Book> SearchByMaSach(string masach)
        {
            BookDAO book = new BookDAO();
            List<Book> list = new List<Book>();
            list = book.GetListBookByMaSach(masach);
            return list;
        }

        List<Book> SearchByTacGia(string tacgia)
        {
            BookDAO book = new BookDAO();
            List<Book> list = new List<Book>();
            list = book.GetListBookByTacGia(tacgia);
            return list;
        }

        List<Book> SearchByTheLoai(string TheLoai)
        {
            BookDAO book = new BookDAO();
            List<Book> list = new List<Book>();
            list = book.GetListBookByTheLoai(TheLoai);
            return list;
        }

        string TaoMaSachMoi()
        {
            BookDAO book = new BookDAO();
            string old = book.getMaxMaSach();
            old = old.TrimStart('M');
            int newCode= int.Parse(old);
            newCode += 1;
            string code = "M";
            if (newCode < 10)
            {
                code = code + "00" + newCode;
            }else if (newCode < 100)
            {
                code = code + "0" + newCode;
            }
            else
            {
                code = code + newCode;
            }
            return code;
        }

        string TaoMaDGMoi()
        {
            DocGiaDAO book = new DocGiaDAO();
            string old = book.getMaxMaDG();
            old = old.TrimStart('D');
            old = old.TrimStart('G');
            int newCode = int.Parse(old);
            newCode += 1;
            string code = "DG";
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

        string TaoMaNV()
        {
            NhanVienDAO nv = new NhanVienDAO();
            string old = nv.GetMaNVMax();
            old = old.TrimStart('N');
            old = old.TrimStart('V');
            int newCode = int.Parse(old);
            newCode += 1;
            string code = "NV";
            if (newCode < 10)
            {
                code = code + "0" + newCode;
            }
            else
            {
                code = code + newCode;
            }
            return code;
        }

        string TaoMaNN()
        {
            NgonNguDAO nv = new NgonNguDAO();
            string old = nv.GetMaxMaNN();
            old = old.TrimStart('N');
            old = old.TrimStart('N');
            int newCode = int.Parse(old);
            newCode += 1;
            string code = "NN";
            if (newCode < 10)
            {
                code = code + "0" + newCode;
            }
            else
            {
                code = code + newCode;
            }
            return code;
        }

        string TaoMaPL()
        {
            PhanLoaiDAO nv = new PhanLoaiDAO();
            string old = nv.GetMaxMaPL();
            
            old = old.TrimStart('L');
           
            int newCode = int.Parse(old);
            newCode += 1;
            string code = "L";
            if (newCode < 10)
            {
                code = code + "0" + newCode;
            }
            else
            {
                code = code + newCode;
            }
            return code;
        }

        void ShowNhanVien()
        {
            NhanVienDAO nhanvien = new NhanVienDAO();
            nhanvienList.DataSource = nhanvien.GetListNhanVien();
            LoginDAO lg = new LoginDAO();
            cbQH.DataSource = lg.GetListAccount();
            cbQH.DisplayMember = "QuyenHan";
        }

        void ShowNN()
        {
            NgonNguDAO n = new NgonNguDAO();
            nnList.DataSource = n.GetListNgonNgu();
            dgvNN.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        void ShowPL()
        {
            PhanLoaiDAO p = new PhanLoaiDAO();
            tlList.DataSource = p.GetListPhanLoai();
            dgvTL.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        
        #endregion

        #region event
        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowBook();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            BookDAO book = new BookDAO();
            string MaSach = txtMaSach.Text;
            if (book.DeleteBook(MaSach))
            {
                MessageBox.Show("Xóa thành công");
                ShowBook();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookDAO book = new BookDAO();
            string MaSach = TaoMaSachMoi();
            string nhande = txtNhanDe.Text;
            string tacgia = txtTacGia.Text;
            int sotrang = (int) numSoTrang.Value;
            int soluongcon = (int)numSLCon.Value;
            int soluongtong = (int)numSLTong.Value;
            int namxb = (int)numNamXB.Value;
            int lanxb = (int)numLanXB.Value;
            string nhaxuatban = txtNhaXB.Text;
            int solanmuon = int.Parse(txtSLMuon.Text);
            string maloai = (cbTheLoai.SelectedItem as PhanLoai).MaLoai;
            DateTime ngaynhap = dateTimeNgayNhap.Value;
            string mangonngu = (cbNgonNgu.SelectedItem as NgonNgu).MaNgonNgu;

            if(book.InsertBook(MaSach, nhande, tacgia, sotrang, soluongtong, soluongcon, namxb, lanxb, nhaxuatban, solanmuon, maloai, ngaynhap, mangonngu))
            {
                MessageBox.Show("Thêm thành công");
                ShowBook();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm ");
            }
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string MaSach = dgvBook.SelectedCells[0].OwningRow.Cells["MaSach"].Value.ToString();
                PhanLoaiDAO phanloai = new PhanLoaiDAO();
                PhanLoai pl = phanloai.GetListPhanLoaiByMaSach(txtMaSach.Text);
                int index = -1;
                int i = 0;
                foreach(PhanLoai item in cbTheLoai.Items)
                {
                    if (item.MaLoai == pl.MaLoai)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbTheLoai.SelectedIndex = index;

                NgonNguDAO nn = new NgonNguDAO();
                NgonNgu ngonNgu = nn.GetListNgonNguByMaSach(txtMaSach.Text);
                int index1 = -1;
                int j = 0;
                foreach (NgonNgu item in cbNgonNgu.Items)
                {
                    if (item.MaNgonNgu == ngonNgu.MaNgonNgu)
                    {
                        index1 = j;
                        break;
                    }
                    j++;
                }
                cbNgonNgu.SelectedIndex = index1;

            }
            catch
            {

            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (rabBookName.Checked == true)
            {
                bookList.DataSource = SearchByNhanDe(txtSearchBook.Text);   
            }
            if (rabBookCode.Checked == true)
            {
                bookList.DataSource = SearchByMaSach(txtSearchBook.Text);
            }
            if (rabTG.Checked == true)
            {
                bookList.DataSource = SearchByTacGia(txtSearchBook.Text);

            }
            if (rabTheLoai.Checked == true)
            {
                bookList.DataSource = SearchByTheLoai(txtSearchBook.Text);

            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            BookDAO book = new BookDAO();
            string MaSach = txtMaSach.Text;
            string nhande = txtNhanDe.Text;
            string tacgia = txtTacGia.Text;
            int sotrang = (int)numSoTrang.Value;
            int soluongcon = (int)numSLCon.Value;
            int soluongtong = (int)numSLTong.Value;
            int namxb = (int)numNamXB.Value;
            int lanxb = (int)numLanXB.Value;
            string nhaxuatban = txtNhaXB.Text;
            int solanmuon = int.Parse(txtSLMuon.Text);
            string maloai = (cbTheLoai.SelectedItem as PhanLoai).MaLoai;
            DateTime ngaynhap = dateTimeNgayNhap.Value;
            string mangonngu = (cbNgonNgu.SelectedItem as NgonNgu).MaNgonNgu;
            
            
            string query = "Update Sach SET NhanDe = N'" + nhande + "', TacGia=N'" + tacgia + "', SoTrang=" + sotrang + ", SoLuongTong=" + soluongtong + ", SoLuongCon=" + soluongcon + ", NamSX=" + namxb + ", LanXB=" + lanxb + ", NhaXuatBan=N'" + nhaxuatban + "', SolanMuon=" + solanmuon + ", MaLoai='" + maloai + "', NgayNhap='" + ngaynhap + "', MaNgonNgu='" + mangonngu + "' where MaSach='" + MaSach + "'";

            DataProvider dataP = new DataProvider();
            int data = dataP.ExecuteNonQuery(query);
            
             
            if (data>0)
            {
                MessageBox.Show("Sửa thành công");
                ShowBook();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Sửa");
            }
            
        }

        private void btnViewDG_Click(object sender, EventArgs e)
        {
            ShowDG();
        }

        private void btnAddDG_Click(object sender, EventArgs e)
        {
            string madg = TaoMaDGMoi();
            string hoten = txtTenDG.Text;
            int masv = int.Parse(txtMsv.Text);
            string tenkhoa = txtTenKhoa.Text;
            DateTime ngaysinh = dateTimeNgaySinhDG.Value;
            string diachi = txtDC.Text;
            DateTime ngaylapthe = dateTimeNgayLT.Value;

            DocGiaDAO dg = new DocGiaDAO();
            if (dg.InsertDG(madg, hoten, masv, ngaysinh, tenkhoa, diachi, ngaylapthe))
            {
                MessageBox.Show("Thêm độc giả thành công");
                ShowDG();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dộc giả");
            }
            
        }

        private void btnEditDG_Click(object sender, EventArgs e)
        {
            string madg = txtMaDG.Text;
            string hoten = txtTenDG.Text;
            int masv = int.Parse(txtMsv.Text);
            string tenkhoa = txtTenKhoa.Text;
            DateTime ngaysinh = dateTimeNgaySinhDG.Value;
            string diachi = txtDC.Text;
            DateTime ngaylapthe = dateTimeNgayLT.Value;

            DocGiaDAO dg = new DocGiaDAO();
            if (dg.EditDG(madg, hoten, masv, ngaysinh, tenkhoa, diachi, ngaylapthe))
            {
                MessageBox.Show("Sửa độc giả thành công");
                ShowDG();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dộc giả");
            }
        }

        private void btnDeleteDG_Click(object sender, EventArgs e)
        {
            string madg = txtMaDG.Text;
            DocGiaDAO dg = new DocGiaDAO();
            if (dg.DeleteDG(madg))
            {
                MessageBox.Show("Xóa độc giả thành công");
                ShowDG();
            }
            else
            {
                MessageBox.Show("có lỗi khi xóa dộc giả");
            }
            

        }

        private void txtSerchDG_TextChanged(object sender, EventArgs e)
        {
            if (rabMaDG.Checked == true)
            {
                DocGiaDAO dg = new DocGiaDAO();
                docgiaList.DataSource = dg.GetListDGByMaDG(txtSerchDG.Text);
            }
            if (rabMaSV.Checked == true)
            {
                DocGiaDAO dg = new DocGiaDAO();
                docgiaList.DataSource = dg.GetListDGByMaSV(txtSerchDG.Text);
            }
        }

        private void txtMaDG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaysinh = (DateTime)dgvDocGia.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value;
                dateTimeNgaySinhDG.Value = ngaysinh;

                DateTime ngaylt = (DateTime)dgvDocGia.SelectedCells[0].OwningRow.Cells["NgayLapThe"].Value;
                dateTimeNgayLT.Value = ngaylt;
            }
            catch
            {

            }
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                LoginDAO acc = new LoginDAO();


                string qh = dgvNhanVien.SelectedCells[0].OwningRow.Cells["QuyenHan"].Value.ToString();


                Account now = acc.GetAccountByUserName(txtUsername.Text);
                int index = -1;
                int i = 0;

                foreach (Account item in cbQH.Items)
                {
                    if (item.QuyenHan == qh)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbQH.SelectedIndex = index;
            }

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            
            string manv = TaoMaNV();
            string hoten = txtHoTenNV.Text;
            string diachi = txtDCNV.Text;
            string username = txtUsername.Text;
            int quyenhan = 0;
            if((cbQH.SelectedItem as Account).QuyenHan=="Thủ thư")
            {
                quyenhan = 1;
            }
            NhanVienDAO nv = new NhanVienDAO();
            if (nv.InsertNhanVien(manv, hoten, diachi, username, quyenhan))
            {
                MessageBox.Show("Thêm Nhân viên thành công ");
                ShowNhanVien();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm nhân viên");
            }
            
        }

        private void XoaNV_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            PhieuMuonDAO pm = new PhieuMuonDAO();
            NhanVienDAO nv = new NhanVienDAO();
            pm.DeletePhieuMuonByMaNV(manv);
            if (nv.DeleteNhanVien(manv))
            {
                MessageBox.Show("Xóa thành công");
                ShowNhanVien();
            }
            else
            {
                MessageBox.Show("có lỗi khi xóa nv");
            }

           
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            
            NhanVienDAO nv = new NhanVienDAO();
            string hoten = txtHoTenNV.Text;
            string dc = txtDCNV.Text;
            int quyenhan = 0;
            string manv=txtMaNV.Text;
            if ((cbQH.SelectedItem as Account).QuyenHan == "Thủ thư")
            {
                quyenhan = 1;
            }
            if (nv.UpdateNhanVien(manv, hoten, dc, quyenhan))
            {
                MessageBox.Show("Sửa thành công");
                ShowNhanVien();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
            
        }

        private void btnAddTL_Click(object sender, EventArgs e)
        {
            string matl = TaoMaPL();
            string tentl = txtTenTL.Text;
            
            
            PhanLoaiDAO pl = new PhanLoaiDAO();
            if (pl.InsertNgonNgu(matl, tentl))
            {
                MessageBox.Show("Thêm Thể loại thành công");
                ShowPL();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btnUpdateTL_Click(object sender, EventArgs e)
        {
            string matl = txtMaTL.Text;
            string tentl = txtTenTL.Text;
            PhanLoaiDAO pl = new PhanLoaiDAO();
            if (pl.EditNgonNgu(matl, tentl))
            {
                MessageBox.Show("Sửa Thể loại thành công");
                ShowPL();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btnDeleteTL_Click(object sender, EventArgs e)
        {
            string matl = txtMaTL.Text;
            string tentl = txtTenTL.Text;
            PhanLoaiDAO pl = new PhanLoaiDAO();
            if (pl.DeleteNgonNgu(matl))
            {
                MessageBox.Show("Xóa Thể loại thành công");
                ShowPL();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btnAddNN_Click(object sender, EventArgs e)
        {
            string mann = TaoMaNN();
            string tennn = txtTenNN.Text;
            NgonNguDAO pl = new NgonNguDAO();
            if (pl.InsertNgonNgu(mann, tennn))
            {
                MessageBox.Show("Thêm Ngôn ngữ thành công");
                ShowNN();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btnEditNN_Click(object sender, EventArgs e)
        {
            string mann = txtMaNN.Text;
            string tennn = txtTenNN.Text;
            NgonNguDAO pl = new NgonNguDAO();
            if (pl.EditNgonNgu(mann, tennn))
            {
                MessageBox.Show("Sửa Ngôn ngữ thành công");
                ShowNN();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void btnDeleteNN_Click(object sender, EventArgs e)
        {
            string mann = txtMaNN.Text;
            string tennn = txtTenNN.Text;
            NgonNguDAO pl = new NgonNguDAO();
            if (pl.DeleteNgonNgu(mann))
            {
                MessageBox.Show("Xóa Ngôn ngữ thành công");
                ShowNN();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void txtSearchTLorNN_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearchTLorNN.Text;
            if (radMaTL.Checked == true)
            {

                PhanLoaiDAO pl = new PhanLoaiDAO();
                tlList.DataSource = pl.SearchPhanLoai(key);
            }
            if (radMaNN.Checked == true)
            {
                NgonNguDAO nn = new NgonNguDAO();
                nnList.DataSource = nn.searchNgonNgu(key);
            }
        }

        private void txtSearchNV_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearchNV.Text;
            NhanVienDAO nd = new NhanVienDAO();

            if (radManvv.Checked == true)
            {
                nhanvienList.DataSource = nd.SearchListNhanVienByMaNV(key);
            }
            if (radTennvv.Checked == true)
            {
                nhanvienList.DataSource = nd.SearchListNhanVienByTenNV(key);
            }
            int check = dgvNhanVien.RowCount;
            txtSearchNV.Tag = check;

        }




        #endregion

        private void dgvBook_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvBook.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dgvBook.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void dgvDocGia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvDocGia.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dgvDocGia.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvNhanVien.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dgvNhanVien.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username= txtUsername.Text;
            DialogResult d = MessageBox.Show("Bạn có muốn reset mật khẩu cho tk: "+username, "Thông báo", MessageBoxButtons.OKCancel);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                LoginDAO l = new LoginDAO();
                if (l.DoiMatKhauAdmin(username))
                {
                    MessageBox.Show("Đổi mk thành công");
                }
                else
                {
                    MessageBox.Show("có lỗi");
                }
            }
        }
    }
    
}
