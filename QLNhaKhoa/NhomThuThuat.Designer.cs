
namespace QLNhaKhoa
{
    partial class fNhomThuThuat
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
            this.erpPhanQuyen = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbNhomThuThuat = new System.Windows.Forms.Label();
            this.lbThuThuat = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnThuThuat = new System.Windows.Forms.Panel();
            this.lbMiniThuThuat = new System.Windows.Forms.Label();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.pnNhomThuThuat = new System.Windows.Forms.Panel();
            this.ibtnThemNhomTT = new FontAwesome.Sharp.IconButton();
            this.ibtnXoaNhomTT = new FontAwesome.Sharp.IconButton();
            this.ibtnSuaNhomTT = new FontAwesome.Sharp.IconButton();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pnGridView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTT = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTenNTT = new System.Windows.Forms.Label();
            this.lbTenNhomTT = new System.Windows.Forms.Label();
            this.dgvNhomTT = new System.Windows.Forms.DataGridView();
            this.clTenNhomTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaThuThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaCTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLyDoGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.erpPhanQuyen)).BeginInit();
            this.pnMain.SuspendLayout();
            this.pnThuThuat.SuspendLayout();
            this.pnNhomThuThuat.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnGridView.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTT)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomTT)).BeginInit();
            this.SuspendLayout();
            // 
            // erpPhanQuyen
            // 
            this.erpPhanQuyen.ContainerControl = this;
            // 
            // lbNhomThuThuat
            // 
            this.lbNhomThuThuat.AutoSize = true;
            this.lbNhomThuThuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhomThuThuat.ForeColor = System.Drawing.Color.Blue;
            this.lbNhomThuThuat.Location = new System.Drawing.Point(34, 21);
            this.lbNhomThuThuat.Name = "lbNhomThuThuat";
            this.lbNhomThuThuat.Size = new System.Drawing.Size(291, 33);
            this.lbNhomThuThuat.TabIndex = 34;
            this.lbNhomThuThuat.Text = "NHÓM THỦ THUẬT";
            // 
            // lbThuThuat
            // 
            this.lbThuThuat.AutoSize = true;
            this.lbThuThuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuThuat.ForeColor = System.Drawing.Color.Blue;
            this.lbThuThuat.Location = new System.Drawing.Point(655, 21);
            this.lbThuThuat.Name = "lbThuThuat";
            this.lbThuThuat.Size = new System.Drawing.Size(189, 33);
            this.lbThuThuat.TabIndex = 35;
            this.lbThuThuat.Text = "THỦ THUẬT";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnThuThuat);
            this.pnMain.Controls.Add(this.pnNhomThuThuat);
            this.pnMain.Controls.Add(this.pnTitle);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1124, 129);
            this.pnMain.TabIndex = 36;
            // 
            // pnThuThuat
            // 
            this.pnThuThuat.BackColor = System.Drawing.Color.DarkGray;
            this.pnThuThuat.Controls.Add(this.lbMiniThuThuat);
            this.pnThuThuat.Controls.Add(this.ibtnRefresh);
            this.pnThuThuat.Controls.Add(this.ibtnThem);
            this.pnThuThuat.Controls.Add(this.ibtnXoa);
            this.pnThuThuat.Controls.Add(this.ibtnSua);
            this.pnThuThuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThuThuat.Location = new System.Drawing.Point(359, 74);
            this.pnThuThuat.Name = "pnThuThuat";
            this.pnThuThuat.Size = new System.Drawing.Size(765, 55);
            this.pnThuThuat.TabIndex = 33;
            // 
            // lbMiniThuThuat
            // 
            this.lbMiniThuThuat.AutoSize = true;
            this.lbMiniThuThuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMiniThuThuat.Location = new System.Drawing.Point(15, 19);
            this.lbMiniThuThuat.Name = "lbMiniThuThuat";
            this.lbMiniThuThuat.Size = new System.Drawing.Size(62, 16);
            this.lbMiniThuThuat.TabIndex = 28;
            this.lbMiniThuThuat.Text = "Thủ thuật";
            // 
            // ibtnRefresh
            // 
            this.ibtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnRefresh.IconColor = System.Drawing.Color.Black;
            this.ibtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefresh.IconSize = 19;
            this.ibtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.Location = new System.Drawing.Point(457, 16);
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
            this.ibtnThem.Location = new System.Drawing.Point(244, 16);
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
            this.ibtnXoa.Location = new System.Drawing.Point(386, 16);
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
            this.ibtnSua.Location = new System.Drawing.Point(315, 16);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(65, 23);
            this.ibtnSua.TabIndex = 25;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = true;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // pnNhomThuThuat
            // 
            this.pnNhomThuThuat.BackColor = System.Drawing.Color.LightGray;
            this.pnNhomThuThuat.Controls.Add(this.ibtnThemNhomTT);
            this.pnNhomThuThuat.Controls.Add(this.ibtnXoaNhomTT);
            this.pnNhomThuThuat.Controls.Add(this.ibtnSuaNhomTT);
            this.pnNhomThuThuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNhomThuThuat.Location = new System.Drawing.Point(0, 74);
            this.pnNhomThuThuat.Name = "pnNhomThuThuat";
            this.pnNhomThuThuat.Size = new System.Drawing.Size(359, 55);
            this.pnNhomThuThuat.TabIndex = 1;
            // 
            // ibtnThemNhomTT
            // 
            this.ibtnThemNhomTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnThemNhomTT.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnThemNhomTT.IconColor = System.Drawing.Color.Black;
            this.ibtnThemNhomTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThemNhomTT.IconSize = 20;
            this.ibtnThemNhomTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThemNhomTT.Location = new System.Drawing.Point(62, 16);
            this.ibtnThemNhomTT.Name = "ibtnThemNhomTT";
            this.ibtnThemNhomTT.Size = new System.Drawing.Size(65, 23);
            this.ibtnThemNhomTT.TabIndex = 30;
            this.ibtnThemNhomTT.Text = "Thêm";
            this.ibtnThemNhomTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThemNhomTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThemNhomTT.UseVisualStyleBackColor = true;
            this.ibtnThemNhomTT.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ibtnXoaNhomTT
            // 
            this.ibtnXoaNhomTT.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoaNhomTT.IconColor = System.Drawing.Color.Black;
            this.ibtnXoaNhomTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoaNhomTT.IconSize = 19;
            this.ibtnXoaNhomTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoaNhomTT.Location = new System.Drawing.Point(204, 16);
            this.ibtnXoaNhomTT.Name = "ibtnXoaNhomTT";
            this.ibtnXoaNhomTT.Size = new System.Drawing.Size(65, 23);
            this.ibtnXoaNhomTT.TabIndex = 32;
            this.ibtnXoaNhomTT.Text = "Xóa";
            this.ibtnXoaNhomTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoaNhomTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoaNhomTT.UseVisualStyleBackColor = true;
            this.ibtnXoaNhomTT.Click += new System.EventHandler(this.ibtnXoaNhomTT_Click);
            // 
            // ibtnSuaNhomTT
            // 
            this.ibtnSuaNhomTT.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.ibtnSuaNhomTT.IconColor = System.Drawing.Color.Black;
            this.ibtnSuaNhomTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSuaNhomTT.IconSize = 19;
            this.ibtnSuaNhomTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSuaNhomTT.Location = new System.Drawing.Point(133, 16);
            this.ibtnSuaNhomTT.Name = "ibtnSuaNhomTT";
            this.ibtnSuaNhomTT.Size = new System.Drawing.Size(65, 23);
            this.ibtnSuaNhomTT.TabIndex = 31;
            this.ibtnSuaNhomTT.Text = "Sửa";
            this.ibtnSuaNhomTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSuaNhomTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSuaNhomTT.UseVisualStyleBackColor = true;
            this.ibtnSuaNhomTT.Click += new System.EventHandler(this.ibtnSuaNhomTT_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTitle.Controls.Add(this.lbNhomThuThuat);
            this.pnTitle.Controls.Add(this.lbThuThuat);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1124, 74);
            this.pnTitle.TabIndex = 0;
            // 
            // pnGridView
            // 
            this.pnGridView.Controls.Add(this.panel1);
            this.pnGridView.Controls.Add(this.dgvNhomTT);
            this.pnGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGridView.Location = new System.Drawing.Point(0, 129);
            this.pnGridView.Name = "pnGridView";
            this.pnGridView.Size = new System.Drawing.Size(1124, 521);
            this.pnGridView.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTT);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(359, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 521);
            this.panel1.TabIndex = 32;
            // 
            // dgvTT
            // 
            this.dgvTT.AllowUserToAddRows = false;
            this.dgvTT.AllowUserToDeleteRows = false;
            this.dgvTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTenTT,
            this.clDonGia,
            this.clGiamGia,
            this.clMaThuThuat,
            this.clMaCTTT,
            this.clLyDoGiamGia});
            this.dgvTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTT.Location = new System.Drawing.Point(0, 43);
            this.dgvTT.Name = "dgvTT";
            this.dgvTT.ReadOnly = true;
            this.dgvTT.Size = new System.Drawing.Size(765, 478);
            this.dgvTT.TabIndex = 34;
            this.dgvTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTT_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTenNTT);
            this.panel2.Controls.Add(this.lbTenNhomTT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 43);
            this.panel2.TabIndex = 35;
            // 
            // lbTenNTT
            // 
            this.lbTenNTT.AutoSize = true;
            this.lbTenNTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNTT.ForeColor = System.Drawing.Color.Blue;
            this.lbTenNTT.Location = new System.Drawing.Point(205, 8);
            this.lbTenNTT.Name = "lbTenNTT";
            this.lbTenNTT.Size = new System.Drawing.Size(19, 25);
            this.lbTenNTT.TabIndex = 36;
            this.lbTenNTT.Text = " ";
            // 
            // lbTenNhomTT
            // 
            this.lbTenNhomTT.AutoSize = true;
            this.lbTenNhomTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhomTT.ForeColor = System.Drawing.Color.Blue;
            this.lbTenNhomTT.Location = new System.Drawing.Point(13, 8);
            this.lbTenNhomTT.Name = "lbTenNhomTT";
            this.lbTenNhomTT.Size = new System.Drawing.Size(186, 25);
            this.lbTenNhomTT.TabIndex = 36;
            this.lbTenNhomTT.Text = "Nhóm thủ thuật: ";
            // 
            // dgvNhomTT
            // 
            this.dgvNhomTT.AllowUserToAddRows = false;
            this.dgvNhomTT.AllowUserToDeleteRows = false;
            this.dgvNhomTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTenNhomTT,
            this.clMaTT});
            this.dgvNhomTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNhomTT.Location = new System.Drawing.Point(0, 0);
            this.dgvNhomTT.Name = "dgvNhomTT";
            this.dgvNhomTT.ReadOnly = true;
            this.dgvNhomTT.Size = new System.Drawing.Size(359, 521);
            this.dgvNhomTT.TabIndex = 30;
            this.dgvNhomTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomTT_CellClick);
            // 
            // clTenNhomTT
            // 
            this.clTenNhomTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenNhomTT.DataPropertyName = "TenNhomTT";
            this.clTenNhomTT.HeaderText = "Tên nhóm thủ thuật";
            this.clTenNhomTT.Name = "clTenNhomTT";
            this.clTenNhomTT.ReadOnly = true;
            // 
            // clMaTT
            // 
            this.clMaTT.DataPropertyName = "MaTT";
            this.clMaTT.HeaderText = "Mã thủ thuật";
            this.clMaTT.Name = "clMaTT";
            this.clMaTT.ReadOnly = true;
            this.clMaTT.Visible = false;
            // 
            // clTenTT
            // 
            this.clTenTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenTT.DataPropertyName = "TenTT";
            this.clTenTT.HeaderText = "Tên thủ thuật";
            this.clTenTT.Name = "clTenTT";
            this.clTenTT.ReadOnly = true;
            // 
            // clDonGia
            // 
            this.clDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDonGia.DataPropertyName = "DonGia";
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            // 
            // clGiamGia
            // 
            this.clGiamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGiamGia.DataPropertyName = "GiamGia";
            this.clGiamGia.HeaderText = "Giảm giá";
            this.clGiamGia.Name = "clGiamGia";
            this.clGiamGia.ReadOnly = true;
            // 
            // clMaThuThuat
            // 
            this.clMaThuThuat.DataPropertyName = "MaTT";
            this.clMaThuThuat.HeaderText = "Mã thủ thuật";
            this.clMaThuThuat.Name = "clMaThuThuat";
            this.clMaThuThuat.ReadOnly = true;
            this.clMaThuThuat.Visible = false;
            // 
            // clMaCTTT
            // 
            this.clMaCTTT.DataPropertyName = "MaCTTT";
            this.clMaCTTT.HeaderText = "Mã chi tiết thủ thuật";
            this.clMaCTTT.Name = "clMaCTTT";
            this.clMaCTTT.ReadOnly = true;
            this.clMaCTTT.Visible = false;
            // 
            // clLyDoGiamGia
            // 
            this.clLyDoGiamGia.DataPropertyName = "LyDoGiamGia";
            this.clLyDoGiamGia.HeaderText = "Lý do giảm giá";
            this.clLyDoGiamGia.Name = "clLyDoGiamGia";
            this.clLyDoGiamGia.ReadOnly = true;
            this.clLyDoGiamGia.Visible = false;
            // 
            // fNhomThuThuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.pnGridView);
            this.Controls.Add(this.pnMain);
            this.Name = "fNhomThuThuat";
            this.Text = "ThuThuat";
            ((System.ComponentModel.ISupportInitialize)(this.erpPhanQuyen)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnThuThuat.ResumeLayout(false);
            this.pnThuThuat.PerformLayout();
            this.pnNhomThuThuat.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnGridView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider erpPhanQuyen;
        private System.Windows.Forms.Panel pnGridView;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnNhomThuThuat;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbNhomThuThuat;
        private System.Windows.Forms.Label lbThuThuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTenNhomTT;
        private System.Windows.Forms.Panel pnThuThuat;
        private System.Windows.Forms.Label lbMiniThuThuat;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnSua;
        public System.Windows.Forms.DataGridView dgvTT;
        public System.Windows.Forms.Label lbTenNTT;
        private FontAwesome.Sharp.IconButton ibtnThemNhomTT;
        private FontAwesome.Sharp.IconButton ibtnXoaNhomTT;
        private FontAwesome.Sharp.IconButton ibtnSuaNhomTT;
        public System.Windows.Forms.DataGridView dgvNhomTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhomTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaThuThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLyDoGiamGia;
    }
}