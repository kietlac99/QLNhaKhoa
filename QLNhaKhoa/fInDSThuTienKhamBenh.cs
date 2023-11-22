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
    public partial class fInDSThuTienKhamBenh : Form
    {
        public fInDSThuTienKhamBenh()
        {
            InitializeComponent();
        }

        private void fInDSThuTienKhamBenh_Load(object sender, EventArgs e)
        {
            DateTime tuNgay = fDanhSachThuTienKhamBenh.tuNgay;
            DateTime denNgay = fDanhSachThuTienKhamBenh.denNgay;

            KetNoiDuLieu kndl = new KetNoiDuLieu();

            SqlConnection conn = new SqlConnection(@Connection.conn);

            kndl.KiemTraKetNoi(conn);

            SqlDataAdapter da = new SqlDataAdapter("exec SP_PhieuThu_BaoCao '" + tuNgay + "', '" + denNgay + "'", conn);

            DataSet ds = new DataSet();

            da.Fill(ds, "DanhSachThuTienKhamBenh");

            crDSThuTienKhamBenh1.SetDataSource(ds);

            crvDSThuTienKhamBenh.ReportSource = crDSThuTienKhamBenh1;

            crvDSThuTienKhamBenh.Refresh();

            crvDSThuTienKhamBenh.RefreshReport();

            conn.Close();
        }
    }
}
