
namespace QLNhaKhoa
{
    partial class fPhanQuyen
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
            this.components = new System.ComponentModel.Container();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTaiKhoanPhanQuyen = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.dgvQuyen = new System.Windows.Forms.DataGridView();
            this.pnTTNguoiDung = new System.Windows.Forms.Panel();
            this.ibtnHuy = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.lbThongTinNguoiDung = new System.Windows.Forms.Label();
            this.erpPhanQuyen = new System.Windows.Forms.ErrorProvider(this.components);
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.TenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clThem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clSua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clXoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clIn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clTimKiem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clMaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyen)).BeginInit();
            this.pnTTNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Fuchsia;
            this.pnTitle.Controls.Add(this.lbTaiKhoanPhanQuyen);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1124, 99);
            this.pnTitle.TabIndex = 10;
            // 
            // lbTaiKhoanPhanQuyen
            // 
            this.lbTaiKhoanPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTaiKhoanPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoanPhanQuyen.ForeColor = System.Drawing.Color.White;
            this.lbTaiKhoanPhanQuyen.Location = new System.Drawing.Point(104, 9);
            this.lbTaiKhoanPhanQuyen.Name = "lbTaiKhoanPhanQuyen";
            this.lbTaiKhoanPhanQuyen.Size = new System.Drawing.Size(882, 73);
            this.lbTaiKhoanPhanQuyen.TabIndex = 3;
            this.lbTaiKhoanPhanQuyen.Text = "TÀI KHOẢN - PHÂN QUYỀN";
            this.lbTaiKhoanPhanQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHoTen,
            this.clTaiKhoan,
            this.clMaNV,
            this.clMaTaiKhoan});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 134);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(359, 351);
            this.dgvTaiKhoan.TabIndex = 17;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // clHoTen
            // 
            this.clHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTen.DataPropertyName = "HoTen";
            this.clHoTen.HeaderText = "Họ tên người dùng";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clTaiKhoan
            // 
            this.clTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTaiKhoan.DataPropertyName = "TenTK";
            this.clTaiKhoan.HeaderText = "Tài khoản";
            this.clTaiKhoan.Name = "clTaiKhoan";
            this.clTaiKhoan.ReadOnly = true;
            // 
            // clMaNV
            // 
            this.clMaNV.DataPropertyName = "MaNV";
            this.clMaNV.HeaderText = "MaNV";
            this.clMaNV.Name = "clMaNV";
            this.clMaNV.ReadOnly = true;
            this.clMaNV.Visible = false;
            // 
            // clMaTaiKhoan
            // 
            this.clMaTaiKhoan.DataPropertyName = "MaTK";
            this.clMaTaiKhoan.HeaderText = "MaTK";
            this.clMaTaiKhoan.Name = "clMaTaiKhoan";
            this.clMaTaiKhoan.ReadOnly = true;
            this.clMaTaiKhoan.Visible = false;
            // 
            // ibtnRefresh
            // 
            this.ibtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnRefresh.IconColor = System.Drawing.Color.Black;
            this.ibtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefresh.IconSize = 19;
            this.ibtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.Location = new System.Drawing.Point(225, 105);
            this.ibtnRefresh.Name = "ibtnRefresh";
            this.ibtnRefresh.Size = new System.Drawing.Size(76, 23);
            this.ibtnRefresh.TabIndex = 15;
            this.ibtnRefresh.Text = "Refresh";
            this.ibtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRefresh.UseVisualStyleBackColor = true;
            this.ibtnRefresh.Click += new System.EventHandler(this.ibtnRefresh_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoa.IconColor = System.Drawing.Color.Black;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.IconSize = 19;
            this.ibtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoa.Location = new System.Drawing.Point(154, 105);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(65, 23);
            this.ibtnXoa.TabIndex = 16;
            this.ibtnXoa.Text = "Xóa";
            this.ibtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoa.UseVisualStyleBackColor = true;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.ibtnSua.IconColor = System.Drawing.Color.Black;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.IconSize = 19;
            this.ibtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.Location = new System.Drawing.Point(83, 105);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(65, 23);
            this.ibtnSua.TabIndex = 14;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = true;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnThem
            // 
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnThem.IconColor = System.Drawing.Color.Black;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.IconSize = 20;
            this.ibtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThem.Location = new System.Drawing.Point(12, 105);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(65, 23);
            this.ibtnThem.TabIndex = 13;
            this.ibtnThem.Text = "Thêm";
            this.ibtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThem.UseVisualStyleBackColor = true;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // dgvQuyen
            // 
            this.dgvQuyen.AllowUserToAddRows = false;
            this.dgvQuyen.AllowUserToDeleteRows = false;
            this.dgvQuyen.AllowUserToOrderColumns = true;
            this.dgvQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenCN,
            this.clXem,
            this.clThem,
            this.clSua,
            this.clXoa,
            this.clIn,
            this.clTimKiem,
            this.clMaTK,
            this.clMaCN,
            this.clMaHD});
            this.dgvQuyen.Location = new System.Drawing.Point(365, 134);
            this.dgvQuyen.Name = "dgvQuyen";
            this.dgvQuyen.Size = new System.Drawing.Size(759, 514);
            this.dgvQuyen.TabIndex = 18;
            this.dgvQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyen_CellClick);
            this.dgvQuyen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyen_CellValueChanged);
            // 
            // pnTTNguoiDung
            // 
            this.pnTTNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnTTNguoiDung.BackColor = System.Drawing.Color.Silver;
            this.pnTTNguoiDung.Controls.Add(this.ibtnHuy);
            this.pnTTNguoiDung.Controls.Add(this.ibtnLuu);
            this.pnTTNguoiDung.Controls.Add(this.txtMatKhau);
            this.pnTTNguoiDung.Controls.Add(this.txtTenDangNhap);
            this.pnTTNguoiDung.Controls.Add(this.cbxNhanVien);
            this.pnTTNguoiDung.Controls.Add(this.lbMatKhau);
            this.pnTTNguoiDung.Controls.Add(this.lbTenDangNhap);
            this.pnTTNguoiDung.Controls.Add(this.lbNhanVien);
            this.pnTTNguoiDung.Controls.Add(this.lbThongTinNguoiDung);
            this.pnTTNguoiDung.Location = new System.Drawing.Point(0, 491);
            this.pnTTNguoiDung.Name = "pnTTNguoiDung";
            this.pnTTNguoiDung.Size = new System.Drawing.Size(359, 157);
            this.pnTTNguoiDung.TabIndex = 19;
            // 
            // ibtnHuy
            // 
            this.ibtnHuy.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnHuy.IconColor = System.Drawing.Color.Black;
            this.ibtnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHuy.IconSize = 20;
            this.ibtnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHuy.Location = new System.Drawing.Point(80, 117);
            this.ibtnHuy.Name = "ibtnHuy";
            this.ibtnHuy.Size = new System.Drawing.Size(62, 30);
            this.ibtnHuy.TabIndex = 15;
            this.ibtnHuy.Text = "Hủy";
            this.ibtnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnHuy.UseVisualStyleBackColor = true;
            this.ibtnHuy.Click += new System.EventHandler(this.ibtnHuy_Click);
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnLuu.IconColor = System.Drawing.Color.Black;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.IconSize = 20;
            this.ibtnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.Location = new System.Drawing.Point(12, 117);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(62, 30);
            this.ibtnLuu.TabIndex = 14;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = true;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(117, 90);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(219, 20);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(117, 63);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(219, 20);
            this.txtTenDangNhap.TabIndex = 4;
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.Location = new System.Drawing.Point(117, 36);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(219, 21);
            this.cbxNhanVien.TabIndex = 2;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(12, 90);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(58, 15);
            this.lbMatKhau.TabIndex = 1;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDangNhap.Location = new System.Drawing.Point(12, 63);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(90, 15);
            this.lbTenDangNhap.TabIndex = 1;
            this.lbTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.Location = new System.Drawing.Point(12, 37);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(62, 15);
            this.lbNhanVien.TabIndex = 1;
            this.lbNhanVien.Text = "Nhân viên";
            // 
            // lbThongTinNguoiDung
            // 
            this.lbThongTinNguoiDung.AutoSize = true;
            this.lbThongTinNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTinNguoiDung.Location = new System.Drawing.Point(26, 10);
            this.lbThongTinNguoiDung.Name = "lbThongTinNguoiDung";
            this.lbThongTinNguoiDung.Size = new System.Drawing.Size(132, 16);
            this.lbThongTinNguoiDung.TabIndex = 0;
            this.lbThongTinNguoiDung.Text = "Thông tin người dùng";
            // 
            // erpPhanQuyen
            // 
            this.erpPhanQuyen.ContainerControl = this;
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
            this.ibtnTimKiem.TabIndex = 22;
            this.ibtnTimKiem.Text = "Tìm kiếm";
            this.ibtnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = true;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(916, 107);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(115, 20);
            this.txtTaiKhoan.TabIndex = 21;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Location = new System.Drawing.Point(790, 110);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(120, 13);
            this.lbTaiKhoan.TabIndex = 20;
            this.lbTaiKhoan.Text = "Tìm kiếm theo tài khoản";
            // 
            // TenCN
            // 
            this.TenCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCN.DataPropertyName = "TenCN";
            this.TenCN.HeaderText = "Tên chức năng";
            this.TenCN.Name = "TenCN";
            this.TenCN.ReadOnly = true;
            // 
            // clXem
            // 
            this.clXem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clXem.DataPropertyName = "Xem";
            this.clXem.FalseValue = "FALSE";
            this.clXem.HeaderText = "Xem";
            this.clXem.IndeterminateValue = "";
            this.clXem.Name = "clXem";
            this.clXem.TrueValue = "TRUE";
            // 
            // clThem
            // 
            this.clThem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clThem.DataPropertyName = "Them";
            this.clThem.FalseValue = "FALSE";
            this.clThem.HeaderText = "Thêm";
            this.clThem.IndeterminateValue = "";
            this.clThem.Name = "clThem";
            this.clThem.TrueValue = "TRUE";
            // 
            // clSua
            // 
            this.clSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSua.DataPropertyName = "Sua";
            this.clSua.FalseValue = "FALSE";
            this.clSua.HeaderText = "Sửa";
            this.clSua.IndeterminateValue = "";
            this.clSua.Name = "clSua";
            this.clSua.TrueValue = "TRUE";
            // 
            // clXoa
            // 
            this.clXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clXoa.DataPropertyName = "Xoa";
            this.clXoa.FalseValue = "FALSE";
            this.clXoa.HeaderText = "Xóa";
            this.clXoa.IndeterminateValue = "";
            this.clXoa.Name = "clXoa";
            this.clXoa.TrueValue = "TRUE";
            // 
            // clIn
            // 
            this.clIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clIn.DataPropertyName = "Inn";
            this.clIn.FalseValue = "FALSE";
            this.clIn.HeaderText = "In";
            this.clIn.IndeterminateValue = "";
            this.clIn.Name = "clIn";
            this.clIn.TrueValue = "TRUE";
            // 
            // clTimKiem
            // 
            this.clTimKiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTimKiem.DataPropertyName = "TimKiem";
            this.clTimKiem.FalseValue = "FALSE";
            this.clTimKiem.HeaderText = "Tìm kiếm";
            this.clTimKiem.IndeterminateValue = "";
            this.clTimKiem.Name = "clTimKiem";
            this.clTimKiem.TrueValue = "TRUE";
            // 
            // clMaTK
            // 
            this.clMaTK.DataPropertyName = "MaTK";
            this.clMaTK.HeaderText = "MaTK";
            this.clMaTK.Name = "clMaTK";
            this.clMaTK.ReadOnly = true;
            this.clMaTK.Visible = false;
            // 
            // clMaCN
            // 
            this.clMaCN.DataPropertyName = "MaCN";
            this.clMaCN.HeaderText = "MaCN";
            this.clMaCN.Name = "clMaCN";
            this.clMaCN.ReadOnly = true;
            this.clMaCN.Visible = false;
            // 
            // clMaHD
            // 
            this.clMaHD.DataPropertyName = "MaHD";
            this.clMaHD.HeaderText = "MaHD";
            this.clMaHD.Name = "clMaHD";
            this.clMaHD.ReadOnly = true;
            this.clMaHD.Visible = false;
            // 
            // fPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.ibtnTimKiem);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lbTaiKhoan);
            this.Controls.Add(this.pnTTNguoiDung);
            this.Controls.Add(this.dgvQuyen);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.ibtnRefresh);
            this.Controls.Add(this.ibtnXoa);
            this.Controls.Add(this.ibtnSua);
            this.Controls.Add(this.ibtnThem);
            this.Controls.Add(this.pnTitle);
            this.Name = "fPhanQuyen";
            this.Text = "PhanQuyen";
            this.pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyen)).EndInit();
            this.pnTTNguoiDung.ResumeLayout(false);
            this.pnTTNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTaiKhoanPhanQuyen;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridView dgvQuyen;
        private System.Windows.Forms.Panel pnTTNguoiDung;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.Label lbThongTinNguoiDung;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnHuy;
        private System.Windows.Forms.ErrorProvider erpPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaTaiKhoan;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clXem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clThem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSua;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clXoa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clIn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHD;
    }
}