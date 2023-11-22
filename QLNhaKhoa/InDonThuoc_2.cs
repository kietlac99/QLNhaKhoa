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
    public partial class fInDonThuoc_2 : Form
    {
        public fInDonThuoc_2()
        {
            InitializeComponent();
        }
        private void fInDonThuoc_2_Load(object sender, EventArgs e)
        {
            string maDThuoc = fDanhSachDonThuoc.maDThuoc;

            KetNoiDuLieu kndl = new KetNoiDuLieu();

            SqlConnection conn = new SqlConnection(@Connection.conn);

            kndl.KiemTraKetNoi(conn);

            SqlDataAdapter da = new SqlDataAdapter("exec SP_DonThuoc_In '" + maDThuoc + "'", conn);

            DataSet st = new DataSet();

            da.Fill(st, "DonThuoc");

            rptDonThuoc___Copy1.SetDataSource(st);

            cryvwDonThuoc.ReportSource = rptDonThuoc___Copy1;

            cryvwDonThuoc.Refresh();

            cryvwDonThuoc.RefreshReport();

            conn.Close();
        }
    }
}
