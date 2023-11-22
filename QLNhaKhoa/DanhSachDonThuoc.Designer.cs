
namespace QLNhaKhoa
{
    partial class fDanhSachDonThuoc
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lbNgayKetThuc = new System.Windows.Forms.Label();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lbNguoiKe = new System.Windows.Forms.Label();
            this.txtNguoiKe = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbHoTenBN = new System.Windows.Forms.Label();
            this.txtSoHS = new System.Windows.Forms.TextBox();
            this.lbSoHS = new System.Windows.Forms.Label();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.dgvDanhSachDonThuoc = new System.Windows.Forms.DataGridView();
            this.clMaDThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonThuoc)).BeginInit();
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
            this.pnTitle.TabIndex = 2;
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
            this.lbTitle.Text = "DANH SÁCH ĐƠN THUỐC";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ibtnXoa);
            this.panel1.Controls.Add(this.dtpNgayKetThuc);
            this.panel1.Controls.Add(this.lbNgayKetThuc);
            this.panel1.Controls.Add(this.lbNgayBatDau);
            this.panel1.Controls.Add(this.dtpNgayBatDau);
            this.panel1.Controls.Add(this.lbNguoiKe);
            this.panel1.Controls.Add(this.txtNguoiKe);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.lbHoTenBN);
            this.panel1.Controls.Add(this.txtSoHS);
            this.panel1.Controls.Add(this.lbSoHS);
            this.panel1.Controls.Add(this.ibtnTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 55);
            this.panel1.TabIndex = 4;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(480, 23);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(123, 20);
            this.dtpNgayKetThuc.TabIndex = 4;
            // 
            // lbNgayKetThuc
            // 
            this.lbNgayKetThuc.AutoSize = true;
            this.lbNgayKetThuc.Location = new System.Drawing.Point(516, 6);
            this.lbNgayKetThuc.Name = "lbNgayKetThuc";
            this.lbNgayKetThuc.Size = new System.Drawing.Size(53, 13);
            this.lbNgayKetThuc.TabIndex = 45;
            this.lbNgayKetThuc.Text = "Đến ngày";
            // 
            // lbNgayBatDau
            // 
            this.lbNgayBatDau.AutoSize = true;
            this.lbNgayBatDau.Location = new System.Drawing.Point(391, 6);
            this.lbNgayBatDau.Name = "lbNgayBatDau";
            this.lbNgayBatDau.Size = new System.Drawing.Size(46, 13);
            this.lbNgayBatDau.TabIndex = 44;
            this.lbNgayBatDau.Text = "Từ ngày";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(351, 23);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(123, 20);
            this.dtpNgayBatDau.TabIndex = 3;
            // 
            // lbNguoiKe
            // 
            this.lbNguoiKe.AutoSize = true;
            this.lbNguoiKe.Location = new System.Drawing.Point(243, 6);
            this.lbNguoiKe.Name = "lbNguoiKe";
            this.lbNguoiKe.Size = new System.Drawing.Size(102, 13);
            this.lbNguoiKe.TabIndex = 38;
            this.lbNguoiKe.Text = "Người kê đơn thuốc";
            // 
            // txtNguoiKe
            // 
            this.txtNguoiKe.Location = new System.Drawing.Point(245, 22);
            this.txtNguoiKe.Name = "txtNguoiKe";
            this.txtNguoiKe.Size = new System.Drawing.Size(100, 20);
            this.txtNguoiKe.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(117, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(122, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // lbHoTenBN
            // 
            this.lbHoTenBN.AutoSize = true;
            this.lbHoTenBN.Location = new System.Drawing.Point(131, 6);
            this.lbHoTenBN.Name = "lbHoTenBN";
            this.lbHoTenBN.Size = new System.Drawing.Size(93, 13);
            this.lbHoTenBN.TabIndex = 35;
            this.lbHoTenBN.Text = "Họ tên bệnh nhân";
            // 
            // txtSoHS
            // 
            this.txtSoHS.Location = new System.Drawing.Point(11, 22);
            this.txtSoHS.Name = "txtSoHS";
            this.txtSoHS.Size = new System.Drawing.Size(100, 20);
            this.txtSoHS.TabIndex = 0;
            this.txtSoHS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoHS_KeyPress);
            // 
            // lbSoHS
            // 
            this.lbSoHS.AutoSize = true;
            this.lbSoHS.Location = new System.Drawing.Point(34, 6);
            this.lbSoHS.Name = "lbSoHS";
            this.lbSoHS.Size = new System.Drawing.Size(49, 13);
            this.lbSoHS.TabIndex = 33;
            this.lbSoHS.Text = "Số hồ sơ";
            // 
            // ibtnTimKiem
            // 
            this.ibtnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnTimKiem.IconColor = System.Drawing.Color.Black;
            this.ibtnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTimKiem.IconSize = 15;
            this.ibtnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ibtnTimKiem.Location = new System.Drawing.Point(625, 20);
            this.ibtnTimKiem.Name = "ibtnTimKiem";
            this.ibtnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.ibtnTimKiem.TabIndex = 5;
            this.ibtnTimKiem.Text = "Tìm kiếm";
            this.ibtnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = true;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // dgvDanhSachDonThuoc
            // 
            this.dgvDanhSachDonThuoc.AllowUserToAddRows = false;
            this.dgvDanhSachDonThuoc.AllowUserToDeleteRows = false;
            this.dgvDanhSachDonThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDonThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaDThuoc,
            this.clMaDT,
            this.clMaBN,
            this.clHoTenBN,
            this.clHoTenNV,
            this.clNgayKe});
            this.dgvDanhSachDonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachDonThuoc.Location = new System.Drawing.Point(0, 110);
            this.dgvDanhSachDonThuoc.Name = "dgvDanhSachDonThuoc";
            this.dgvDanhSachDonThuoc.ReadOnly = true;
            this.dgvDanhSachDonThuoc.Size = new System.Drawing.Size(1124, 540);
            this.dgvDanhSachDonThuoc.TabIndex = 6;
            this.dgvDanhSachDonThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDonThuoc_CellClick);
            this.dgvDanhSachDonThuoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDonThuoc_CellDoubleClick);
            // 
            // clMaDThuoc
            // 
            this.clMaDThuoc.DataPropertyName = "MaDThuoc";
            this.clMaDThuoc.HeaderText = "Mã đơn thuốc";
            this.clMaDThuoc.Name = "clMaDThuoc";
            this.clMaDThuoc.ReadOnly = true;
            this.clMaDThuoc.Visible = false;
            // 
            // clMaDT
            // 
            this.clMaDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaDT.DataPropertyName = "MaDT";
            this.clMaDT.HeaderText = "Mã điều trị";
            this.clMaDT.Name = "clMaDT";
            this.clMaDT.ReadOnly = true;
            this.clMaDT.Visible = false;
            // 
            // clMaBN
            // 
            this.clMaBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaBN.DataPropertyName = "MaBN";
            this.clMaBN.HeaderText = "Số hồ sơ";
            this.clMaBN.Name = "clMaBN";
            this.clMaBN.ReadOnly = true;
            // 
            // clHoTenBN
            // 
            this.clHoTenBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTenBN.DataPropertyName = "HoTenBN";
            this.clHoTenBN.HeaderText = "Họ tên bệnh nhân";
            this.clHoTenBN.Name = "clHoTenBN";
            this.clHoTenBN.ReadOnly = true;
            // 
            // clHoTenNV
            // 
            this.clHoTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTenNV.DataPropertyName = "HoTenNV";
            this.clHoTenNV.HeaderText = "Người kê đơn thuốc";
            this.clHoTenNV.Name = "clHoTenNV";
            this.clHoTenNV.ReadOnly = true;
            // 
            // clNgayKe
            // 
            this.clNgayKe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgayKe.DataPropertyName = "NgayKe";
            this.clNgayKe.HeaderText = "Ngày kê";
            this.clNgayKe.Name = "clNgayKe";
            this.clNgayKe.ReadOnly = true;
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoa.IconColor = System.Drawing.Color.Black;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.IconSize = 19;
            this.ibtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoa.Location = new System.Drawing.Point(706, 20);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(65, 23);
            this.ibtnXoa.TabIndex = 46;
            this.ibtnXoa.Text = "Xóa";
            this.ibtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoa.UseVisualStyleBackColor = true;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // fDanhSachDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.dgvDanhSachDonThuoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.Name = "fDanhSachDonThuoc";
            this.Text = "DanhSachDonThuoc";
            this.pnTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNguoiKe;
        private System.Windows.Forms.TextBox txtNguoiKe;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbHoTenBN;
        private System.Windows.Forms.TextBox txtSoHS;
        private System.Windows.Forms.Label lbSoHS;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSachDonThuoc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lbNgayKetThuc;
        private System.Windows.Forms.Label lbNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayKe;
        private FontAwesome.Sharp.IconButton ibtnXoa;
    }
}