
namespace QLNhaKhoa
{
    partial class fBacSiThucHien
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
            this.pnBacSi = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibtnArrow = new FontAwesome.Sharp.IconButton();
            this.dgvBSDuocChon = new System.Windows.Forms.DataGridView();
            this.clMaNDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNhanV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBacSi = new System.Windows.Forms.DataGridView();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbBacSi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.dgvTTDuocChon = new System.Windows.Forms.DataGridView();
            this.clMaNhomDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTroThu = new System.Windows.Forms.DataGridView();
            this.clMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTenn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTroThu = new System.Windows.Forms.Label();
            this.pnBacSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBSDuocChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDuocChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroThu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBacSi
            // 
            this.pnBacSi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBacSi.Controls.Add(this.iconButton1);
            this.pnBacSi.Controls.Add(this.ibtnArrow);
            this.pnBacSi.Controls.Add(this.dgvBSDuocChon);
            this.pnBacSi.Controls.Add(this.dgvBacSi);
            this.pnBacSi.Controls.Add(this.pnTitle);
            this.pnBacSi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBacSi.Location = new System.Drawing.Point(0, 0);
            this.pnBacSi.Name = "pnBacSi";
            this.pnBacSi.Size = new System.Drawing.Size(597, 218);
            this.pnBacSi.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(260, 133);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(73, 81);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // ibtnArrow
            // 
            this.ibtnArrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnArrow.IconChar = FontAwesome.Sharp.IconChar.ArrowRightLong;
            this.ibtnArrow.IconColor = System.Drawing.Color.Black;
            this.ibtnArrow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnArrow.Location = new System.Drawing.Point(260, 46);
            this.ibtnArrow.Name = "ibtnArrow";
            this.ibtnArrow.Size = new System.Drawing.Size(73, 87);
            this.ibtnArrow.TabIndex = 0;
            this.ibtnArrow.UseVisualStyleBackColor = true;
            // 
            // dgvBSDuocChon
            // 
            this.dgvBSDuocChon.AllowUserToAddRows = false;
            this.dgvBSDuocChon.AllowUserToDeleteRows = false;
            this.dgvBSDuocChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvBSDuocChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBSDuocChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNDT,
            this.clMaNhanV,
            this.clHT});
            this.dgvBSDuocChon.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvBSDuocChon.Location = new System.Drawing.Point(333, 46);
            this.dgvBSDuocChon.Name = "dgvBSDuocChon";
            this.dgvBSDuocChon.ReadOnly = true;
            this.dgvBSDuocChon.Size = new System.Drawing.Size(260, 168);
            this.dgvBSDuocChon.TabIndex = 4;
            this.dgvBSDuocChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBSDuocChon_CellClick);
            this.dgvBSDuocChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBSDuocChon_CellDoubleClick);
            // 
            // clMaNDT
            // 
            this.clMaNDT.DataPropertyName = "MaNDT";
            this.clMaNDT.HeaderText = "Mã nhóm điều trị";
            this.clMaNDT.Name = "clMaNDT";
            this.clMaNDT.ReadOnly = true;
            this.clMaNDT.Visible = false;
            // 
            // clMaNhanV
            // 
            this.clMaNhanV.DataPropertyName = "MaNV";
            this.clMaNhanV.HeaderText = "Mã nhân viên";
            this.clMaNhanV.Name = "clMaNhanV";
            this.clMaNhanV.ReadOnly = true;
            this.clMaNhanV.Visible = false;
            // 
            // clHT
            // 
            this.clHT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHT.DataPropertyName = "HoTen";
            this.clHT.HeaderText = "Bác sĩ được chọn";
            this.clHT.Name = "clHT";
            this.clHT.ReadOnly = true;
            // 
            // dgvBacSi
            // 
            this.dgvBacSi.AllowUserToAddRows = false;
            this.dgvBacSi.AllowUserToDeleteRows = false;
            this.dgvBacSi.BackgroundColor = System.Drawing.Color.White;
            this.dgvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNV,
            this.clMaN,
            this.clHoTen});
            this.dgvBacSi.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBacSi.Location = new System.Drawing.Point(0, 46);
            this.dgvBacSi.Name = "dgvBacSi";
            this.dgvBacSi.ReadOnly = true;
            this.dgvBacSi.Size = new System.Drawing.Size(260, 168);
            this.dgvBacSi.TabIndex = 3;
            this.dgvBacSi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBacSi_CellClick);
            this.dgvBacSi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBacSi_CellDoubleClick);
            // 
            // clMaNV
            // 
            this.clMaNV.DataPropertyName = "MaNV";
            this.clMaNV.HeaderText = "Mã nhân viên";
            this.clMaNV.Name = "clMaNV";
            this.clMaNV.ReadOnly = true;
            this.clMaNV.Visible = false;
            // 
            // clMaN
            // 
            this.clMaN.DataPropertyName = "MaN";
            this.clMaN.HeaderText = "Mã người";
            this.clMaN.Name = "clMaN";
            this.clMaN.ReadOnly = true;
            this.clMaN.Visible = false;
            // 
            // clHoTen
            // 
            this.clHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTen.DataPropertyName = "HoTen";
            this.clHoTen.HeaderText = "Tên bác sĩ";
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTitle.Controls.Add(this.lbBacSi);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(593, 46);
            this.pnTitle.TabIndex = 2;
            // 
            // lbBacSi
            // 
            this.lbBacSi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBacSi.BackColor = System.Drawing.Color.Transparent;
            this.lbBacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBacSi.ForeColor = System.Drawing.Color.Navy;
            this.lbBacSi.Location = new System.Drawing.Point(101, 6);
            this.lbBacSi.Name = "lbBacSi";
            this.lbBacSi.Size = new System.Drawing.Size(382, 35);
            this.lbBacSi.TabIndex = 0;
            this.lbBacSi.Text = "BÁC SĨ THỰC HIỆN";
            this.lbBacSi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.dgvTTDuocChon);
            this.panel1.Controls.Add(this.dgvTroThu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 232);
            this.panel1.TabIndex = 1;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(260, 137);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(73, 91);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowRightLong;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(260, 46);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(73, 91);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // dgvTTDuocChon
            // 
            this.dgvTTDuocChon.AllowUserToAddRows = false;
            this.dgvTTDuocChon.AllowUserToDeleteRows = false;
            this.dgvTTDuocChon.BackgroundColor = System.Drawing.Color.White;
            this.dgvTTDuocChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTDuocChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNhomDT,
            this.clMaNVien,
            this.clHoT});
            this.dgvTTDuocChon.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvTTDuocChon.Location = new System.Drawing.Point(333, 46);
            this.dgvTTDuocChon.Name = "dgvTTDuocChon";
            this.dgvTTDuocChon.ReadOnly = true;
            this.dgvTTDuocChon.Size = new System.Drawing.Size(260, 182);
            this.dgvTTDuocChon.TabIndex = 4;
            this.dgvTTDuocChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTDuocChon_CellClick);
            this.dgvTTDuocChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTDuocChon_CellDoubleClick);
            // 
            // clMaNhomDT
            // 
            this.clMaNhomDT.DataPropertyName = "MaNDT";
            this.clMaNhomDT.HeaderText = "Mã nhóm điều trị";
            this.clMaNhomDT.Name = "clMaNhomDT";
            this.clMaNhomDT.ReadOnly = true;
            this.clMaNhomDT.Visible = false;
            // 
            // clMaNVien
            // 
            this.clMaNVien.DataPropertyName = "MaNV";
            this.clMaNVien.HeaderText = "Mã nhân viên";
            this.clMaNVien.Name = "clMaNVien";
            this.clMaNVien.ReadOnly = true;
            this.clMaNVien.Visible = false;
            // 
            // clHoT
            // 
            this.clHoT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoT.DataPropertyName = "HoTen";
            this.clHoT.HeaderText = "Trợ thủ được chọn";
            this.clHoT.Name = "clHoT";
            this.clHoT.ReadOnly = true;
            // 
            // dgvTroThu
            // 
            this.dgvTroThu.AllowUserToAddRows = false;
            this.dgvTroThu.AllowUserToDeleteRows = false;
            this.dgvTroThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvTroThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTroThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNhanVien,
            this.clMaNguoi,
            this.clHoTenn});
            this.dgvTroThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTroThu.Location = new System.Drawing.Point(0, 46);
            this.dgvTroThu.Name = "dgvTroThu";
            this.dgvTroThu.ReadOnly = true;
            this.dgvTroThu.Size = new System.Drawing.Size(260, 182);
            this.dgvTroThu.TabIndex = 3;
            this.dgvTroThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTroThu_CellClick);
            this.dgvTroThu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTroThu_CellDoubleClick);
            // 
            // clMaNhanVien
            // 
            this.clMaNhanVien.DataPropertyName = "MaNV";
            this.clMaNhanVien.HeaderText = "Mã nhân viên";
            this.clMaNhanVien.Name = "clMaNhanVien";
            this.clMaNhanVien.ReadOnly = true;
            this.clMaNhanVien.Visible = false;
            // 
            // clMaNguoi
            // 
            this.clMaNguoi.DataPropertyName = "MaN";
            this.clMaNguoi.HeaderText = "Mã người";
            this.clMaNguoi.Name = "clMaNguoi";
            this.clMaNguoi.ReadOnly = true;
            this.clMaNguoi.Visible = false;
            // 
            // clHoTenn
            // 
            this.clHoTenn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTenn.DataPropertyName = "HoTen";
            this.clHoTenn.HeaderText = "Trợ thủ";
            this.clHoTenn.Name = "clHoTenn";
            this.clHoTenn.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbTroThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 46);
            this.panel2.TabIndex = 2;
            // 
            // lbTroThu
            // 
            this.lbTroThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTroThu.BackColor = System.Drawing.Color.Transparent;
            this.lbTroThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroThu.ForeColor = System.Drawing.Color.Navy;
            this.lbTroThu.Location = new System.Drawing.Point(193, 5);
            this.lbTroThu.Name = "lbTroThu";
            this.lbTroThu.Size = new System.Drawing.Size(187, 35);
            this.lbTroThu.TabIndex = 0;
            this.lbTroThu.Text = "TRỢ THỦ";
            this.lbTroThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fBacSiThucHien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBacSi);
            this.Name = "fBacSiThucHien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BacSiThucHien";
            this.pnBacSi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBSDuocChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDuocChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroThu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBacSi;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbBacSi;
        private System.Windows.Forms.DataGridView dgvBSDuocChon;
        private System.Windows.Forms.DataGridView dgvBacSi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTTDuocChon;
        private System.Windows.Forms.DataGridView dgvTroThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTroThu;
        private FontAwesome.Sharp.IconButton ibtnArrow;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTenn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhanV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhomDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoT;
    }
}