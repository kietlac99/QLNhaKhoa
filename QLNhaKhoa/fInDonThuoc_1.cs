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
    public partial class fInDonThuoc_1 : Form
    {
        public fInDonThuoc_1()
        {
            InitializeComponent();
        }

        private void fInDonThuoc_1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rptDonThuoc1;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
        }
    }
}
