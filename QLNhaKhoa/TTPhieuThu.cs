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
    public partial class fTTPhieuThu : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        string id_per = fDangNhap.ID_Per;

        public static bool TTPhieuThu = false;

        public static string maPT = "";

        Form activeForm = null;

        public fTTPhieuThu()
        {
            InitializeComponent();

            LoadDataGrid();

            LoadThongTin();

            ButtonPermission();
        }

        void ButtonPermission()
        {
            if (id_per == "5")
            {
                string canSearch = fDangNhap.arrTimKiem[9];

                ti.QuyenThaoTac(canSearch, ibtnTimKiem);
            }
        }

        void LoadThongTin()
        {
            txtHoTen.MaxLength = 302;
            txtNguoiLapPhieu.MaxLength = 30;

            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "dd-MM-yyyy";
            dtpNgayBatDau.MaxDate = DateTime.Today;

            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd-MM-yyyy";
            dtpNgayKetThuc.MaxDate = DateTime.Now;         
        }

        private void LoadDataGrid()
        {
            kndl.KetNoiDataGridView("select * from vw_PhieuThu_ThongTin", dgvPhieuThu, conn);
        }

        private void txtMaHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            string ho = "";
            string tendem = "";
            string ten = "";

            ti.TachTen(txtHoTen, ref ho, ref tendem, ref ten);

            string query = "exec SP_PhieuThu_TimKiem '" + txtSoHS.Text + "', N'" + ho + "%', N'" + tendem + "%', N'" + ten + "%', '" + txtNguoiLapPhieu.Text + "%', '" + dtpNgayBatDau.Value.ToString() + "', '" + dtpNgayKetThuc.Value.ToString() + "'";

            kndl.KetNoiDataGridView(query, dgvPhieuThu, conn);
        }

        private void dgvPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maPT = dgvPhieuThu.Rows[e.RowIndex].Cells["clMaPT"].Value.ToString();
            }
            catch (Exception)
            {
                maPT = "";
            }
        }

        private void dgvPhieuThu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(maPT != "")
            {
                fKhamBenhDieuTri fkbdt = new fKhamBenhDieuTri();

                TTPhieuThu = true;

                ti.OpenForm_2(ref activeForm, new fPhieuThu(fkbdt));
            }    
        }
    }
}
