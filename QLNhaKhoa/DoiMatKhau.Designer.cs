
namespace QLNhaKhoa
{
    partial class fDoiMatKhau
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
            this.lbMatKhauCu = new System.Windows.Forms.Label();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbXNMatKhau = new System.Windows.Forms.Label();
            this.lbDoiMatKhau = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.erpDoiMK = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.erpDoiMK)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMatKhauCu
            // 
            this.lbMatKhauCu.AutoSize = true;
            this.lbMatKhauCu.Location = new System.Drawing.Point(92, 178);
            this.lbMatKhauCu.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbMatKhauCu.Name = "lbMatKhauCu";
            this.lbMatKhauCu.Size = new System.Drawing.Size(140, 29);
            this.lbMatKhauCu.TabIndex = 0;
            this.lbMatKhauCu.Text = "Mật khẩu cũ";
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(92, 245);
            this.lbMatKhauMoi.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(155, 29);
            this.lbMatKhauMoi.TabIndex = 1;
            this.lbMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lbXNMatKhau
            // 
            this.lbXNMatKhau.AutoSize = true;
            this.lbXNMatKhau.Location = new System.Drawing.Point(92, 311);
            this.lbXNMatKhau.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbXNMatKhau.Name = "lbXNMatKhau";
            this.lbXNMatKhau.Size = new System.Drawing.Size(215, 29);
            this.lbXNMatKhau.TabIndex = 2;
            this.lbXNMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // lbDoiMatKhau
            // 
            this.lbDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.lbDoiMatKhau.Location = new System.Drawing.Point(331, 9);
            this.lbDoiMatKhau.Name = "lbDoiMatKhau";
            this.lbDoiMatKhau.Size = new System.Drawing.Size(505, 73);
            this.lbDoiMatKhau.TabIndex = 3;
            this.lbDoiMatKhau.Text = "ĐỔI MẬT KHẨU";
            this.lbDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(344, 172);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.PasswordChar = '*';
            this.txtMKCu.Size = new System.Drawing.Size(609, 35);
            this.txtMKCu.TabIndex = 4;
            this.txtMKCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKCu_KeyPress);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(344, 239);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.PasswordChar = '*';
            this.txtMKMoi.Size = new System.Drawing.Size(609, 35);
            this.txtMKMoi.TabIndex = 5;
            this.txtMKMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMKMoi_KeyPress);
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(344, 305);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.PasswordChar = '*';
            this.txtXNMK.Size = new System.Drawing.Size(609, 35);
            this.txtXNMK.TabIndex = 6;
            this.txtXNMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXNMK_KeyPress);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(344, 404);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(284, 54);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Đổi mật khẩu";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // erpDoiMK
            // 
            this.erpDoiMK.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.lbDoiMatKhau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 99);
            this.panel1.TabIndex = 8;
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lbXNMatKhau);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtXNMK);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.lbMatKhauCu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "fDoiMatKhau";
            this.Text = "DoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.erpDoiMK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMatKhauCu;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Label lbXNMatKhau;
        private System.Windows.Forms.Label lbDoiMatKhau;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ErrorProvider erpDoiMK;
        private System.Windows.Forms.Panel panel1;
    }
}