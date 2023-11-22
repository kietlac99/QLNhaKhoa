
namespace QLNhaKhoa
{
    partial class fTTNhanVien
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
            this.lbTTNhanVien = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbSoDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbViTri = new System.Windows.Forms.Label();
            this.lbCongViec = new System.Windows.Forms.Label();
            this.lbMucLuong = new System.Windows.Forms.Label();
            this.lbVaiTro = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCongViec = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMucLuong = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbxVaiTro = new System.Windows.Forms.ComboBox();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.lbTenDem = new System.Windows.Forms.Label();
            this.txtTenDem = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.erpTTNhanVien = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpTTNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTTNhanVien
            // 
            this.lbTTNhanVien.BackColor = System.Drawing.Color.Fuchsia;
            this.lbTTNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTNhanVien.ForeColor = System.Drawing.Color.White;
            this.lbTTNhanVien.Location = new System.Drawing.Point(260, 9);
            this.lbTTNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTTNhanVien.Name = "lbTTNhanVien";
            this.lbTTNhanVien.Size = new System.Drawing.Size(452, 59);
            this.lbTTNhanVien.TabIndex = 3;
            this.lbTTNhanVien.Text = "THÔNG TIN NHÂN VIÊN";
            this.lbTTNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Fuchsia;
            this.pnTitle.Controls.Add(this.lbTTNhanVien);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(984, 74);
            this.pnTitle.TabIndex = 9;
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHo.Location = new System.Drawing.Point(13, 114);
            this.lbHo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(30, 20);
            this.lbHo.TabIndex = 10;
            this.lbHo.Text = "Họ";
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCCD.Location = new System.Drawing.Point(13, 150);
            this.lbCCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(54, 20);
            this.lbCCCD.TabIndex = 11;
            this.lbCCCD.Text = "CCCD";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(13, 186);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lbDiaChi.TabIndex = 12;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhiChu.Location = new System.Drawing.Point(13, 294);
            this.lbGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(64, 20);
            this.lbGhiChu.TabIndex = 13;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbSoDT
            // 
            this.lbSoDT.AutoSize = true;
            this.lbSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDT.Location = new System.Drawing.Point(426, 150);
            this.lbSoDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoDT.Name = "lbSoDT";
            this.lbSoDT.Size = new System.Drawing.Size(54, 20);
            this.lbSoDT.TabIndex = 14;
            this.lbSoDT.Text = "Số ĐT";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(425, 114);
            this.lbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(78, 20);
            this.lbNgaySinh.TabIndex = 15;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(691, 114);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(67, 20);
            this.lbGioiTinh.TabIndex = 16;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbViTri
            // 
            this.lbViTri.AutoSize = true;
            this.lbViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViTri.Location = new System.Drawing.Point(13, 222);
            this.lbViTri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbViTri.Name = "lbViTri";
            this.lbViTri.Size = new System.Drawing.Size(40, 20);
            this.lbViTri.TabIndex = 17;
            this.lbViTri.Text = "Vị trí";
            // 
            // lbCongViec
            // 
            this.lbCongViec.AutoSize = true;
            this.lbCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongViec.Location = new System.Drawing.Point(13, 258);
            this.lbCongViec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCongViec.Name = "lbCongViec";
            this.lbCongViec.Size = new System.Drawing.Size(78, 20);
            this.lbCongViec.TabIndex = 18;
            this.lbCongViec.Text = "Công việc";
            // 
            // lbMucLuong
            // 
            this.lbMucLuong.AutoSize = true;
            this.lbMucLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMucLuong.Location = new System.Drawing.Point(13, 330);
            this.lbMucLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMucLuong.Name = "lbMucLuong";
            this.lbMucLuong.Size = new System.Drawing.Size(71, 20);
            this.lbMucLuong.TabIndex = 19;
            this.lbMucLuong.Text = "M.Lương";
            // 
            // lbVaiTro
            // 
            this.lbVaiTro.AutoSize = true;
            this.lbVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVaiTro.Location = new System.Drawing.Point(426, 222);
            this.lbVaiTro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVaiTro.Name = "lbVaiTro";
            this.lbVaiTro.Size = new System.Drawing.Size(55, 20);
            this.lbVaiTro.TabIndex = 20;
            this.lbVaiTro.Text = "Vai trò";
            // 
            // txtHo
            // 
            this.txtHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(99, 108);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(60, 26);
            this.txtHo.TabIndex = 0;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(99, 144);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(318, 26);
            this.txtCCCD.TabIndex = 6;
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(99, 180);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(861, 26);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtCongViec
            // 
            this.txtCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongViec.Location = new System.Drawing.Point(99, 252);
            this.txtCongViec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCongViec.Name = "txtCongViec";
            this.txtCongViec.Size = new System.Drawing.Size(862, 26);
            this.txtCongViec.TabIndex = 11;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(99, 288);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(861, 26);
            this.txtGhiChu.TabIndex = 12;
            // 
            // txtMucLuong
            // 
            this.txtMucLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucLuong.Location = new System.Drawing.Point(99, 324);
            this.txtMucLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMucLuong.Name = "txtMucLuong";
            this.txtMucLuong.Size = new System.Drawing.Size(861, 26);
            this.txtMucLuong.TabIndex = 13;
            this.txtMucLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMucLuong_KeyPress);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(511, 144);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(449, 26);
            this.txtSoDT.TabIndex = 7;
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            // 
            // txtViTri
            // 
            this.txtViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTri.Location = new System.Drawing.Point(99, 216);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(318, 26);
            this.txtViTri.TabIndex = 9;
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Location = new System.Drawing.Point(766, 106);
            this.cbxGioiTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(194, 28);
            this.cbxGioiTinh.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(511, 108);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(172, 26);
            this.dtpNgaySinh.TabIndex = 4;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // cbxVaiTro
            // 
            this.cbxVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVaiTro.FormattingEnabled = true;
            this.cbxVaiTro.Location = new System.Drawing.Point(511, 214);
            this.cbxVaiTro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxVaiTro.Name = "cbxVaiTro";
            this.cbxVaiTro.Size = new System.Drawing.Size(449, 28);
            this.cbxVaiTro.TabIndex = 10;
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.BackColor = System.Drawing.Color.White;
            this.ibtnLuu.FlatAppearance.BorderSize = 0;
            this.ibtnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnLuu.IconColor = System.Drawing.Color.Blue;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.IconSize = 30;
            this.ibtnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.Location = new System.Drawing.Point(861, 360);
            this.ibtnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(100, 57);
            this.ibtnLuu.TabIndex = 11;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Them_Click);
            // 
            // lbTenDem
            // 
            this.lbTenDem.AutoSize = true;
            this.lbTenDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDem.Location = new System.Drawing.Point(167, 114);
            this.lbTenDem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenDem.Name = "lbTenDem";
            this.lbTenDem.Size = new System.Drawing.Size(71, 20);
            this.lbTenDem.TabIndex = 10;
            this.lbTenDem.Text = "Tên đệm";
            // 
            // txtTenDem
            // 
            this.txtTenDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDem.Location = new System.Drawing.Point(246, 108);
            this.txtTenDem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDem.Name = "txtTenDem";
            this.txtTenDem.Size = new System.Drawing.Size(60, 26);
            this.txtTenDem.TabIndex = 1;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(314, 114);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(36, 20);
            this.lbTen.TabIndex = 10;
            this.lbTen.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(357, 108);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(60, 26);
            this.txtTen.TabIndex = 3;
            // 
            // erpTTNhanVien
            // 
            this.erpTTNhanVien.ContainerControl = this;
            // 
            // fTTNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.cbxVaiTro);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cbxGioiTinh);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtMucLuong);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtCongViec);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtTenDem);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lbVaiTro);
            this.Controls.Add(this.lbMucLuong);
            this.Controls.Add(this.lbCongViec);
            this.Controls.Add(this.lbViTri);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbSoDT);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbCCCD);
            this.Controls.Add(this.lbTenDem);
            this.Controls.Add(this.lbHo);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fTTNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.fQLNhanVien_Load);
            this.pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpTTNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTTNhanVien;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbSoDT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbViTri;
        private System.Windows.Forms.Label lbCongViec;
        private System.Windows.Forms.Label lbMucLuong;
        private System.Windows.Forms.Label lbVaiTro;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCongViec;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMucLuong;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbxVaiTro;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private System.Windows.Forms.Label lbTenDem;
        private System.Windows.Forms.TextBox txtTenDem;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ErrorProvider erpTTNhanVien;
    }
}