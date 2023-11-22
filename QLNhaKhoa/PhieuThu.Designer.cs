
namespace QLNhaKhoa
{
    partial class fPhieuThu
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
            this.lbPhieuThu = new System.Windows.Forms.Label();
            this.lbNgayThu = new System.Windows.Forms.Label();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.lbNguoiNop = new System.Windows.Forms.Label();
            this.txtNguoiNop = new System.Windows.Forms.TextBox();
            this.lbSoDT = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.cbxNhanVienThu = new System.Windows.Forms.ComboBox();
            this.lbNhanVienThu = new System.Windows.Forms.Label();
            this.rbThanhToanTM = new System.Windows.Forms.RadioButton();
            this.rbChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.rbQuetThe = new System.Windows.Forms.RadioButton();
            this.ibtnLuuIn = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.ibtnIn = new FontAwesome.Sharp.IconButton();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTitle.Controls.Add(this.lbPhieuThu);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(687, 55);
            this.pnTitle.TabIndex = 2;
            // 
            // lbPhieuThu
            // 
            this.lbPhieuThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPhieuThu.BackColor = System.Drawing.Color.Transparent;
            this.lbPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuThu.ForeColor = System.Drawing.Color.Navy;
            this.lbPhieuThu.Location = new System.Drawing.Point(167, 8);
            this.lbPhieuThu.Name = "lbPhieuThu";
            this.lbPhieuThu.Size = new System.Drawing.Size(366, 35);
            this.lbPhieuThu.TabIndex = 0;
            this.lbPhieuThu.Text = "PHIẾU THU";
            this.lbPhieuThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNgayThu
            // 
            this.lbNgayThu.AutoSize = true;
            this.lbNgayThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThu.Location = new System.Drawing.Point(12, 65);
            this.lbNgayThu.Name = "lbNgayThu";
            this.lbNgayThu.Size = new System.Drawing.Size(61, 16);
            this.lbNgayThu.TabIndex = 3;
            this.lbNgayThu.Text = "Ngày thu";
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.Location = new System.Drawing.Point(88, 61);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayThu.TabIndex = 4;
            // 
            // lbNguoiNop
            // 
            this.lbNguoiNop.AutoSize = true;
            this.lbNguoiNop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiNop.Location = new System.Drawing.Point(12, 88);
            this.lbNguoiNop.Name = "lbNguoiNop";
            this.lbNguoiNop.Size = new System.Drawing.Size(70, 16);
            this.lbNguoiNop.TabIndex = 3;
            this.lbNguoiNop.Text = "Người nộp";
            // 
            // txtNguoiNop
            // 
            this.txtNguoiNop.Location = new System.Drawing.Point(88, 87);
            this.txtNguoiNop.Name = "txtNguoiNop";
            this.txtNguoiNop.Size = new System.Drawing.Size(284, 20);
            this.txtNguoiNop.TabIndex = 5;
            this.txtNguoiNop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNguoiNop_KeyPress);
            // 
            // lbSoDT
            // 
            this.lbSoDT.AutoSize = true;
            this.lbSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDT.Location = new System.Drawing.Point(400, 88);
            this.lbSoDT.Name = "lbSoDT";
            this.lbSoDT.Size = new System.Drawing.Size(35, 16);
            this.lbSoDT.TabIndex = 3;
            this.lbSoDT.Text = "SĐT";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(441, 87);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(234, 20);
            this.txtSoDT.TabIndex = 5;
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(12, 114);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(48, 16);
            this.lbDiaChi.TabIndex = 3;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(88, 113);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(587, 20);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(88, 139);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(587, 107);
            this.txtNoiDung.TabIndex = 6;
            this.txtNoiDung.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoiDung_KeyPress);
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(12, 253);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(49, 16);
            this.lbSoTien.TabIndex = 3;
            this.lbSoTien.Text = "Số tiền";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(88, 252);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(200, 20);
            this.txtSoTien.TabIndex = 7;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien_KeyPress);
            // 
            // cbxNhanVienThu
            // 
            this.cbxNhanVienThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhanVienThu.FormattingEnabled = true;
            this.cbxNhanVienThu.Location = new System.Drawing.Point(441, 252);
            this.cbxNhanVienThu.Name = "cbxNhanVienThu";
            this.cbxNhanVienThu.Size = new System.Drawing.Size(234, 21);
            this.cbxNhanVienThu.TabIndex = 8;
            // 
            // lbNhanVienThu
            // 
            this.lbNhanVienThu.AutoSize = true;
            this.lbNhanVienThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVienThu.Location = new System.Drawing.Point(347, 253);
            this.lbNhanVienThu.Name = "lbNhanVienThu";
            this.lbNhanVienThu.Size = new System.Drawing.Size(88, 16);
            this.lbNhanVienThu.TabIndex = 9;
            this.lbNhanVienThu.Text = "Nhân viên thu";
            // 
            // rbThanhToanTM
            // 
            this.rbThanhToanTM.AutoSize = true;
            this.rbThanhToanTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThanhToanTM.Location = new System.Drawing.Point(55, 278);
            this.rbThanhToanTM.Name = "rbThanhToanTM";
            this.rbThanhToanTM.Size = new System.Drawing.Size(142, 20);
            this.rbThanhToanTM.TabIndex = 10;
            this.rbThanhToanTM.TabStop = true;
            this.rbThanhToanTM.Text = "Thanh toán tiền mặt";
            this.rbThanhToanTM.UseVisualStyleBackColor = true;
            // 
            // rbChuyenKhoan
            // 
            this.rbChuyenKhoan.AutoSize = true;
            this.rbChuyenKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChuyenKhoan.Location = new System.Drawing.Point(55, 304);
            this.rbChuyenKhoan.Name = "rbChuyenKhoan";
            this.rbChuyenKhoan.Size = new System.Drawing.Size(111, 20);
            this.rbChuyenKhoan.TabIndex = 10;
            this.rbChuyenKhoan.TabStop = true;
            this.rbChuyenKhoan.Text = "Chuyển khoản";
            this.rbChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rbQuetThe
            // 
            this.rbQuetThe.AutoSize = true;
            this.rbQuetThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuetThe.Location = new System.Drawing.Point(172, 304);
            this.rbQuetThe.Name = "rbQuetThe";
            this.rbQuetThe.Size = new System.Drawing.Size(75, 20);
            this.rbQuetThe.TabIndex = 10;
            this.rbQuetThe.TabStop = true;
            this.rbQuetThe.Text = "Quẹt thẻ";
            this.rbQuetThe.UseVisualStyleBackColor = true;
            // 
            // ibtnLuuIn
            // 
            this.ibtnLuuIn.BackColor = System.Drawing.Color.White;
            this.ibtnLuuIn.FlatAppearance.BorderSize = 0;
            this.ibtnLuuIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLuuIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLuuIn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ibtnLuuIn.IconColor = System.Drawing.Color.Blue;
            this.ibtnLuuIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuuIn.IconSize = 30;
            this.ibtnLuuIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuuIn.Location = new System.Drawing.Point(560, 284);
            this.ibtnLuuIn.Name = "ibtnLuuIn";
            this.ibtnLuuIn.Size = new System.Drawing.Size(115, 45);
            this.ibtnLuuIn.TabIndex = 42;
            this.ibtnLuuIn.Text = "Lưu và in";
            this.ibtnLuuIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuuIn.UseVisualStyleBackColor = false;
            this.ibtnLuuIn.Click += new System.EventHandler(this.ibtnLuuIn_Click);
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
            this.ibtnLuu.Location = new System.Drawing.Point(471, 284);
            this.ibtnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(82, 45);
            this.ibtnLuu.TabIndex = 43;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiDung.Location = new System.Drawing.Point(12, 140);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(62, 16);
            this.lbNoiDung.TabIndex = 44;
            this.lbNoiDung.Text = "Nội dung";
            // 
            // ibtnIn
            // 
            this.ibtnIn.BackColor = System.Drawing.Color.White;
            this.ibtnIn.FlatAppearance.BorderSize = 0;
            this.ibtnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnIn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ibtnIn.IconColor = System.Drawing.Color.Blue;
            this.ibtnIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnIn.IconSize = 30;
            this.ibtnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnIn.Location = new System.Drawing.Point(392, 284);
            this.ibtnIn.Name = "ibtnIn";
            this.ibtnIn.Size = new System.Drawing.Size(72, 45);
            this.ibtnIn.TabIndex = 45;
            this.ibtnIn.Text = "In";
            this.ibtnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnIn.UseVisualStyleBackColor = false;
            this.ibtnIn.Visible = false;
            this.ibtnIn.Click += new System.EventHandler(this.ibtnIn_Click);
            // 
            // fPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(687, 346);
            this.Controls.Add(this.ibtnIn);
            this.Controls.Add(this.lbNoiDung);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.ibtnLuuIn);
            this.Controls.Add(this.rbQuetThe);
            this.Controls.Add(this.rbChuyenKhoan);
            this.Controls.Add(this.rbThanhToanTM);
            this.Controls.Add(this.lbNhanVienThu);
            this.Controls.Add(this.cbxNhanVienThu);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtNguoiNop);
            this.Controls.Add(this.dtpNgayThu);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbSoDT);
            this.Controls.Add(this.lbNguoiNop);
            this.Controls.Add(this.lbNgayThu);
            this.Controls.Add(this.pnTitle);
            this.Name = "fPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuThu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fPhieuThu_FormClosed);
            this.pnTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbPhieuThu;
        private System.Windows.Forms.Label lbNgayThu;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.Label lbNguoiNop;
        private System.Windows.Forms.TextBox txtNguoiNop;
        private System.Windows.Forms.Label lbSoDT;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.ComboBox cbxNhanVienThu;
        private System.Windows.Forms.Label lbNhanVienThu;
        private System.Windows.Forms.RadioButton rbThanhToanTM;
        private System.Windows.Forms.RadioButton rbChuyenKhoan;
        private System.Windows.Forms.RadioButton rbQuetThe;
        private FontAwesome.Sharp.IconButton ibtnLuuIn;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private System.Windows.Forms.Label lbNoiDung;
        private FontAwesome.Sharp.IconButton ibtnIn;
    }
}