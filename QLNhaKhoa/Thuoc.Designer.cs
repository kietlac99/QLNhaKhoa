
namespace QLNhaKhoa
{
    partial class fThuoc
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
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.txtLuongDung = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.lbCongDung = new System.Windows.Forms.Label();
            this.lbLuongDung = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbTenThuoc = new System.Windows.Forms.Label();
            this.erpThuoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpThuoc)).BeginInit();
            this.SuspendLayout();
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
            this.ibtnLuu.Location = new System.Drawing.Point(371, 157);
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
            // txtCongDung
            // 
            this.txtCongDung.Location = new System.Drawing.Point(112, 122);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(342, 20);
            this.txtCongDung.TabIndex = 3;
            // 
            // txtLuongDung
            // 
            this.txtLuongDung.Location = new System.Drawing.Point(112, 86);
            this.txtLuongDung.Name = "txtLuongDung";
            this.txtLuongDung.Size = new System.Drawing.Size(342, 20);
            this.txtLuongDung.TabIndex = 2;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(112, 51);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(342, 20);
            this.txtDonVi.TabIndex = 1;
            // 
            // lbCongDung
            // 
            this.lbCongDung.AutoSize = true;
            this.lbCongDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongDung.Location = new System.Drawing.Point(12, 122);
            this.lbCongDung.Name = "lbCongDung";
            this.lbCongDung.Size = new System.Drawing.Size(87, 20);
            this.lbCongDung.TabIndex = 18;
            this.lbCongDung.Text = "Công dụng";
            // 
            // lbLuongDung
            // 
            this.lbLuongDung.AutoSize = true;
            this.lbLuongDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongDung.Location = new System.Drawing.Point(12, 86);
            this.lbLuongDung.Name = "lbLuongDung";
            this.lbLuongDung.Size = new System.Drawing.Size(94, 20);
            this.lbLuongDung.TabIndex = 19;
            this.lbLuongDung.Text = "Lượng dùng";
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVi.Location = new System.Drawing.Point(12, 51);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(53, 20);
            this.lbDonVi.TabIndex = 20;
            this.lbDonVi.Text = "Đơn vị";
            // 
            // lbTenThuoc
            // 
            this.lbTenThuoc.AutoSize = true;
            this.lbTenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenThuoc.Location = new System.Drawing.Point(12, 14);
            this.lbTenThuoc.Name = "lbTenThuoc";
            this.lbTenThuoc.Size = new System.Drawing.Size(80, 20);
            this.lbTenThuoc.TabIndex = 21;
            this.lbTenThuoc.Text = "Tên thuốc";
            // 
            // erpThuoc
            // 
            this.erpThuoc.ContainerControl = this;
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(112, 14);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(342, 20);
            this.txtTenThuoc.TabIndex = 0;
            // 
            // fThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(466, 216);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.txtCongDung);
            this.Controls.Add(this.txtLuongDung);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.lbCongDung);
            this.Controls.Add(this.lbLuongDung);
            this.Controls.Add(this.lbDonVi);
            this.Controls.Add(this.lbTenThuoc);
            this.Name = "fThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.erpThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.TextBox txtLuongDung;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label lbCongDung;
        private System.Windows.Forms.Label lbLuongDung;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label lbTenThuoc;
        private System.Windows.Forms.ErrorProvider erpThuoc;
        private System.Windows.Forms.TextBox txtTenThuoc;
    }
}