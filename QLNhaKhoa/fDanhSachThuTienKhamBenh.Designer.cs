
namespace QLNhaKhoa
{
    partial class fDanhSachThuTienKhamBenh
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
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.ibtnTimKiem = new FontAwesome.Sharp.IconButton();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbBaoCao = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(12, 74);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(217, 13);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "Tìm kiếm theo ngày thu tiền trong phiếu thu: ";
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Location = new System.Drawing.Point(12, 96);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(46, 13);
            this.lbTuNgay.TabIndex = 1;
            this.lbTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(64, 90);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpTuNgay.TabIndex = 2;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(270, 96);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(53, 13);
            this.lbDenNgay.TabIndex = 3;
            this.lbDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(329, 90);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpDenNgay.TabIndex = 4;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // ibtnTimKiem
            // 
            this.ibtnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnTimKiem.IconColor = System.Drawing.Color.Black;
            this.ibtnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTimKiem.IconSize = 15;
            this.ibtnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ibtnTimKiem.Location = new System.Drawing.Point(575, 90);
            this.ibtnTimKiem.Name = "ibtnTimKiem";
            this.ibtnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.ibtnTimKiem.TabIndex = 23;
            this.ibtnTimKiem.Text = "Tìm kiếm";
            this.ibtnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnTimKiem.UseVisualStyleBackColor = true;
            this.ibtnTimKiem.Click += new System.EventHandler(this.ibtnTimKiem_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTitle.Controls.Add(this.lbBaoCao);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1124, 55);
            this.pnTitle.TabIndex = 24;
            // 
            // lbBaoCao
            // 
            this.lbBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lbBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaoCao.ForeColor = System.Drawing.Color.Navy;
            this.lbBaoCao.Location = new System.Drawing.Point(228, 8);
            this.lbBaoCao.Name = "lbBaoCao";
            this.lbBaoCao.Size = new System.Drawing.Size(663, 35);
            this.lbBaoCao.TabIndex = 0;
            this.lbBaoCao.Text = "BÁO CÁO DANH SÁCH THU TIỀN KHÁM BỆNH";
            this.lbBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fDanhSachThuTienKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.ibtnTimKiem);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lbDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lbTuNgay);
            this.Controls.Add(this.lbTimKiem);
            this.Name = "fDanhSachThuTienKhamBenh";
            this.Text = "fDanhSachThuTienKhamBenh";
            this.pnTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private FontAwesome.Sharp.IconButton ibtnTimKiem;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbBaoCao;
    }
}