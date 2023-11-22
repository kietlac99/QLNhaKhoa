
namespace QLNhaKhoa
{
    partial class fNhomTT
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
            this.txtNhomTT = new System.Windows.Forms.TextBox();
            this.erpNhomTT = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpNhomTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenNhomTT
            // 
            this.lbTenNhomTT.AutoSize = true;
            this.lbTenNhomTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhomTT.Location = new System.Drawing.Point(12, 9);
            this.lbTenNhomTT.Name = "lbTenNhomTT";
            this.lbTenNhomTT.Size = new System.Drawing.Size(148, 20);
            this.lbTenNhomTT.TabIndex = 18;
            this.lbTenNhomTT.Text = "Tên nhóm thủ thuật";
            // 
            // txtNhomTT
            // 
            this.txtNhomTT.Location = new System.Drawing.Point(186, 9);
            this.txtNhomTT.Name = "txtNhomTT";
            this.txtNhomTT.Size = new System.Drawing.Size(239, 20);
            this.txtNhomTT.TabIndex = 19;
            this.txtNhomTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhomTT_KeyPress);
            // 
            // erpNhomTT
            // 
            this.erpNhomTT.ContainerControl = this;
            // 
            // fNhomTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(437, 43);
            this.Controls.Add(this.txtNhomTT);
            this.Controls.Add(this.lbTenNhomTT);
            this.Name = "fNhomTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm thủ thuật";
            ((System.ComponentModel.ISupportInitialize)(this.erpNhomTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTenNhomTT;
        private System.Windows.Forms.TextBox txtNhomTT;
        private System.Windows.Forms.ErrorProvider erpNhomTT;
    }
}