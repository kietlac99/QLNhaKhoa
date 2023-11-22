
namespace QLNhaKhoa
{
    partial class fDangKiKhamBenh
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.txtSoHSCu = new System.Windows.Forms.TextBox();
            this.lbSoHSCu = new System.Windows.Forms.Label();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.txtSoHoSo = new System.Windows.Forms.TextBox();
            this.lbSoHoSo = new System.Windows.Forms.Label();
            this.dtpChonNgay = new System.Windows.Forms.DateTimePicker();
            this.lbChonNgay = new System.Windows.Forms.Label();
            this.rbDaKham = new System.Windows.Forms.RadioButton();
            this.rdChuaKham = new System.Windows.Forms.RadioButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.clMaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLyDoKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmBenhNhan = new System.Windows.Forms.Timer(this.components);
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1124, 55);
            this.pnTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbTitle.Location = new System.Drawing.Point(379, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(377, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "HỒ SƠ BỆNH NHÂN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ibtnRefresh);
            this.panel1.Controls.Add(this.txtSoHSCu);
            this.panel1.Controls.Add(this.lbSoHSCu);
            this.panel1.Controls.Add(this.ibtnTimKiem);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Controls.Add(this.txtDienThoai);
            this.panel1.Controls.Add(this.lbDienThoai);
            this.panel1.Controls.Add(this.txtSoHoSo);
            this.panel1.Controls.Add(this.lbSoHoSo);
            this.panel1.Controls.Add(this.dtpChonNgay);
            this.panel1.Controls.Add(this.lbChonNgay);
            this.panel1.Controls.Add(this.rbDaKham);
            this.panel1.Controls.Add(this.rdChuaKham);
            this.panel1.Controls.Add(this.ibtnThem);
            this.panel1.Controls.Add(this.ibtnXoa);
            this.panel1.Controls.Add(this.ibtnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 55);
            this.panel1.TabIndex = 1;
            // 
            // ibtnRefresh
            // 
            this.ibtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnRefresh.IconColor = System.Drawing.Color.Black;
            this.ibtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefresh.IconSize = 19;
            this.ibtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.Location = new System.Drawing.Point(224, 16);
            this.ibtnRefresh.Name = "ibtnRefresh";
            this.ibtnRefresh.Size = new System.Drawing.Size(76, 23);
            this.ibtnRefresh.TabIndex = 49;
            this.ibtnRefresh.Text = "Refresh";
            this.ibtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRefresh.UseVisualStyleBackColor = true;
            this.ibtnRefresh.Click += new System.EventHandler(this.ibtnRefresh_Click);
            // 
            // txtSoHSCu
            // 
            this.txtSoHSCu.Location = new System.Drawing.Point(686, 22);
            this.txtSoHSCu.Name = "txtSoHSCu";
            this.txtSoHSCu.Size = new System.Drawing.Size(80, 20);
            this.txtSoHSCu.TabIndex = 48;
            this.txtSoHSCu.Click += new System.EventHandler(this.txtSoHSCu_Click);
            this.txtSoHSCu.TextChanged += new System.EventHandler(this.txtSoHSCu_TextChanged);
            this.txtSoHSCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoHSCu_KeyPress);
            // 
            // lbSoHSCu
            // 
            this.lbSoHSCu.AutoSize = true;
            this.lbSoHSCu.Location = new System.Drawing.Point(683, 7);
            this.lbSoHSCu.Name = "lbSoHSCu";
            this.lbSoHSCu.Size = new System.Drawing.Size(64, 13);
            this.lbSoHSCu.TabIndex = 47;
            this.lbSoHSCu.Text = "Số hồ sơ cũ";
            // 
            // ibtnTimKiem
            // 
            this.ibtnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnTimKiem.IconColor = System.Drawing.Color.Black;
            this.ibtnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTimKiem.IconSize = 15;
            this.ibtnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ibtnTimKiem.Location = new System.Drawing.Point(1036, 20);
            this.ibtnTimKiem.Name = "ibtnTimKiem";
            this.ibtnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.ibtnTimKiem.TabIndex = 32;
            this.ibtnTimKiem.Text = "Tìm kiếm";
            this.ibtnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = true;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(944, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(80, 20);
            this.txtHoTen.TabIndex = 46;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(941, 7);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(39, 13);
            this.lbHoTen.TabIndex = 45;
            this.lbHoTen.Text = "Họ tên";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(858, 22);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(80, 20);
            this.txtDienThoai.TabIndex = 44;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(855, 7);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lbDienThoai.TabIndex = 43;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // txtSoHoSo
            // 
            this.txtSoHoSo.Location = new System.Drawing.Point(772, 22);
            this.txtSoHoSo.Name = "txtSoHoSo";
            this.txtSoHoSo.Size = new System.Drawing.Size(80, 20);
            this.txtSoHoSo.TabIndex = 42;
            this.txtSoHoSo.Click += new System.EventHandler(this.txtSoHoSo_Click);
            this.txtSoHoSo.TextChanged += new System.EventHandler(this.txtSoHoSo_TextChanged);
            this.txtSoHoSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoHoSo_KeyPress);
            // 
            // lbSoHoSo
            // 
            this.lbSoHoSo.AutoSize = true;
            this.lbSoHoSo.Location = new System.Drawing.Point(769, 7);
            this.lbSoHoSo.Name = "lbSoHoSo";
            this.lbSoHoSo.Size = new System.Drawing.Size(49, 13);
            this.lbSoHoSo.TabIndex = 41;
            this.lbSoHoSo.Text = "Số hồ sơ";
            // 
            // dtpChonNgay
            // 
            this.dtpChonNgay.Location = new System.Drawing.Point(591, 22);
            this.dtpChonNgay.Name = "dtpChonNgay";
            this.dtpChonNgay.Size = new System.Drawing.Size(89, 20);
            this.dtpChonNgay.TabIndex = 38;
            this.dtpChonNgay.ValueChanged += new System.EventHandler(this.dtpChonNgay_ValueChanged);
            // 
            // lbChonNgay
            // 
            this.lbChonNgay.AutoSize = true;
            this.lbChonNgay.Location = new System.Drawing.Point(588, 5);
            this.lbChonNgay.Name = "lbChonNgay";
            this.lbChonNgay.Size = new System.Drawing.Size(58, 13);
            this.lbChonNgay.TabIndex = 37;
            this.lbChonNgay.Text = "Chọn ngày";
            // 
            // rbDaKham
            // 
            this.rbDaKham.AutoSize = true;
            this.rbDaKham.Location = new System.Drawing.Point(503, 28);
            this.rbDaKham.Name = "rbDaKham";
            this.rbDaKham.Size = new System.Drawing.Size(68, 17);
            this.rbDaKham.TabIndex = 36;
            this.rbDaKham.TabStop = true;
            this.rbDaKham.Text = "Đã khám";
            this.rbDaKham.UseVisualStyleBackColor = true;
            this.rbDaKham.CheckedChanged += new System.EventHandler(this.rbDaKham_CheckedChanged);
            this.rbDaKham.Click += new System.EventHandler(this.rbDaKham_Click);
            // 
            // rdChuaKham
            // 
            this.rdChuaKham.AutoSize = true;
            this.rdChuaKham.Location = new System.Drawing.Point(503, 5);
            this.rdChuaKham.Name = "rdChuaKham";
            this.rdChuaKham.Size = new System.Drawing.Size(79, 17);
            this.rdChuaKham.TabIndex = 2;
            this.rdChuaKham.TabStop = true;
            this.rdChuaKham.Text = "Chưa khám";
            this.rdChuaKham.UseVisualStyleBackColor = true;
            this.rdChuaKham.CheckedChanged += new System.EventHandler(this.rdChuaKham_CheckedChanged);
            this.rdChuaKham.Click += new System.EventHandler(this.rdChuaKham_Click);
            // 
            // ibtnThem
            // 
            this.ibtnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnThem.IconColor = System.Drawing.Color.Black;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.IconSize = 20;
            this.ibtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThem.Location = new System.Drawing.Point(11, 16);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(65, 23);
            this.ibtnThem.TabIndex = 33;
            this.ibtnThem.Text = "Thêm";
            this.ibtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThem.UseVisualStyleBackColor = true;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoa.IconColor = System.Drawing.Color.Black;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.IconSize = 19;
            this.ibtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoa.Location = new System.Drawing.Point(153, 16);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(65, 23);
            this.ibtnXoa.TabIndex = 35;
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
            this.ibtnSua.Location = new System.Drawing.Point(82, 16);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(65, 23);
            this.ibtnSua.TabIndex = 34;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = true;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AllowUserToAddRows = false;
            this.dgvBenhNhan.AllowUserToDeleteRows = false;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaN,
            this.clMaBN,
            this.clHoTen,
            this.clTuoi,
            this.clGioiTinh,
            this.clSoDT,
            this.clDiaChi,
            this.clGhiChu,
            this.clNgayNhap,
            this.clLyDoKham,
            this.clNgayGio});
            this.dgvBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBenhNhan.Location = new System.Drawing.Point(0, 110);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.ReadOnly = true;
            this.dgvBenhNhan.Size = new System.Drawing.Size(1124, 540);
            this.dgvBenhNhan.TabIndex = 2;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);
            this.dgvBenhNhan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellDoubleClick);
            this.dgvBenhNhan.Sorted += new System.EventHandler(this.dgvBenhNhan_Sorted);
            // 
            // clMaN
            // 
            this.clMaN.DataPropertyName = "MaN";
            this.clMaN.HeaderText = "Mã người";
            this.clMaN.Name = "clMaN";
            this.clMaN.ReadOnly = true;
            this.clMaN.Visible = false;
            // 
            // clMaBN
            // 
            this.clMaBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaBN.DataPropertyName = "MaBN";
            this.clMaBN.HeaderText = "Số hồ sơ";
            this.clMaBN.Name = "clMaBN";
            this.clMaBN.ReadOnly = true;
            // 
            // clHoTen
            // 
            this.clHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTen.DataPropertyName = "HoTen";
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clTuoi
            // 
            this.clTuoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTuoi.DataPropertyName = "Tuoi";
            this.clTuoi.HeaderText = "Tuổi";
            this.clTuoi.Name = "clTuoi";
            this.clTuoi.ReadOnly = true;
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
            // clGhiChu
            // 
            this.clGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi chú thêm";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            // 
            // clNgayNhap
            // 
            this.clNgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgayNhap.DataPropertyName = "NgayNhap";
            this.clNgayNhap.HeaderText = "Ngày nhập";
            this.clNgayNhap.Name = "clNgayNhap";
            this.clNgayNhap.ReadOnly = true;
            // 
            // clLyDoKham
            // 
            this.clLyDoKham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLyDoKham.DataPropertyName = "LyDoKham";
            this.clLyDoKham.HeaderText = "Lý do khám";
            this.clLyDoKham.Name = "clLyDoKham";
            this.clLyDoKham.ReadOnly = true;
            // 
            // clNgayGio
            // 
            this.clNgayGio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgayGio.DataPropertyName = "NgayGio";
            this.clNgayGio.HeaderText = "Đến khám lại";
            this.clNgayGio.Name = "clNgayGio";
            this.clNgayGio.ReadOnly = true;
            // 
            // tmBenhNhan
            // 
            this.tmBenhNhan.Interval = 300;
            this.tmBenhNhan.Tick += new System.EventHandler(this.tmBenhNhan_Tick);
            // 
            // fDangKiKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.dgvBenhNhan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.Name = "fDangKiKhamBenh";
            this.Text = "DangKiKhamBenh";
            this.Load += new System.EventHandler(this.fDangKiKhamBenh_Load);
            this.pnTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private System.Windows.Forms.DateTimePicker dtpChonNgay;
        private System.Windows.Forms.Label lbChonNgay;
        private System.Windows.Forms.RadioButton rbDaKham;
        private System.Windows.Forms.RadioButton rdChuaKham;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.TextBox txtSoHoSo;
        private System.Windows.Forms.Label lbSoHoSo;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private System.Windows.Forms.TextBox txtSoHSCu;
        private System.Windows.Forms.Label lbSoHSCu;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
        public System.Windows.Forms.Timer tmBenhNhan;
        public System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLyDoKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayGio;
    }
}