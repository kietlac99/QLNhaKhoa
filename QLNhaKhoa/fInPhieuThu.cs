using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa
{
    public partial class fInPhieuThu : Form
    {
        public fInPhieuThu()
        {
            InitializeComponent();
        }

        private void fInPhieuThu_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rptPhieuThu1;

            crystalReportViewer1.Refresh();

            crystalReportViewer1.RefreshReport();          
        }
    }
}
