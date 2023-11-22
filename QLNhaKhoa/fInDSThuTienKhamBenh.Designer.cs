
namespace QLNhaKhoa
{
    partial class fInDSThuTienKhamBenh
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
            this.crvDSThuTienKhamBenh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crDSThuTienKhamBenh1 = new QLNhaKhoa.crDSThuTienKhamBenh();
            this.SuspendLayout();
            // 
            // crvDSThuTienKhamBenh
            // 
            this.crvDSThuTienKhamBenh.ActiveViewIndex = -1;
            this.crvDSThuTienKhamBenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDSThuTienKhamBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDSThuTienKhamBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDSThuTienKhamBenh.Location = new System.Drawing.Point(0, 0);
            this.crvDSThuTienKhamBenh.Name = "crvDSThuTienKhamBenh";
            this.crvDSThuTienKhamBenh.Size = new System.Drawing.Size(800, 450);
            this.crvDSThuTienKhamBenh.TabIndex = 0;
            // 
            // fInDSThuTienKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvDSThuTienKhamBenh);
            this.Name = "fInDSThuTienKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fInDSThuTienKhamBenh";
            this.Load += new System.EventHandler(this.fInDSThuTienKhamBenh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDSThuTienKhamBenh;
        private crDSThuTienKhamBenh crDSThuTienKhamBenh1;
    }
}