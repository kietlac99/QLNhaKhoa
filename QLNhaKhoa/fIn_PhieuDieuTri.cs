using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNhaKhoa
{
    public partial class fIn_PhieuDieuTri : Form
    {
        public fIn_PhieuDieuTri()
        {
            InitializeComponent();
        }

        private void fIn_PhieuDieuTri_Load(object sender, EventArgs e)
        {
            string maDT = fKhamBenhDieuTri.maDT;

            KetNoiDuLieu kndl = new KetNoiDuLieu();

            SqlConnection conn = new SqlConnection(@Connection.conn);

            kndl.KiemTraKetNoi(conn);

            SqlDataAdapter da = new SqlDataAdapter("exec SP_DieuTri_In '" + maDT + "'", conn);

            DataSet st = new DataSet();

            da.Fill(st, "DieuTriThuThuat");

            rptPhieuDieuTri1.SetDataSource(st);

            crvPhieuDieuTri.ReportSource = rptPhieuDieuTri1;

            crvPhieuDieuTri.Refresh();

            crvPhieuDieuTri.RefreshReport();

            conn.Close();
        }
    }
}
