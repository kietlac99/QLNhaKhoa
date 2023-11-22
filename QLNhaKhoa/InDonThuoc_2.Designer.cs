
namespace QLNhaKhoa
{
    partial class fInDonThuoc_2
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
            this.cryvwDonThuoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptDonThuoc___Copy1 = new QLNhaKhoa.rptDonThuoc___Copy();
            this.SuspendLayout();
            // 
            // cryvwDonThuoc
            // 
            this.cryvwDonThuoc.ActiveViewIndex = -1;
            this.cryvwDonThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryvwDonThuoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryvwDonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryvwDonThuoc.Location = new System.Drawing.Point(0, 0);
            this.cryvwDonThuoc.Name = "cryvwDonThuoc";
            this.cryvwDonThuoc.Size = new System.Drawing.Size(800, 450);
            this.cryvwDonThuoc.TabIndex = 0;
            // 
            // fInDonThuoc_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryvwDonThuoc);
            this.Name = "fInDonThuoc_2";
            this.Text = "InDonThuoc_2";
            this.Load += new System.EventHandler(this.fInDonThuoc_2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryvwDonThuoc;
        private rptDonThuoc___Copy rptDonThuoc___Copy1;
    }
}