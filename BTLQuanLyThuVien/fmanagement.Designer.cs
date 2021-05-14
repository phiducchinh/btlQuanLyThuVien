namespace BTLQuanLyThuVien
{
    partial class fManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rabMaSV = new System.Windows.Forms.RadioButton();
            this.radMaDG = new System.Windows.Forms.RadioButton();
            this.btnSearchPeople = new System.Windows.Forms.Button();
            this.txtSearchPeople = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabBookCode = new System.Windows.Forms.RadioButton();
            this.rabTheLoai = new System.Windows.Forms.RadioButton();
            this.rabTG = new System.Windows.Forms.RadioButton();
            this.rabBookName = new System.Windows.Forms.RadioButton();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.lvSearch = new System.Windows.Forms.ListView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thanhtrangthai1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.thanhtrangthai1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(835, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.mượnTrảSáchToolStripMenuItem.Text = "Mượn/Trả Sách";
            this.mượnTrảSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnTrảSáchToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.adminToolStripMenuItem.Text = "Quản Lý";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // qToolStripMenuItem
            // 
            this.qToolStripMenuItem.Name = "qToolStripMenuItem";
            this.qToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.qToolStripMenuItem.Text = "Quản lý tài khoản";
            this.qToolStripMenuItem.Click += new System.EventHandler(this.qToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rabMaSV);
            this.groupBox2.Controls.Add(this.radMaDG);
            this.groupBox2.Controls.Add(this.btnSearchPeople);
            this.groupBox2.Controls.Add(this.txtSearchPeople);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(437, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 152);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu";
            // 
            // rabMaSV
            // 
            this.rabMaSV.AutoSize = true;
            this.rabMaSV.Location = new System.Drawing.Point(130, 75);
            this.rabMaSV.Name = "rabMaSV";
            this.rabMaSV.Size = new System.Drawing.Size(102, 20);
            this.rabMaSV.TabIndex = 4;
            this.rabMaSV.TabStop = true;
            this.rabMaSV.Text = "Mã Sinh viên";
            this.rabMaSV.UseVisualStyleBackColor = true;
            // 
            // radMaDG
            // 
            this.radMaDG.AutoSize = true;
            this.radMaDG.Checked = true;
            this.radMaDG.Location = new System.Drawing.Point(6, 75);
            this.radMaDG.Name = "radMaDG";
            this.radMaDG.Size = new System.Drawing.Size(94, 20);
            this.radMaDG.TabIndex = 3;
            this.radMaDG.TabStop = true;
            this.radMaDG.Text = "Mã Độc giả";
            this.radMaDG.UseVisualStyleBackColor = true;
            // 
            // btnSearchPeople
            // 
            this.btnSearchPeople.Location = new System.Drawing.Point(174, 31);
            this.btnSearchPeople.Name = "btnSearchPeople";
            this.btnSearchPeople.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPeople.TabIndex = 2;
            this.btnSearchPeople.Text = "Tìm ";
            this.btnSearchPeople.UseVisualStyleBackColor = true;
            this.btnSearchPeople.Click += new System.EventHandler(this.btnSearchPeople_Click);
            // 
            // txtSearchPeople
            // 
            this.txtSearchPeople.Location = new System.Drawing.Point(6, 31);
            this.txtSearchPeople.Name = "txtSearchPeople";
            this.txtSearchPeople.Size = new System.Drawing.Size(151, 22);
            this.txtSearchPeople.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabBookCode);
            this.groupBox1.Controls.Add(this.rabTheLoai);
            this.groupBox1.Controls.Add(this.rabTG);
            this.groupBox1.Controls.Add(this.rabBookName);
            this.groupBox1.Controls.Add(this.btnSearchBook);
            this.groupBox1.Controls.Add(this.txtSearchBook);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm ";
            // 
            // rabBookCode
            // 
            this.rabBookCode.AutoSize = true;
            this.rabBookCode.Location = new System.Drawing.Point(130, 69);
            this.rabBookCode.Name = "rabBookCode";
            this.rabBookCode.Size = new System.Drawing.Size(77, 20);
            this.rabBookCode.TabIndex = 5;
            this.rabBookCode.TabStop = true;
            this.rabBookCode.Text = "Mã sách";
            this.rabBookCode.UseVisualStyleBackColor = true;
            // 
            // rabTheLoai
            // 
            this.rabTheLoai.AutoSize = true;
            this.rabTheLoai.Location = new System.Drawing.Point(130, 110);
            this.rabTheLoai.Name = "rabTheLoai";
            this.rabTheLoai.Size = new System.Drawing.Size(96, 20);
            this.rabTheLoai.TabIndex = 4;
            this.rabTheLoai.TabStop = true;
            this.rabTheLoai.Text = "Tên thể loại";
            this.rabTheLoai.UseVisualStyleBackColor = true;
            // 
            // rabTG
            // 
            this.rabTG.AutoSize = true;
            this.rabTG.Location = new System.Drawing.Point(6, 110);
            this.rabTG.Name = "rabTG";
            this.rabTG.Size = new System.Drawing.Size(93, 20);
            this.rabTG.TabIndex = 3;
            this.rabTG.TabStop = true;
            this.rabTG.Text = "Tên tác giả";
            this.rabTG.UseVisualStyleBackColor = true;
            // 
            // rabBookName
            // 
            this.rabBookName.AutoSize = true;
            this.rabBookName.Checked = true;
            this.rabBookName.Location = new System.Drawing.Point(6, 69);
            this.rabBookName.Name = "rabBookName";
            this.rabBookName.Size = new System.Drawing.Size(82, 20);
            this.rabBookName.TabIndex = 2;
            this.rabBookName.TabStop = true;
            this.rabBookName.Text = "Tên sách";
            this.rabBookName.UseVisualStyleBackColor = true;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(174, 29);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 1;
            this.btnSearchBook.Text = "Tìm ";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(6, 29);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(151, 22);
            this.txtSearchBook.TabIndex = 0;
            // 
            // lvSearch
            // 
            this.lvSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSearch.FullRowSelect = true;
            this.lvSearch.GridLines = true;
            this.lvSearch.Location = new System.Drawing.Point(71, 221);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(738, 187);
            this.lvSearch.TabIndex = 4;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.View = System.Windows.Forms.View.Details;
            this.lvSearch.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSearch_ItemSelectionChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(81, 194);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(152, 21);
            this.txtName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.thanhtrangthai1);
            this.panel1.Location = new System.Drawing.Point(71, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 35);
            this.panel1.TabIndex = 7;
            // 
            // thanhtrangthai1
            // 
            this.thanhtrangthai1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.thanhtrangthai1.Location = new System.Drawing.Point(0, 0);
            this.thanhtrangthai1.Name = "thanhtrangthai1";
            this.thanhtrangthai1.Size = new System.Drawing.Size(556, 25);
            this.thanhtrangthai1.TabIndex = 0;
            this.thanhtrangthai1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(134, 22);
            this.toolStripLabel1.Text = "Số bản ghi tìm được: ";
            // 
            // fManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "fManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fManagement_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.thanhtrangthai1.ResumeLayout(false);
            this.thanhtrangthai1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabBookCode;
        private System.Windows.Forms.RadioButton rabTheLoai;
        private System.Windows.Forms.RadioButton rabTG;
        private System.Windows.Forms.RadioButton rabBookName;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.RadioButton rabMaSV;
        private System.Windows.Forms.RadioButton radMaDG;
        private System.Windows.Forms.Button btnSearchPeople;
        private System.Windows.Forms.TextBox txtSearchPeople;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip thanhtrangthai1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}