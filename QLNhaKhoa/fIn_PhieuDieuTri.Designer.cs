
namespace QLNhaKhoa
{
    partial class fIn_PhieuDieuTri
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
            this.crvPhieuDieuTri = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPhieuDieuTri1 = new QLNhaKhoa.rptPhieuDieuTri();
            this.SuspendLayout();
            // 
            // crvPhieuDieuTri
            // 
            this.crvPhieuDieuTri.ActiveViewIndex = -1;
            this.crvPhieuDieuTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPhieuDieuTri.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPhieuDieuTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPhieuDieuTri.Location = new System.Drawing.Point(0, 0);
            this.crvPhieuDieuTri.Name = "crvPhieuDieuTri";
            this.crvPhieuDieuTri.Size = new System.Drawing.Size(800, 450);
            this.crvPhieuDieuTri.TabIndex = 0;
            // 
            // fIn_PhieuDieuTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvPhieuDieuTri);
            this.Name = "fIn_PhieuDieuTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fIn_PhieuDieuTri";
            this.Load += new System.EventHandler(this.fIn_PhieuDieuTri_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPhieuDieuTri;
        private rptPhieuDieuTri rptPhieuDieuTri1;
    }
}