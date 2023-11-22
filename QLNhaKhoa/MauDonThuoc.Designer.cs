
namespace QLNhaKhoa
{
    partial class fMauDonThuoc
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
            this.dgvMauDT = new System.Windows.Forms.DataGridView();
            this.clMaMDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenMDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTenMDT = new System.Windows.Forms.Label();
            this.lbChiTietMDT = new System.Windows.Forms.Label();
            this.pnBtnThuoc = new System.Windows.Forms.Panel();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtThuoc = new System.Windows.Forms.TextBox();
            this.lbTenThuoc = new System.Windows.Forms.Label();
            this.lbThuoc = new System.Windows.Forms.Label();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.pnChiTietMDT = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.ibtnXoaCTMDT = new FontAwesome.Sharp.IconButton();
            this.pnBtnMauDT = new System.Windows.Forms.Panel();
            this.ibtnThemMauDT = new FontAwesome.Sharp.IconButton();
            this.ibtnXoaMauDT = new FontAwesome.Sharp.IconButton();
            this.ibtnSuaMauDT = new FontAwesome.Sharp.IconButton();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.clMaT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLuongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvChiTietMDT = new System.Windows.Forms.DataGridView();
            this.clMaCTMDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaMauDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHuongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnGridView = new System.Windows.Forms.Panel();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbMauDonThuoc = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.erpPhanQuyen = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMauDT)).BeginInit();
            this.pnBtnThuoc.SuspendLayout();
            this.pnChiTietMDT.SuspendLayout();
            this.pnBtnMauDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMDT)).BeginInit();
            this.pnGridView.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMauDT
            // 
            this.dgvMauDT.AllowUserToAddRows = false;
            this.dgvMauDT.AllowUserToDeleteRows = false;
            this.dgvMauDT.BackgroundColor = System.Drawing.Color.White;
            this.dgvMauDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMauDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaMDT,
            this.clTenMDT});
            this.dgvMauDT.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMauDT.Location = new System.Drawing.Point(0, 0);
            this.dgvMauDT.Name = "dgvMauDT";
            this.dgvMauDT.ReadOnly = true;
            this.dgvMauDT.Size = new System.Drawing.Size(312, 521);
            this.dgvMauDT.TabIndex = 30;
            this.dgvMauDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMauDT_CellClick);
            // 
            // clMaMDT
            // 
            this.clMaMDT.DataPropertyName = "MaMDT";
            this.clMaMDT.HeaderText = "Mã mẫu đơn thuốc";
            this.clMaMDT.Name = "clMaMDT";
            this.clMaMDT.ReadOnly = true;
            this.clMaMDT.Visible = false;
            // 
            // clTenMDT
            // 
            this.clTenMDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenMDT.DataPropertyName = "TenMDT";
            this.clTenMDT.HeaderText = "Tên mẫu đơn thuốc";
            this.clTenMDT.Name = "clTenMDT";
            this.clTenMDT.ReadOnly = true;
            // 
            // lbTenMDT
            // 
            this.lbTenMDT.AutoSize = true;
            this.lbTenMDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMDT.ForeColor = System.Drawing.Color.Blue;
            this.lbTenMDT.Location = new System.Drawing.Point(275, 8);
            this.lbTenMDT.Name = "lbTenMDT";
            this.lbTenMDT.Size = new System.Drawing.Size(19, 25);
            this.lbTenMDT.TabIndex = 36;
            this.lbTenMDT.Text = " ";
            // 
            // lbChiTietMDT
            // 
            this.lbChiTietMDT.AutoSize = true;
            this.lbChiTietMDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietMDT.ForeColor = System.Drawing.Color.Blue;
            this.lbChiTietMDT.Location = new System.Drawing.Point(13, 8);
            this.lbChiTietMDT.Name = "lbChiTietMDT";
            this.lbChiTietMDT.Size = new System.Drawing.Size(256, 25);
            this.lbChiTietMDT.TabIndex = 36;
            this.lbChiTietMDT.Text = "Chi tiết mẫu đơn thuốc:";
            // 
            // pnBtnThuoc
            // 
            this.pnBtnThuoc.BackColor = System.Drawing.Color.DarkGray;
            this.pnBtnThuoc.Controls.Add(this.ibtnTimKiem);
            this.pnBtnThuoc.Controls.Add(this.txtThuoc);
            this.pnBtnThuoc.Controls.Add(this.lbTenThuoc);
            this.pnBtnThuoc.Controls.Add(this.lbThuoc);
            this.pnBtnThuoc.Controls.Add(this.ibtnRefresh);
            this.pnBtnThuoc.Controls.Add(this.ibtnThem);
            this.pnBtnThuoc.Controls.Add(this.ibtnXoa);
            this.pnBtnThuoc.Controls.Add(this.ibtnSua);
            this.pnBtnThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBtnThuoc.Location = new System.Drawing.Point(312, 74);
            this.pnBtnThuoc.Name = "pnBtnThuoc";
            this.pnBtnThuoc.Size = new System.Drawing.Size(812, 55);
            this.pnBtnThuoc.TabIndex = 33;
            // 
            // ibtnTimKiem
            // 
            this.ibtnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnTimKiem.IconColor = System.Drawing.Color.Black;
            this.ibtnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTimKiem.IconSize = 15;
            this.ibtnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ibtnTimKiem.Location = new System.Drawing.Point(725, 16);
            this.ibtnTimKiem.Name = "ibtnTimKiem";
            this.ibtnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.ibtnTimKiem.TabIndex = 31;
            this.ibtnTimKiem.Text = "Tìm kiếm";
            this.ibtnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = true;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // txtThuoc
            // 
            this.txtThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThuoc.Location = new System.Drawing.Point(604, 18);
            this.txtThuoc.Name = "txtThuoc";
            this.txtThuoc.Size = new System.Drawing.Size(115, 20);
            this.txtThuoc.TabIndex = 30;
            // 
            // lbTenThuoc
            // 
            this.lbTenThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenThuoc.AutoSize = true;
            this.lbTenThuoc.Location = new System.Drawing.Point(511, 22);
            this.lbTenThuoc.Name = "lbTenThuoc";
            this.lbTenThuoc.Size = new System.Drawing.Size(81, 13);
            this.lbTenThuoc.TabIndex = 29;
            this.lbTenThuoc.Text = "Nhập tên thuốc";
            // 
            // lbThuoc
            // 
            this.lbThuoc.AutoSize = true;
            this.lbThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuoc.Location = new System.Drawing.Point(15, 19);
            this.lbThuoc.Name = "lbThuoc";
            this.lbThuoc.Size = new System.Drawing.Size(46, 16);
            this.lbThuoc.TabIndex = 28;
            this.lbThuoc.Text = "Thuốc";
            // 
            // ibtnRefresh
            // 
            this.ibtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnRefresh.IconColor = System.Drawing.Color.Black;
            this.ibtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefresh.IconSize = 19;
            this.ibtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.Location = new System.Drawing.Point(347, 16);
            this.ibtnRefresh.Name = "ibtnRefresh";
            this.ibtnRefresh.Size = new System.Drawing.Size(76, 23);
            this.ibtnRefresh.TabIndex = 26;
            this.ibtnRefresh.Text = "Refresh";
            this.ibtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRefresh.UseVisualStyleBackColor = true;
            this.ibtnRefresh.Click += new System.EventHandler(this.ibtnRefresh_Click);
            // 
            // ibtnThem
            // 
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnThem.IconColor = System.Drawing.Color.Black;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.IconSize = 20;
            this.ibtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThem.Location = new System.Drawing.Point(134, 16);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(65, 23);
            this.ibtnThem.TabIndex = 24;
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
            this.ibtnXoa.Location = new System.Drawing.Point(276, 16);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(65, 23);
            this.ibtnXoa.TabIndex = 27;
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
            this.ibtnSua.Location = new System.Drawing.Point(205, 16);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(65, 23);
            this.ibtnSua.TabIndex = 25;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = true;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // pnChiTietMDT
            // 
            this.pnChiTietMDT.Controls.Add(this.txtSoLuong);
            this.pnChiTietMDT.Controls.Add(this.lbSoLuong);
            this.pnChiTietMDT.Controls.Add(this.ibtnXoaCTMDT);
            this.pnChiTietMDT.Controls.Add(this.lbTenMDT);
            this.pnChiTietMDT.Controls.Add(this.lbChiTietMDT);
            this.pnChiTietMDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiTietMDT.Location = new System.Drawing.Point(0, 204);
            this.pnChiTietMDT.Name = "pnChiTietMDT";
            this.pnChiTietMDT.Size = new System.Drawing.Size(812, 43);
            this.pnChiTietMDT.TabIndex = 35;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Location = new System.Drawing.Point(661, 14);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(115, 20);
            this.txtSoLuong.TabIndex = 39;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(563, 17);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(92, 13);
            this.lbSoLuong.TabIndex = 38;
            this.lbSoLuong.Text = "Thay đổi số lượng";
            // 
            // ibtnXoaCTMDT
            // 
            this.ibtnXoaCTMDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnXoaCTMDT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoaCTMDT.IconColor = System.Drawing.Color.Black;
            this.ibtnXoaCTMDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoaCTMDT.IconSize = 19;
            this.ibtnXoaCTMDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoaCTMDT.Location = new System.Drawing.Point(782, 20);
            this.ibtnXoaCTMDT.Name = "ibtnXoaCTMDT";
            this.ibtnXoaCTMDT.Size = new System.Drawing.Size(30, 23);
            this.ibtnXoaCTMDT.TabIndex = 37;
            this.ibtnXoaCTMDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoaCTMDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoaCTMDT.UseVisualStyleBackColor = true;
            this.ibtnXoaCTMDT.Click += new System.EventHandler(this.ibtnXoaCTMDT_Click);
            // 
            // pnBtnMauDT
            // 
            this.pnBtnMauDT.BackColor = System.Drawing.Color.LightGray;
            this.pnBtnMauDT.Controls.Add(this.ibtnThemMauDT);
            this.pnBtnMauDT.Controls.Add(this.ibtnXoaMauDT);
            this.pnBtnMauDT.Controls.Add(this.ibtnSuaMauDT);
            this.pnBtnMauDT.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBtnMauDT.Location = new System.Drawing.Point(0, 74);
            this.pnBtnMauDT.Name = "pnBtnMauDT";
            this.pnBtnMauDT.Size = new System.Drawing.Size(312, 55);
            this.pnBtnMauDT.TabIndex = 1;
            // 
            // ibtnThemMauDT
            // 
            this.ibtnThemMauDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnThemMauDT.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnThemMauDT.IconColor = System.Drawing.Color.Black;
            this.ibtnThemMauDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThemMauDT.IconSize = 20;
            this.ibtnThemMauDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThemMauDT.Location = new System.Drawing.Point(48, 16);
            this.ibtnThemMauDT.Name = "ibtnThemMauDT";
            this.ibtnThemMauDT.Size = new System.Drawing.Size(65, 23);
            this.ibtnThemMauDT.TabIndex = 30;
            this.ibtnThemMauDT.Text = "Thêm";
            this.ibtnThemMauDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThemMauDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThemMauDT.UseVisualStyleBackColor = true;
            this.ibtnThemMauDT.Click += new System.EventHandler(this.ibtnThemMauDT_Click);
            // 
            // ibtnXoaMauDT
            // 
            this.ibtnXoaMauDT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoaMauDT.IconColor = System.Drawing.Color.Black;
            this.ibtnXoaMauDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoaMauDT.IconSize = 19;
            this.ibtnXoaMauDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoaMauDT.Location = new System.Drawing.Point(190, 16);
            this.ibtnXoaMauDT.Name = "ibtnXoaMauDT";
            this.ibtnXoaMauDT.Size = new System.Drawing.Size(65, 23);
            this.ibtnXoaMauDT.TabIndex = 32;
            this.ibtnXoaMauDT.Text = "Xóa";
            this.ibtnXoaMauDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoaMauDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoaMauDT.UseVisualStyleBackColor = true;
            this.ibtnXoaMauDT.Click += new System.EventHandler(this.ibtnXoaMauDT_Click);
            // 
            // ibtnSuaMauDT
            // 
            this.ibtnSuaMauDT.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.ibtnSuaMauDT.IconColor = System.Drawing.Color.Black;
            this.ibtnSuaMauDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSuaMauDT.IconSize = 19;
            this.ibtnSuaMauDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSuaMauDT.Location = new System.Drawing.Point(119, 16);
            this.ibtnSuaMauDT.Name = "ibtnSuaMauDT";
            this.ibtnSuaMauDT.Size = new System.Drawing.Size(65, 23);
            this.ibtnSuaMauDT.TabIndex = 31;
            this.ibtnSuaMauDT.Text = "Sửa";
            this.ibtnSuaMauDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSuaMauDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSuaMauDT.UseVisualStyleBackColor = true;
            this.ibtnSuaMauDT.Click += new System.EventHandler(this.ibtnSuaMauDT_Click);
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AllowUserToDeleteRows = false;
            this.dgvThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaT,
            this.clTenT,
            this.clDonVi,
            this.clLuongDung,
            this.clCongDung});
            this.dgvThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThuoc.Location = new System.Drawing.Point(0, 0);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.Size = new System.Drawing.Size(812, 204);
            this.dgvThuoc.TabIndex = 34;
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            this.dgvThuoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellDoubleClick);
            // 
            // clMaT
            // 
            this.clMaT.DataPropertyName = "MaT";
            this.clMaT.HeaderText = "Mã thuốc";
            this.clMaT.Name = "clMaT";
            this.clMaT.ReadOnly = true;
            this.clMaT.Visible = false;
            // 
            // clTenT
            // 
            this.clTenT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenT.DataPropertyName = "TenT";
            this.clTenT.HeaderText = "Tên thuốc";
            this.clTenT.Name = "clTenT";
            this.clTenT.ReadOnly = true;
            // 
            // clDonVi
            // 
            this.clDonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDonVi.DataPropertyName = "DonVi";
            this.clDonVi.HeaderText = "Đơn vị";
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.ReadOnly = true;
            // 
            // clLuongDung
            // 
            this.clLuongDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLuongDung.DataPropertyName = "LuongDung";
            this.clLuongDung.HeaderText = "Lượng dùng";
            this.clLuongDung.Name = "clLuongDung";
            this.clLuongDung.ReadOnly = true;
            // 
            // clCongDung
            // 
            this.clCongDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clCongDung.DataPropertyName = "CongDung";
            this.clCongDung.HeaderText = "Công dụng thuốc";
            this.clCongDung.Name = "clCongDung";
            this.clCongDung.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvChiTietMDT);
            this.panel1.Controls.Add(this.pnChiTietMDT);
            this.panel1.Controls.Add(this.dgvThuoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(312, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 521);
            this.panel1.TabIndex = 32;
            // 
            // dgvChiTietMDT
            // 
            this.dgvChiTietMDT.AllowUserToAddRows = false;
            this.dgvChiTietMDT.AllowUserToDeleteRows = false;
            this.dgvChiTietMDT.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietMDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietMDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCTMDT,
            this.clMaThuoc,
            this.clMaMauDT,
            this.clTenThuoc,
            this.clSoLuong,
            this.clHuongDan});
            this.dgvChiTietMDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietMDT.Location = new System.Drawing.Point(0, 247);
            this.dgvChiTietMDT.Name = "dgvChiTietMDT";
            this.dgvChiTietMDT.ReadOnly = true;
            this.dgvChiTietMDT.Size = new System.Drawing.Size(812, 274);
            this.dgvChiTietMDT.TabIndex = 36;
            this.dgvChiTietMDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietMDT_CellClick);
            this.dgvChiTietMDT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietMDT_CellDoubleClick);
            // 
            // clMaCTMDT
            // 
            this.clMaCTMDT.DataPropertyName = "MaCTMDT";
            this.clMaCTMDT.HeaderText = "Mã chi tiết mẫu đơn thuốc";
            this.clMaCTMDT.Name = "clMaCTMDT";
            this.clMaCTMDT.ReadOnly = true;
            this.clMaCTMDT.Visible = false;
            // 
            // clMaThuoc
            // 
            this.clMaThuoc.DataPropertyName = "MaT";
            this.clMaThuoc.HeaderText = "Mã thuốc";
            this.clMaThuoc.Name = "clMaThuoc";
            this.clMaThuoc.ReadOnly = true;
            this.clMaThuoc.Visible = false;
            // 
            // clMaMauDT
            // 
            this.clMaMauDT.DataPropertyName = "MaMDT";
            this.clMaMauDT.HeaderText = "Mã mẫu đơn thuốc";
            this.clMaMauDT.Name = "clMaMauDT";
            this.clMaMauDT.ReadOnly = true;
            this.clMaMauDT.Visible = false;
            // 
            // clTenThuoc
            // 
            this.clTenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenThuoc.DataPropertyName = "TenT";
            this.clTenThuoc.HeaderText = "Tên thuốc";
            this.clTenThuoc.Name = "clTenThuoc";
            this.clTenThuoc.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clHuongDan
            // 
            this.clHuongDan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHuongDan.DataPropertyName = "LuongDung";
            this.clHuongDan.HeaderText = "Hướng dẫn sử dụng";
            this.clHuongDan.Name = "clHuongDan";
            this.clHuongDan.ReadOnly = true;
            // 
            // pnGridView
            // 
            this.pnGridView.Controls.Add(this.panel1);
            this.pnGridView.Controls.Add(this.dgvMauDT);
            this.pnGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGridView.Location = new System.Drawing.Point(0, 129);
            this.pnGridView.Name = "pnGridView";
            this.pnGridView.Size = new System.Drawing.Size(1124, 521);
            this.pnGridView.TabIndex = 39;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTitle.Controls.Add(this.lbMauDonThuoc);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1124, 74);
            this.pnTitle.TabIndex = 0;
            // 
            // lbMauDonThuoc
            // 
            this.lbMauDonThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMauDonThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMauDonThuoc.ForeColor = System.Drawing.Color.Blue;
            this.lbMauDonThuoc.Location = new System.Drawing.Point(216, 9);
            this.lbMauDonThuoc.Name = "lbMauDonThuoc";
            this.lbMauDonThuoc.Size = new System.Drawing.Size(704, 33);
            this.lbMauDonThuoc.TabIndex = 35;
            this.lbMauDonThuoc.Text = "MẪU ĐƠN THUỐC VÀ DANH MỤC THUỐC";
            this.lbMauDonThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnBtnThuoc);
            this.pnMain.Controls.Add(this.pnBtnMauDT);
            this.pnMain.Controls.Add(this.pnTitle);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1124, 129);
            this.pnMain.TabIndex = 38;
            // 
            // erpPhanQuyen
            // 
            this.erpPhanQuyen.ContainerControl = this;
            // 
            // fMauDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.pnGridView);
            this.Controls.Add(this.pnMain);
            this.Name = "fMauDonThuoc";
            this.Text = "MauDonThuoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMauDT)).EndInit();
            this.pnBtnThuoc.ResumeLayout(false);
            this.pnBtnThuoc.PerformLayout();
            this.pnChiTietMDT.ResumeLayout(false);
            this.pnChiTietMDT.PerformLayout();
            this.pnBtnMauDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMDT)).EndInit();
            this.pnGridView.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvMauDT;
        public System.Windows.Forms.Label lbTenMDT;
        private System.Windows.Forms.Label lbChiTietMDT;
        private System.Windows.Forms.Panel pnBtnThuoc;
        private System.Windows.Forms.Label lbThuoc;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private System.Windows.Forms.Panel pnChiTietMDT;
        private System.Windows.Forms.Panel pnBtnMauDT;
        private FontAwesome.Sharp.IconButton ibtnThemMauDT;
        private FontAwesome.Sharp.IconButton ibtnXoaMauDT;
        private FontAwesome.Sharp.IconButton ibtnSuaMauDT;
        public System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnGridView;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbMauDonThuoc;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ErrorProvider erpPhanQuyen;
        private System.Windows.Forms.DataGridView dgvChiTietMDT;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private System.Windows.Forms.TextBox txtThuoc;
        private System.Windows.Forms.Label lbTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLuongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCTMDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaMauDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHuongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaMDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenMDT;
        private FontAwesome.Sharp.IconButton ibtnXoaCTMDT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbSoLuong;
    }
}