
namespace QLNhaKhoa
{
    partial class InPhieuThu_2
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
            this.cryInPhieuThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPhieuThu___Copy1 = new QLNhaKhoa.rptPhieuThu___Copy();
            this.SuspendLayout();
            // 
            // cryInPhieuThu
            // 
            this.cryInPhieuThu.ActiveViewIndex = -1;
            this.cryInPhieuThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryInPhieuThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryInPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryInPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.cryInPhieuThu.Name = "cryInPhieuThu";
            this.cryInPhieuThu.Size = new System.Drawing.Size(800, 450);
            this.cryInPhieuThu.TabIndex = 0;
            // 
            // InPhieuThu_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryInPhieuThu);
            this.Name = "InPhieuThu_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InPhieuThu_2";
            this.Load += new System.EventHandler(this.InPhieuThu_2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryInPhieuThu;
        private rptPhieuThu___Copy rptPhieuThu___Copy1;
    }
}