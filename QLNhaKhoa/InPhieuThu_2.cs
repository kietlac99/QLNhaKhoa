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
using CrystalDecisions.CrystalReports.Engine;

namespace QLNhaKhoa
{
    public partial class InPhieuThu_2 : Form
    {
        

        public InPhieuThu_2()
        {
            InitializeComponent();
        }

        private void InPhieuThu_2_Load(object sender, EventArgs e)
        {
            string maPT = fTTPhieuThu.maPT;

            KetNoiDuLieu kndl = new KetNoiDuLieu();

            SqlConnection conn = new SqlConnection(@Connection.conn);

            kndl.KiemTraKetNoi(conn);

            SqlDataAdapter da = new SqlDataAdapter("exec SP_PhieuThu_In '" + maPT + "'", conn);

            DataSet st = new DataSet();

            da.Fill(st, "DATAS");
       
            rptPhieuThu___Copy1.SetDataSource(st);

            cryInPhieuThu.ReportSource = rptPhieuThu___Copy1;

            cryInPhieuThu.Refresh();

            cryInPhieuThu.RefreshReport();

            conn.Close();
        }
    }
}
