
namespace QLNhaKhoa
{
    partial class fMDT
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
            this.txtMDT = new System.Windows.Forms.TextBox();
            this.lbTenMDT = new System.Windows.Forms.Label();
            this.erpMDT = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpMDT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMDT
            // 
            this.txtMDT.Location = new System.Drawing.Point(164, 11);
            this.txtMDT.Name = "txtMDT";
            this.txtMDT.Size = new System.Drawing.Size(261, 20);
            this.txtMDT.TabIndex = 21;
            this.txtMDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMDT_KeyPress);
            // 
            // lbTenMDT
            // 
            this.lbTenMDT.AutoSize = true;
            this.lbTenMDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMDT.Location = new System.Drawing.Point(12, 11);
            this.lbTenMDT.Name = "lbTenMDT";
            this.lbTenMDT.Size = new System.Drawing.Size(146, 20);
            this.lbTenMDT.TabIndex = 20;
            this.lbTenMDT.Text = "Tên mẫu đơn thuốc";
            // 
            // erpMDT
            // 
            this.erpMDT.ContainerControl = this;
            // 
            // fMDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(437, 43);
            this.Controls.Add(this.txtMDT);
            this.Controls.Add(this.lbTenMDT);
            this.Name = "fMDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mẫu đơn thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.erpMDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMDT;
        private System.Windows.Forms.Label lbTenMDT;
        private System.Windows.Forms.ErrorProvider erpMDT;
    }
}