
namespace QLNhaKhoa
{
    partial class fQuanLyNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDanhSachNV = new System.Windows.Forms.Label();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.dgvTTNhanVien = new System.Windows.Forms.DataGridView();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMucLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.lbDanhSachNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 99);
            this.panel1.TabIndex = 9;
            // 
            // lbDanhSachNV
            // 
            this.lbDanhSachNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDanhSachNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachNV.ForeColor = System.Drawing.Color.White;
            this.lbDanhSachNV.Location = new System.Drawing.Point(104, 9);
            this.lbDanhSachNV.Name = "lbDanhSachNV";
            this.lbDanhSachNV.Size = new System.Drawing.Size(882, 73);
            this.lbDanhSachNV.TabIndex = 3;
            this.lbDanhSachNV.Text = "DANH SÁCH NHÂN VIÊN";
            this.lbDanhSachNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibtnThem
            // 
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnThem.IconColor = System.Drawing.Color.Black;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.IconSize = 20;
            this.ibtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThem.Location = new System.Drawing.Point(0, 105);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(65, 23);
            this.ibtnThem.TabIndex = 10;
            this.ibtnThem.Text = "Thêm";
            this.ibtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThem.UseVisualStyleBackColor = true;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.ibtnSua.IconColor = System.Drawing.Color.Black;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.IconSize = 19;
            this.ibtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.Location = new System.Drawing.Point(71, 105);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(65, 23);
            this.ibtnSua.TabIndex = 11;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = true;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoa.IconColor = System.Drawing.Color.Black;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.IconSize = 19;
            this.ibtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoa.Location = new System.Drawing.Point(142, 105);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(65, 23);
            this.ibtnXoa.TabIndex = 12;
            this.ibtnXoa.Text = "Xóa";
            this.ibtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoa.UseVisualStyleBackColor = true;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(823, 114);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(87, 13);
            this.lbHoTen.TabIndex = 14;
            this.lbHoTen.Text = "Nhập Họ và Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(916, 107);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(115, 20);
            this.txtHoTen.TabIndex = 15;
            // 
            // ibtnTimKiem
            // 
            this.ibtnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnTimKiem.IconColor = System.Drawing.Color.Black;
            this.ibtnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTimKiem.IconSize = 15;
            this.ibtnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ibtnTimKiem.Location = new System.Drawing.Point(1037, 105);
            this.ibtnTimKiem.Name = "ibtnTimKiem";
            this.ibtnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.ibtnTimKiem.TabIndex = 16;
            this.ibtnTimKiem.Text = "Tìm kiếm";
            this.ibtnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = true;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // dgvTTNhanVien
            // 
            this.dgvTTNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHoTen,
            this.clTenVT,
            this.clNgaySinh,
            this.clGioiTinh,
            this.clSoDT,
            this.clDiaChi,
            this.clMucLuong,
            this.clGhiChu,
            this.clMaN,
            this.clMaNV});
            this.dgvTTNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTTNhanVien.Location = new System.Drawing.Point(0, 134);
            this.dgvTTNhanVien.Name = "dgvTTNhanVien";
            this.dgvTTNhanVien.Size = new System.Drawing.Size(1124, 516);
            this.dgvTTNhanVien.TabIndex = 17;
            this.dgvTTNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTNhanVien_CellClick);
            // 
            // clHoTen
            // 
            this.clHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTen.DataPropertyName = "HoTen";
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clTenVT
            // 
            this.clTenVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenVT.DataPropertyName = "TenVT";
            this.clTenVT.HeaderText = "Vai trò";
            this.clTenVT.Name = "clTenVT";
            this.clTenVT.ReadOnly = true;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgaySinh.DataPropertyName = "NgaySinh";
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.ReadOnly = true;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGioiTinh.DataPropertyName = "GioiTinh";
            this.clGioiTinh.HeaderText = "Giới tính";
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.ReadOnly = true;
            // 
            // clSoDT
            // 
            this.clSoDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSoDT.DataPropertyName = "SoDT";
            this.clSoDT.HeaderText = "Điện thoại";
            this.clSoDT.Name = "clSoDT";
            this.clSoDT.ReadOnly = true;
            // 
            // clDiaChi
            // 
            this.clDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDiaChi.DataPropertyName = "DiaChi";
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.ReadOnly = true;
            // 
            // clMucLuong
            // 
            this.clMucLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMucLuong.DataPropertyName = "MucLuong";
            this.clMucLuong.HeaderText = "Mức lương";
            this.clMucLuong.Name = "clMucLuong";
            this.clMucLuong.ReadOnly = true;
            // 
            // clGhiChu
            // 
            this.clGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            // 
            // clMaN
            // 
            this.clMaN.DataPropertyName = "MaN";
            this.clMaN.HeaderText = "Mã người";
            this.clMaN.Name = "clMaN";
            this.clMaN.ReadOnly = true;
            this.clMaN.Visible = false;
            // 
            // clMaNV
            // 
            this.clMaNV.DataPropertyName = "MaNV";
            this.clMaNV.HeaderText = "Mã nhân viên";
            this.clMaNV.Name = "clMaNV";
            this.clMaNV.ReadOnly = true;
            this.clMaNV.Visible = false;
            // 
            // ibtnRefresh
            // 
            this.ibtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnRefresh.IconColor = System.Drawing.Color.Black;
            this.ibtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefresh.IconSize = 19;
            this.ibtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.Location = new System.Drawing.Point(213, 105);
            this.ibtnRefresh.Name = "ibtnRefresh";
            this.ibtnRefresh.Size = new System.Drawing.Size(76, 23);
            this.ibtnRefresh.TabIndex = 12;
            this.ibtnRefresh.Text = "Refresh";
            this.ibtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRefresh.UseVisualStyleBackColor = true;
            this.ibtnRefresh.Click += new System.EventHandler(this.ibtnRefresh_Click);
            // 
            // fQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.dgvTTNhanVien);
            this.Controls.Add(this.ibtnTimKiem);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.ibtnRefresh);
            this.Controls.Add(this.ibtnXoa);
            this.Controls.Add(this.ibtnSua);
            this.Controls.Add(this.ibtnThem);
            this.Controls.Add(this.panel1);
            this.Name = "fQuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDanhSachNV;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        public System.Windows.Forms.DataGridView dgvTTNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMucLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
    }
}