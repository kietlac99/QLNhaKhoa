
namespace QLNhaKhoa
{
    partial class fTTPhieuThu
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
            this.dgvPhieuThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.lbSoHS = new System.Windows.Forms.Label();
            this.txtSoHS = new System.Windows.Forms.TextBox();
            this.lbHoTenBN = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNguoiLapPhieu = new System.Windows.Forms.TextBox();
            this.lbNguoiLapPhieu = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.lbNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.clMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnTitle.TabIndex = 1;
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
            this.lbTitle.Text = "PHIẾU THU";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPhieuThu
            // 
            this.dgvPhieuThu.AllowUserToAddRows = false;
            this.dgvPhieuThu.AllowUserToDeleteRows = false;
            this.dgvPhieuThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPT,
            this.clTenTK,
            this.clMaBN,
            this.clHoTen,
            this.clNgayThu});
            this.dgvPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuThu.Location = new System.Drawing.Point(0, 110);
            this.dgvPhieuThu.Name = "dgvPhieuThu";
            this.dgvPhieuThu.ReadOnly = true;
            this.dgvPhieuThu.Size = new System.Drawing.Size(1124, 540);
            this.dgvPhieuThu.TabIndex = 2;
            this.dgvPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThu_CellClick);
            this.dgvPhieuThu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuThu_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpNgayKetThuc);
            this.panel1.Controls.Add(this.lbNgayKetThuc);
            this.panel1.Controls.Add(this.lbNgayBatDau);
            this.panel1.Controls.Add(this.dtpNgayBatDau);
            this.panel1.Controls.Add(this.lbNguoiLapPhieu);
            this.panel1.Controls.Add(this.txtNguoiLapPhieu);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.lbHoTenBN);
            this.panel1.Controls.Add(this.txtSoHS);
            this.panel1.Controls.Add(this.lbSoHS);
            this.panel1.Controls.Add(this.ibtnTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 55);
            this.panel1.TabIndex = 3;
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
            this.ibtnTimKiem.TabIndex = 32;
            this.ibtnTimKiem.Text = "Tìm kiếm";
            this.ibtnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = true;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
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
            // txtSoHS
            // 
            this.txtSoHS.Location = new System.Drawing.Point(11, 22);
            this.txtSoHS.Name = "txtSoHS";
            this.txtSoHS.Size = new System.Drawing.Size(100, 20);
            this.txtSoHS.TabIndex = 34;
            this.txtSoHS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHS_KeyPress);
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
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(117, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(122, 20);
            this.txtHoTen.TabIndex = 36;
            // 
            // txtNguoiLapPhieu
            // 
            this.txtNguoiLapPhieu.Location = new System.Drawing.Point(245, 22);
            this.txtNguoiLapPhieu.Name = "txtNguoiLapPhieu";
            this.txtNguoiLapPhieu.Size = new System.Drawing.Size(100, 20);
            this.txtNguoiLapPhieu.TabIndex = 37;
            // 
            // lbNguoiLapPhieu
            // 
            this.lbNguoiLapPhieu.AutoSize = true;
            this.lbNguoiLapPhieu.Location = new System.Drawing.Point(255, 6);
            this.lbNguoiLapPhieu.Name = "lbNguoiLapPhieu";
            this.lbNguoiLapPhieu.Size = new System.Drawing.Size(81, 13);
            this.lbNguoiLapPhieu.TabIndex = 38;
            this.lbNguoiLapPhieu.Text = "Người lập phiếu";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(351, 23);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(123, 20);
            this.dtpNgayBatDau.TabIndex = 39;
            // 
            // lbNgayBatDau
            // 
            this.lbNgayBatDau.AutoSize = true;
            this.lbNgayBatDau.Location = new System.Drawing.Point(391, 6);
            this.lbNgayBatDau.Name = "lbNgayBatDau";
            this.lbNgayBatDau.Size = new System.Drawing.Size(46, 13);
            this.lbNgayBatDau.TabIndex = 40;
            this.lbNgayBatDau.Text = "Từ ngày";
            // 
            // lbNgayKetThuc
            // 
            this.lbNgayKetThuc.AutoSize = true;
            this.lbNgayKetThuc.Location = new System.Drawing.Point(516, 6);
            this.lbNgayKetThuc.Name = "lbNgayKetThuc";
            this.lbNgayKetThuc.Size = new System.Drawing.Size(53, 13);
            this.lbNgayKetThuc.TabIndex = 41;
            this.lbNgayKetThuc.Text = "Đến ngày";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(480, 23);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(123, 20);
            this.dtpNgayKetThuc.TabIndex = 42;
            // 
            // clMaPT
            // 
            this.clMaPT.DataPropertyName = "MaPT";
            this.clMaPT.HeaderText = "Mã phiếu thu";
            this.clMaPT.Name = "clMaPT";
            this.clMaPT.ReadOnly = true;
            this.clMaPT.Visible = false;
            // 
            // clTenTK
            // 
            this.clTenTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenTK.DataPropertyName = "TenTK";
            this.clTenTK.HeaderText = "Người lập phiếu";
            this.clTenTK.Name = "clTenTK";
            this.clTenTK.ReadOnly = true;
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
            this.clHoTen.HeaderText = "Họ tên bệnh nhân";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clNgayThu
            // 
            this.clNgayThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgayThu.DataPropertyName = "NgayThu";
            this.clNgayThu.HeaderText = "Ngày thu";
            this.clNgayThu.Name = "clNgayThu";
            this.clNgayThu.ReadOnly = true;
            // 
            // fTTPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.dgvPhieuThu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.Name = "fTTPhieuThu";
            this.Text = "TTPhieuThu";
            this.pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvPhieuThu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private System.Windows.Forms.TextBox txtSoHS;
        private System.Windows.Forms.Label lbSoHS;
        private System.Windows.Forms.Label lbHoTenBN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNguoiLapPhieu;
        private System.Windows.Forms.Label lbNguoiLapPhieu;
        private System.Windows.Forms.Label lbNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lbNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayThu;
    }
}