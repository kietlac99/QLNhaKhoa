
namespace QLNhaKhoa
{
    partial class fThuThuat
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
            this.lbTenNhomTT = new System.Windows.Forms.Label();
            this.txtTenThuThuat = new System.Windows.Forms.TextBox();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.cbxTenNhomTT = new System.Windows.Forms.ComboBox();
            this.lbTenThuThuat = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbGiamGia = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.erpThuThuat = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtLyDoGiamGia = new System.Windows.Forms.TextBox();
            this.lbLyDoGiamGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erpThuThuat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenNhomTT
            // 
            this.lbTenNhomTT.AutoSize = true;
            this.lbTenNhomTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhomTT.Location = new System.Drawing.Point(12, 12);
            this.lbTenNhomTT.Name = "lbTenNhomTT";
            this.lbTenNhomTT.Size = new System.Drawing.Size(148, 20);
            this.lbTenNhomTT.TabIndex = 0;
            this.lbTenNhomTT.Text = "Tên nhóm thủ thuật";
            // 
            // txtTenThuThuat
            // 
            this.txtTenThuThuat.Location = new System.Drawing.Point(167, 49);
            this.txtTenThuThuat.Name = "txtTenThuThuat";
            this.txtTenThuThuat.Size = new System.Drawing.Size(251, 20);
            this.txtTenThuThuat.TabIndex = 1;
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
            this.ibtnLuu.Location = new System.Drawing.Point(336, 198);
            this.ibtnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(82, 45);
            this.ibtnLuu.TabIndex = 4;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // cbxTenNhomTT
            // 
            this.cbxTenNhomTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenNhomTT.FormattingEnabled = true;
            this.cbxTenNhomTT.Location = new System.Drawing.Point(167, 11);
            this.cbxTenNhomTT.Name = "cbxTenNhomTT";
            this.cbxTenNhomTT.Size = new System.Drawing.Size(251, 21);
            this.cbxTenNhomTT.TabIndex = 0;
            // 
            // lbTenThuThuat
            // 
            this.lbTenThuThuat.AutoSize = true;
            this.lbTenThuThuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenThuThuat.Location = new System.Drawing.Point(12, 49);
            this.lbTenThuThuat.Name = "lbTenThuThuat";
            this.lbTenThuThuat.Size = new System.Drawing.Size(104, 20);
            this.lbTenThuThuat.TabIndex = 0;
            this.lbTenThuThuat.Text = "Tên thủ thuật";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(12, 84);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(64, 20);
            this.lbDonGia.TabIndex = 0;
            this.lbDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(167, 84);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(251, 20);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // lbGiamGia
            // 
            this.lbGiamGia.AutoSize = true;
            this.lbGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiamGia.Location = new System.Drawing.Point(12, 120);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(72, 20);
            this.lbGiamGia.TabIndex = 0;
            this.lbGiamGia.Text = "Giảm giá";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(167, 120);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(251, 20);
            this.txtGiamGia.TabIndex = 3;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // erpThuThuat
            // 
            this.erpThuThuat.ContainerControl = this;
            // 
            // txtLyDoGiamGia
            // 
            this.txtLyDoGiamGia.Location = new System.Drawing.Point(167, 156);
            this.txtLyDoGiamGia.Name = "txtLyDoGiamGia";
            this.txtLyDoGiamGia.Size = new System.Drawing.Size(251, 20);
            this.txtLyDoGiamGia.TabIndex = 6;
            // 
            // lbLyDoGiamGia
            // 
            this.lbLyDoGiamGia.AutoSize = true;
            this.lbLyDoGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLyDoGiamGia.Location = new System.Drawing.Point(12, 156);
            this.lbLyDoGiamGia.Name = "lbLyDoGiamGia";
            this.lbLyDoGiamGia.Size = new System.Drawing.Size(110, 20);
            this.lbLyDoGiamGia.TabIndex = 5;
            this.lbLyDoGiamGia.Text = "Lý do giảm giá";
            // 
            // fThuThuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(466, 257);
            this.Controls.Add(this.txtLyDoGiamGia);
            this.Controls.Add(this.lbLyDoGiamGia);
            this.Controls.Add(this.cbxTenNhomTT);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenThuThuat);
            this.Controls.Add(this.lbGiamGia);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbTenThuThuat);
            this.Controls.Add(this.lbTenNhomTT);
            this.Name = "fThuThuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thủ thuật";
            ((System.ComponentModel.ISupportInitialize)(this.erpThuThuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenNhomTT;
        private System.Windows.Forms.TextBox txtTenThuThuat;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private System.Windows.Forms.ComboBox cbxTenNhomTT;
        private System.Windows.Forms.Label lbTenThuThuat;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbGiamGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.ErrorProvider erpThuThuat;
        private System.Windows.Forms.TextBox txtLyDoGiamGia;
        private System.Windows.Forms.Label lbLyDoGiamGia;
    }
}