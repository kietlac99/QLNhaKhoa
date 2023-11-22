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
    public partial class fDanhSachDonThuoc : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        Form activeForm = null;

        public static bool DSDonThuoc = false;

        public static string maDThuoc = "";
        public static string maBN = "";
        public static string maDT = "";

        string id_per = fDangNhap.ID_Per;      

        public fDanhSachDonThuoc()
        {
            InitializeComponent();

            LoadThongTin();

            LoadDataGrid();

            ButtonPermission();
        }

        void ButtonPermission()
        {
            if (id_per == "5")
            {              
                string canSearch = fDangNhap.arrTimKiem[7];
                string canDelete = fDangNhap.arrXoa[7];

                ti.QuyenThaoTac(canSearch, ibtnTimKiem);
                ti.QuyenThaoTac(canDelete, ibtnXoa);
            }
        }

        void LoadThongTin()
        {
            txtHoTen.MaxLength = 302;
            txtNguoiKe.MaxLength = 30;

            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "dd-MM-yyyy";
            dtpNgayBatDau.MaxDate = DateTime.Today;

            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.CustomFormat = "dd-MM-yyyy";
            dtpNgayKetThuc.MaxDate = DateTime.Now;
        }

        void LoadDataGrid()
        {
            kndl.KetNoiDataGridView("select * from vw_DonThuoc_DanhSach", dgvDanhSachDonThuoc, conn);
        }

        private void txtSoHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            string ho = "";
            string tendem = "";
            string ten = "";
            string query = "exec SP_DonThuoc_TimKiem '" + txtSoHS.Text + "', N'" + ho + "%', N'" + tendem + "%', N'" + ten + "%', '" + txtNguoiKe.Text + "%', '" + dtpNgayBatDau.Value.Date.ToString() + "', '" + dtpNgayKetThuc.Value.Date.ToString() + "'";

            ti.TachTen(txtHoTen, ref ho, ref tendem, ref ten);

            kndl.KetNoiDataGridView(query, dgvDanhSachDonThuoc, conn);
        }

        private void dgvDanhSachDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maDThuoc = dgvDanhSachDonThuoc.Rows[e.RowIndex].Cells["clMaDThuoc"].Value.ToString();
                maBN = dgvDanhSachDonThuoc.Rows[e.RowIndex].Cells["clMaBN"].Value.ToString();
                maDT = dgvDanhSachDonThuoc.Rows[e.RowIndex].Cells["clMaDT"].Value.ToString();
            }
            catch (Exception)
            {
                maDThuoc = "";
                maBN = "";
                maDT = "";
            }
        }

        private void dgvDanhSachDonThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string canEdit = "True";

            if (id_per == "5")
            {
                canEdit = fDangNhap.arrSua[7];
            }

            if (maDThuoc != "" && canEdit == "True")
            {
                DSDonThuoc = true;

                ti.OpenForm_2(ref activeForm, new fDonThuoc());
            }    
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận xóa đơn thuốc?", "Xóa đơn thốc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "exec SP_DonThuoc_Xoa '" + maDThuoc + "'";

                kndl.ThucThiDuLieu_KhongTraVe(query, conn);

                LoadDataGrid();
            }    
        }
    }
}
