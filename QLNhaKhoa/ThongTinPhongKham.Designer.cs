
namespace QLNhaKhoa
{
    partial class fThongTinPhongKham
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
            this.lbTTPhongKham = new System.Windows.Forms.Label();
            this.txtTenPK = new System.Windows.Forms.TextBox();
            this.lbTenPhongKham = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnChonLogo = new System.Windows.Forms.Button();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.lnGiayPhepKCB = new System.Windows.Forms.Label();
            this.txtKCB = new System.Windows.Forms.TextBox();
            this.lbWebsite = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.erpPhongKham = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPhongKham)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Fuchsia;
            this.pnTitle.Controls.Add(this.lbTTPhongKham);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1124, 74);
            this.pnTitle.TabIndex = 10;
            // 
            // lbTTPhongKham
            // 
            this.lbTTPhongKham.BackColor = System.Drawing.Color.Fuchsia;
            this.lbTTPhongKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTPhongKham.ForeColor = System.Drawing.Color.White;
            this.lbTTPhongKham.Location = new System.Drawing.Point(335, 9);
            this.lbTTPhongKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTTPhongKham.Name = "lbTTPhongKham";
            this.lbTTPhongKham.Size = new System.Drawing.Size(452, 59);
            this.lbTTPhongKham.TabIndex = 3;
            this.lbTTPhongKham.Text = "THÔNG TIN PHÒNG KHÁM";
            this.lbTTPhongKham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenPK
            // 
            this.txtTenPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPK.Location = new System.Drawing.Point(149, 110);
            this.txtTenPK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenPK.Name = "txtTenPK";
            this.txtTenPK.Size = new System.Drawing.Size(563, 26);
            this.txtTenPK.TabIndex = 11;
            // 
            // lbTenPhongKham
            // 
            this.lbTenPhongKham.AutoSize = true;
            this.lbTenPhongKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPhongKham.Location = new System.Drawing.Point(13, 113);
            this.lbTenPhongKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenPhongKham.Name = "lbTenPhongKham";
            this.lbTenPhongKham.Size = new System.Drawing.Size(128, 20);
            this.lbTenPhongKham.TabIndex = 12;
            this.lbTenPhongKham.Text = "Tên phòng khám";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.DarkGray;
            this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLogo.Location = new System.Drawing.Point(778, 82);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(334, 240);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // btnChonLogo
            // 
            this.btnChonLogo.Location = new System.Drawing.Point(778, 328);
            this.btnChonLogo.Name = "btnChonLogo";
            this.btnChonLogo.Size = new System.Drawing.Size(334, 33);
            this.btnChonLogo.TabIndex = 14;
            this.btnChonLogo.Text = "Chọn ảnh logo";
            this.btnChonLogo.UseVisualStyleBackColor = true;
            this.btnChonLogo.Click += new System.EventHandler(this.btnChonLogo_Click);
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
            this.ibtnLuu.Location = new System.Drawing.Point(13, 355);
            this.ibtnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(100, 57);
            this.ibtnLuu.TabIndex = 15;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(13, 149);
            this.lbDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lbDiaChi.TabIndex = 12;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(149, 146);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(563, 26);
            this.txtDiaChi.TabIndex = 11;
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienThoai.Location = new System.Drawing.Point(13, 185);
            this.lbDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(81, 20);
            this.lbDienThoai.TabIndex = 12;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(149, 182);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(563, 26);
            this.txtSoDT.TabIndex = 11;
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            // 
            // lnGiayPhepKCB
            // 
            this.lnGiayPhepKCB.AutoSize = true;
            this.lnGiayPhepKCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnGiayPhepKCB.Location = new System.Drawing.Point(13, 221);
            this.lnGiayPhepKCB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnGiayPhepKCB.Name = "lnGiayPhepKCB";
            this.lnGiayPhepKCB.Size = new System.Drawing.Size(117, 20);
            this.lnGiayPhepKCB.TabIndex = 12;
            this.lnGiayPhepKCB.Text = "Giấy phép KCB";
            // 
            // txtKCB
            // 
            this.txtKCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKCB.Location = new System.Drawing.Point(149, 218);
            this.txtKCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKCB.Name = "txtKCB";
            this.txtKCB.Size = new System.Drawing.Size(563, 26);
            this.txtKCB.TabIndex = 11;
            // 
            // lbWebsite
            // 
            this.lbWebsite.AutoSize = true;
            this.lbWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWebsite.Location = new System.Drawing.Point(13, 257);
            this.lbWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWebsite.Name = "lbWebsite";
            this.lbWebsite.Size = new System.Drawing.Size(67, 20);
            this.lbWebsite.TabIndex = 12;
            this.lbWebsite.Text = "Website";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(149, 254);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(563, 26);
            this.txtWebsite.TabIndex = 11;
            // 
            // erpPhongKham
            // 
            this.erpPhongKham.ContainerControl = this;
            // 
            // fThongTinPhongKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.btnChonLogo);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.lbWebsite);
            this.Controls.Add(this.txtKCB);
            this.Controls.Add(this.lnGiayPhepKCB);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.txtTenPK);
            this.Controls.Add(this.lbTenPhongKham);
            this.Controls.Add(this.pnTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fThongTinPhongKham";
            this.Text = "ThongTinPhongKham";
            this.pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPhongKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTTPhongKham;
        private System.Windows.Forms.TextBox txtTenPK;
        private System.Windows.Forms.Label lbTenPhongKham;
        private System.Windows.Forms.Button btnChonLogo;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lnGiayPhepKCB;
        private System.Windows.Forms.TextBox txtKCB;
        private System.Windows.Forms.Label lbWebsite;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.ErrorProvider erpPhongKham;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}