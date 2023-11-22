
namespace QLNhaKhoa
{
    partial class fLichHen
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
            this.lbThongTinChiTiet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.dtpGio = new System.Windows.Forms.DateTimePicker();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cbxBacSy = new System.Windows.Forms.ComboBox();
            this.lbBacSy = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lbNgayGio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbLichHen = new System.Windows.Forms.Label();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.clMaLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmLichHen = new System.Windows.Forms.Timer(this.components);
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
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
            this.pnTitle.Size = new System.Drawing.Size(550, 55);
            this.pnTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Navy;
            this.lbTitle.Location = new System.Drawing.Point(96, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(344, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "ĐẶT LỊCH HẸN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbThongTinChiTiet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 21);
            this.panel1.TabIndex = 2;
            // 
            // lbThongTinChiTiet
            // 
            this.lbThongTinChiTiet.AutoSize = true;
            this.lbThongTinChiTiet.BackColor = System.Drawing.Color.LightGray;
            this.lbThongTinChiTiet.Location = new System.Drawing.Point(12, 3);
            this.lbThongTinChiTiet.Name = "lbThongTinChiTiet";
            this.lbThongTinChiTiet.Size = new System.Drawing.Size(86, 13);
            this.lbThongTinChiTiet.TabIndex = 0;
            this.lbThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ibtnLuu);
            this.panel2.Controls.Add(this.dtpGio);
            this.panel2.Controls.Add(this.ibtnRefresh);
            this.panel2.Controls.Add(this.ibtnThem);
            this.panel2.Controls.Add(this.ibtnXoa);
            this.panel2.Controls.Add(this.ibtnSua);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.lbGhiChu);
            this.panel2.Controls.Add(this.lbNoiDung);
            this.panel2.Controls.Add(this.txtNoiDung);
            this.panel2.Controls.Add(this.cbxBacSy);
            this.panel2.Controls.Add(this.lbBacSy);
            this.panel2.Controls.Add(this.dtpNgay);
            this.panel2.Controls.Add(this.lbNgayGio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 189);
            this.panel2.TabIndex = 3;
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.BackColor = System.Drawing.Color.Gainsboro;
            this.ibtnLuu.FlatAppearance.BorderSize = 0;
            this.ibtnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnLuu.IconColor = System.Drawing.Color.Black;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.IconSize = 18;
            this.ibtnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.Location = new System.Drawing.Point(208, 152);
            this.ibtnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(60, 23);
            this.ibtnLuu.TabIndex = 7;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // dtpGio
            // 
            this.dtpGio.Location = new System.Drawing.Point(196, 4);
            this.dtpGio.Name = "dtpGio";
            this.dtpGio.Size = new System.Drawing.Size(86, 20);
            this.dtpGio.TabIndex = 1;
            // 
            // ibtnRefresh
            // 
            this.ibtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnRefresh.IconColor = System.Drawing.Color.Black;
            this.ibtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefresh.IconSize = 19;
            this.ibtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.Location = new System.Drawing.Point(346, 152);
            this.ibtnRefresh.Name = "ibtnRefresh";
            this.ibtnRefresh.Size = new System.Drawing.Size(76, 23);
            this.ibtnRefresh.TabIndex = 9;
            this.ibtnRefresh.Text = "Refresh";
            this.ibtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnRefresh.UseVisualStyleBackColor = true;
            this.ibtnRefresh.Click += new System.EventHandler(this.ibtnRefresh_Click);
            // 
            // ibtnThem
            // 
            this.ibtnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnThem.IconColor = System.Drawing.Color.Black;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.IconSize = 20;
            this.ibtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnThem.Location = new System.Drawing.Point(65, 152);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(65, 23);
            this.ibtnThem.TabIndex = 5;
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
            this.ibtnXoa.Location = new System.Drawing.Point(275, 152);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(65, 23);
            this.ibtnXoa.TabIndex = 8;
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
            this.ibtnSua.Location = new System.Drawing.Point(136, 152);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(65, 23);
            this.ibtnSua.TabIndex = 6;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = true;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(65, 99);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(471, 47);
            this.txtGhiChu.TabIndex = 4;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(10, 102);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(44, 13);
            this.lbGhiChu.TabIndex = 6;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Location = new System.Drawing.Point(10, 33);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(50, 13);
            this.lbNoiDung.TabIndex = 5;
            this.lbNoiDung.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(65, 30);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(471, 63);
            this.txtNoiDung.TabIndex = 3;
            // 
            // cbxBacSy
            // 
            this.cbxBacSy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBacSy.Enabled = false;
            this.cbxBacSy.FormattingEnabled = true;
            this.cbxBacSy.Location = new System.Drawing.Point(333, 5);
            this.cbxBacSy.Name = "cbxBacSy";
            this.cbxBacSy.Size = new System.Drawing.Size(203, 21);
            this.cbxBacSy.TabIndex = 2;
            // 
            // lbBacSy
            // 
            this.lbBacSy.AutoSize = true;
            this.lbBacSy.Location = new System.Drawing.Point(288, 8);
            this.lbBacSy.Name = "lbBacSy";
            this.lbBacSy.Size = new System.Drawing.Size(39, 13);
            this.lbBacSy.TabIndex = 2;
            this.lbBacSy.Text = "Bác sỹ";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(65, 4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(125, 20);
            this.dtpNgay.TabIndex = 0;
            // 
            // lbNgayGio
            // 
            this.lbNgayGio.AutoSize = true;
            this.lbNgayGio.Location = new System.Drawing.Point(10, 10);
            this.lbNgayGio.Name = "lbNgayGio";
            this.lbNgayGio.Size = new System.Drawing.Size(49, 13);
            this.lbNgayGio.TabIndex = 0;
            this.lbNgayGio.Text = "Ngày giờ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbLichHen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 21);
            this.panel3.TabIndex = 4;
            // 
            // lbLichHen
            // 
            this.lbLichHen.AutoSize = true;
            this.lbLichHen.BackColor = System.Drawing.Color.LightGray;
            this.lbLichHen.Location = new System.Drawing.Point(12, 3);
            this.lbLichHen.Name = "lbLichHen";
            this.lbLichHen.Size = new System.Drawing.Size(129, 13);
            this.lbLichHen.TabIndex = 0;
            this.lbLichHen.Text = "Lịch hẹn của bệnh nhân: ";
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.AllowUserToAddRows = false;
            this.dgvLichHen.AllowUserToDeleteRows = false;
            this.dgvLichHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaLH,
            this.clMaNV,
            this.clNgay,
            this.clGio,
            this.clHoTen,
            this.clNoiDung,
            this.clGhiChu});
            this.dgvLichHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHen.Location = new System.Drawing.Point(0, 286);
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.ReadOnly = true;
            this.dgvLichHen.Size = new System.Drawing.Size(550, 211);
            this.dgvLichHen.TabIndex = 10;
            this.dgvLichHen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichHen_CellClick);
            this.dgvLichHen.Sorted += new System.EventHandler(this.dgvLichHen_Sorted);
            // 
            // clMaLH
            // 
            this.clMaLH.DataPropertyName = "MaLH";
            this.clMaLH.HeaderText = "Mã lịch hẹn";
            this.clMaLH.Name = "clMaLH";
            this.clMaLH.ReadOnly = true;
            this.clMaLH.Visible = false;
            // 
            // clMaNV
            // 
            this.clMaNV.DataPropertyName = "MaNV";
            this.clMaNV.HeaderText = "Mã nhân viên";
            this.clMaNV.Name = "clMaNV";
            this.clMaNV.ReadOnly = true;
            this.clMaNV.Visible = false;
            // 
            // clNgay
            // 
            this.clNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgay.DataPropertyName = "Ngay";
            this.clNgay.HeaderText = "Ngày";
            this.clNgay.Name = "clNgay";
            this.clNgay.ReadOnly = true;
            // 
            // clGio
            // 
            this.clGio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGio.DataPropertyName = "Gio";
            this.clGio.HeaderText = "Giờ";
            this.clGio.Name = "clGio";
            this.clGio.ReadOnly = true;
            // 
            // clHoTen
            // 
            this.clHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTen.DataPropertyName = "HoTen";
            this.clHoTen.HeaderText = "Bác sỹ";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clNoiDung
            // 
            this.clNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNoiDung.DataPropertyName = "NoiDung";
            this.clNoiDung.HeaderText = "Nội dung";
            this.clNoiDung.Name = "clNoiDung";
            this.clNoiDung.ReadOnly = true;
            // 
            // clGhiChu
            // 
            this.clGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            // 
            // tmLichHen
            // 
            this.tmLichHen.Interval = 300;
            this.tmLichHen.Tick += new System.EventHandler(this.tmLichHen_Tick);
            // 
            // fLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(550, 497);
            this.Controls.Add(this.dgvLichHen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.MaximizeBox = false;
            this.Name = "fLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichHen";
            this.Load += new System.EventHandler(this.fLichHen_Load);
            this.pnTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbThongTinChiTiet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNgayGio;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cbxBacSy;
        private System.Windows.Forms.Label lbBacSy;
        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbLichHen;
        private System.Windows.Forms.DataGridView dgvLichHen;
        private System.Windows.Forms.DateTimePicker dtpGio;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.Timer tmLichHen;
    }
}