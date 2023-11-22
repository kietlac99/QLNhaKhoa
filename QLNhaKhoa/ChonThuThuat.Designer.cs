
namespace QLNhaKhoa
{
    partial class fChonThuThuat
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
            this.lbChonThuThuat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnThuThuatDuocChon = new System.Windows.Forms.Panel();
            this.dgvThuThuatDuocChon = new System.Windows.Forms.DataGridView();
            this.clMaCTDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaCTThuThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenThuThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhaiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbThuThuatDuocChon = new System.Windows.Forms.Label();
            this.pnThuThuat = new System.Windows.Forms.Panel();
            this.dgvThuThuat = new System.Windows.Forms.DataGridView();
            this.clMaCTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaThuThuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbThuThuat = new System.Windows.Forms.Label();
            this.pnNhomTT = new System.Windows.Forms.Panel();
            this.dgvNhomTT = new System.Windows.Forms.DataGridView();
            this.clMaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNhomTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbNhomThuThuat = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnThuThuatDuocChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThuatDuocChon)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnThuThuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThuat)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnNhomTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomTT)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTitle.Controls.Add(this.lbChonThuThuat);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(800, 55);
            this.pnTitle.TabIndex = 2;
            // 
            // lbChonThuThuat
            // 
            this.lbChonThuThuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChonThuThuat.BackColor = System.Drawing.Color.Transparent;
            this.lbChonThuThuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChonThuThuat.ForeColor = System.Drawing.Color.Navy;
            this.lbChonThuThuat.Location = new System.Drawing.Point(140, 8);
            this.lbChonThuThuat.Name = "lbChonThuThuat";
            this.lbChonThuThuat.Size = new System.Drawing.Size(522, 35);
            this.lbChonThuThuat.TabIndex = 0;
            this.lbChonThuThuat.Text = "CHỌN THỦ THUẬT ĐIỀU TRỊ";
            this.lbChonThuThuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnNhomTT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 395);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pnThuThuatDuocChon);
            this.panel2.Controls.Add(this.pnThuThuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 395);
            this.panel2.TabIndex = 1;
            // 
            // pnThuThuatDuocChon
            // 
            this.pnThuThuatDuocChon.Controls.Add(this.dgvThuThuatDuocChon);
            this.pnThuThuatDuocChon.Controls.Add(this.panel4);
            this.pnThuThuatDuocChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThuThuatDuocChon.Location = new System.Drawing.Point(0, 182);
            this.pnThuThuatDuocChon.Name = "pnThuThuatDuocChon";
            this.pnThuThuatDuocChon.Size = new System.Drawing.Size(596, 209);
            this.pnThuThuatDuocChon.TabIndex = 1;
            // 
            // dgvThuThuatDuocChon
            // 
            this.dgvThuThuatDuocChon.AllowUserToAddRows = false;
            this.dgvThuThuatDuocChon.AllowUserToDeleteRows = false;
            this.dgvThuThuatDuocChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuThuatDuocChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuThuatDuocChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCTDT,
            this.clMaCTThuThuat,
            this.clTenThuThuat,
            this.clSoLuong,
            this.clDG,
            this.clThanhTien,
            this.clGG,
            this.clPhaiThanhToan});
            this.dgvThuThuatDuocChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuThuatDuocChon.Location = new System.Drawing.Point(0, 21);
            this.dgvThuThuatDuocChon.Name = "dgvThuThuatDuocChon";
            this.dgvThuThuatDuocChon.ReadOnly = true;
            this.dgvThuThuatDuocChon.Size = new System.Drawing.Size(596, 188);
            this.dgvThuThuatDuocChon.TabIndex = 6;
            this.dgvThuThuatDuocChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuThuatDuocChon_CellClick);
            // 
            // clMaCTDT
            // 
            this.clMaCTDT.DataPropertyName = "MaCTDT";
            this.clMaCTDT.HeaderText = "Mã chi tiết điều trị";
            this.clMaCTDT.Name = "clMaCTDT";
            this.clMaCTDT.ReadOnly = true;
            this.clMaCTDT.Visible = false;
            // 
            // clMaCTThuThuat
            // 
            this.clMaCTThuThuat.DataPropertyName = "MaCTTT";
            this.clMaCTThuThuat.HeaderText = "Mã chi tiết thủ thuật";
            this.clMaCTThuThuat.Name = "clMaCTThuThuat";
            this.clMaCTThuThuat.ReadOnly = true;
            this.clMaCTThuThuat.Visible = false;
            // 
            // clTenThuThuat
            // 
            this.clTenThuThuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenThuThuat.DataPropertyName = "TenTT";
            this.clTenThuThuat.HeaderText = "Tên thủ thuật";
            this.clTenThuThuat.Name = "clTenThuThuat";
            this.clTenThuThuat.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clDG
            // 
            this.clDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clDG.DataPropertyName = "DonGia";
            this.clDG.HeaderText = "Đơn giá";
            this.clDG.Name = "clDG";
            this.clDG.ReadOnly = true;
            // 
            // clThanhTien
            // 
            this.clThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clThanhTien.DataPropertyName = "ThanhTien";
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // clGG
            // 
            this.clGG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGG.DataPropertyName = "GiamGia";
            this.clGG.HeaderText = "Giảm giá";
            this.clGG.Name = "clGG";
            this.clGG.ReadOnly = true;
            // 
            // clPhaiThanhToan
            // 
            this.clPhaiThanhToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clPhaiThanhToan.DataPropertyName = "PhaiThanhToan";
            this.clPhaiThanhToan.HeaderText = "Phải thanh toán";
            this.clPhaiThanhToan.Name = "clPhaiThanhToan";
            this.clPhaiThanhToan.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbThuThuatDuocChon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(596, 21);
            this.panel4.TabIndex = 5;
            // 
            // lbThuThuatDuocChon
            // 
            this.lbThuThuatDuocChon.AutoSize = true;
            this.lbThuThuatDuocChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuThuatDuocChon.Location = new System.Drawing.Point(217, 1);
            this.lbThuThuatDuocChon.Name = "lbThuThuatDuocChon";
            this.lbThuThuatDuocChon.Size = new System.Drawing.Size(157, 13);
            this.lbThuThuatDuocChon.TabIndex = 0;
            this.lbThuThuatDuocChon.Text = "THỦ THUẬT ĐƯỢC CHỌN";
            // 
            // pnThuThuat
            // 
            this.pnThuThuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThuThuat.Controls.Add(this.dgvThuThuat);
            this.pnThuThuat.Controls.Add(this.panel3);
            this.pnThuThuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThuThuat.Location = new System.Drawing.Point(0, 0);
            this.pnThuThuat.Name = "pnThuThuat";
            this.pnThuThuat.Size = new System.Drawing.Size(596, 182);
            this.pnThuThuat.TabIndex = 0;
            // 
            // dgvThuThuat
            // 
            this.dgvThuThuat.AllowUserToAddRows = false;
            this.dgvThuThuat.AllowUserToDeleteRows = false;
            this.dgvThuThuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuThuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuThuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCTTT,
            this.clMaThuThuat,
            this.clTenTT,
            this.clDonGia,
            this.clGiamGia});
            this.dgvThuThuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuThuat.Location = new System.Drawing.Point(0, 21);
            this.dgvThuThuat.Name = "dgvThuThuat";
            this.dgvThuThuat.ReadOnly = true;
            this.dgvThuThuat.Size = new System.Drawing.Size(594, 159);
            this.dgvThuThuat.TabIndex = 5;
            this.dgvThuThuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuThuat_CellClick);
            this.dgvThuThuat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuThuat_CellDoubleClick);
            // 
            // clMaCTTT
            // 
            this.clMaCTTT.DataPropertyName = "MaCTTT";
            this.clMaCTTT.HeaderText = "Mã chi tiết thủ thuật";
            this.clMaCTTT.Name = "clMaCTTT";
            this.clMaCTTT.ReadOnly = true;
            this.clMaCTTT.Visible = false;
            // 
            // clMaThuThuat
            // 
            this.clMaThuThuat.DataPropertyName = "MaTT";
            this.clMaThuThuat.HeaderText = "Mã nhóm thủ thuật";
            this.clMaThuThuat.Name = "clMaThuThuat";
            this.clMaThuThuat.ReadOnly = true;
            this.clMaThuThuat.Visible = false;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbThuThuat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 21);
            this.panel3.TabIndex = 4;
            // 
            // lbThuThuat
            // 
            this.lbThuThuat.AutoSize = true;
            this.lbThuThuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuThuat.Location = new System.Drawing.Point(260, 0);
            this.lbThuThuat.Name = "lbThuThuat";
            this.lbThuThuat.Size = new System.Drawing.Size(79, 13);
            this.lbThuThuat.TabIndex = 0;
            this.lbThuThuat.Text = "THỦ THUẬT";
            // 
            // pnNhomTT
            // 
            this.pnNhomTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnNhomTT.Controls.Add(this.dgvNhomTT);
            this.pnNhomTT.Controls.Add(this.panel7);
            this.pnNhomTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNhomTT.Location = new System.Drawing.Point(0, 0);
            this.pnNhomTT.Name = "pnNhomTT";
            this.pnNhomTT.Size = new System.Drawing.Size(200, 395);
            this.pnNhomTT.TabIndex = 0;
            // 
            // dgvNhomTT
            // 
            this.dgvNhomTT.AllowUserToAddRows = false;
            this.dgvNhomTT.AllowUserToDeleteRows = false;
            this.dgvNhomTT.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhomTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaTT,
            this.clTenNhomTT});
            this.dgvNhomTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhomTT.Location = new System.Drawing.Point(0, 21);
            this.dgvNhomTT.Name = "dgvNhomTT";
            this.dgvNhomTT.ReadOnly = true;
            this.dgvNhomTT.Size = new System.Drawing.Size(196, 370);
            this.dgvNhomTT.TabIndex = 4;
            this.dgvNhomTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomTT_CellClick);
            // 
            // clMaTT
            // 
            this.clMaTT.DataPropertyName = "MaTT";
            this.clMaTT.HeaderText = "Mã nhóm thủ thuật";
            this.clMaTT.Name = "clMaTT";
            this.clMaTT.ReadOnly = true;
            this.clMaTT.Visible = false;
            // 
            // clTenNhomTT
            // 
            this.clTenNhomTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenNhomTT.DataPropertyName = "TenNhomTT";
            this.clTenNhomTT.HeaderText = "Tên nhóm thủ thuật";
            this.clTenNhomTT.Name = "clTenNhomTT";
            this.clTenNhomTT.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lbNhomThuThuat);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(196, 21);
            this.panel7.TabIndex = 3;
            // 
            // lbNhomThuThuat
            // 
            this.lbNhomThuThuat.AutoSize = true;
            this.lbNhomThuThuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhomThuThuat.Location = new System.Drawing.Point(37, 0);
            this.lbNhomThuThuat.Name = "lbNhomThuThuat";
            this.lbNhomThuThuat.Size = new System.Drawing.Size(120, 13);
            this.lbNhomThuThuat.TabIndex = 0;
            this.lbNhomThuThuat.Text = "NHÓM THỦ THUẬT";
            // 
            // fChonThuThuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.Name = "fChonThuThuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn thủ thuật điều trị";
            this.pnTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnThuThuatDuocChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThuatDuocChon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnThuThuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuThuat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnNhomTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomTT)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbChonThuThuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnNhomTT;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbNhomThuThuat;
        private System.Windows.Forms.DataGridView dgvNhomTT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnThuThuatDuocChon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbThuThuatDuocChon;
        private System.Windows.Forms.Panel pnThuThuat;
        private System.Windows.Forms.DataGridView dgvThuThuat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbThuThuat;
        private System.Windows.Forms.DataGridView dgvThuThuatDuocChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhomTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaThuThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCTDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCTThuThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenThuThuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhaiThanhToan;
    }
}