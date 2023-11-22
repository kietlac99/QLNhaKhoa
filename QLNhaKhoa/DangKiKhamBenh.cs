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
    public partial class fDangKiKhamBenh : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        KiemTraLoi ktl = new KiemTraLoi();

        Form activeForm = null;

        public static bool them = false;
        public static bool sua = false;

        public static string maBN = "";
        public static string maN = "";

        bool hs = false;
        bool hsc = false;
        bool isCheckedKham = false;
        bool isCheckedChuaKham = false;

        string ngayNhap = "";
        string id_per = fDangNhap.ID_Per;

        fMainForm fmf;
       
        public fDangKiKhamBenh(fMainForm fmf)
        {
            InitializeComponent();

            LoadDaTaGrid();

            LoadThongTin();

            ButtonPermission();

            this.fmf = fmf;
        }

        void ButtonPermission()
        {
            if(id_per == "5")
            {
                string canAdd = fDangNhap.arrThem[6];
                string canEdit = fDangNhap.arrSua[6];
                string canDelete = fDangNhap.arrXoa[6];
                string canSearch = fDangNhap.arrTimKiem[6];

                ti.QuyenThaoTac(canAdd, ibtnThem);
                ti.QuyenThaoTac(canEdit, ibtnSua);
                ti.QuyenThaoTac(canDelete, ibtnXoa);
                ti.QuyenThaoTac(canSearch, ibtnTimKiem);
            }    
        }

        public void LoadDaTaGrid()
        {
            kndl.KetNoiDataGridView("select * from vw_BenhNhan", dgvBenhNhan, conn);
          
        }

        void LoadThongTin()
        {          
            dtpChonNgay.Format = DateTimePickerFormat.Custom;
            dtpChonNgay.MaxDate = DateTime.Now;
            dtpChonNgay.CustomFormat = " ";

            ngayNhap = "";

            txtHoTen.MaxLength = 302;
            txtDienThoai.MaxLength = 10;           
        }

        private void dtpChonNgay_ValueChanged(object sender, EventArgs e)
        {
            dtpChonNgay.CustomFormat = "dd/MM/yyyy";
            ngayNhap = dtpChonNgay.Value.Date.ToString();
        }

        private void txtSoHSCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void txtSoHoSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maBN = dgvBenhNhan.Rows[e.RowIndex].Cells["clMaBN"].Value.ToString();
                maN = dgvBenhNhan.Rows[e.RowIndex].Cells["clMaN"].Value.ToString();
            }
            catch (Exception)
            {
                maBN = "";
            }
        }

        private void ibtnThem_Click(object sender, EventArgs e)
        {
            them = true;
            sua = false;
            ti.OpenForm_2(ref activeForm, new fBenhNhan(this));
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if(maBN != "")
            {
                string thongTinXoa = "Không thể xóa!";
                string LichHen = "";
                string DieuTri = "";

                string sql_LichHen = "exec SP_LichHen_Dem_MaBN '" + maBN + "'";
                string sql_DieuTri = "exec SP_DieuTri_Dem_MaBN '" + maBN + "'";

                LichHen = ktl.ThongTinXoa(sql_LichHen, "Lịch hẹn", conn);
                DieuTri = ktl.ThongTinXoa(sql_DieuTri, "Điều trị", conn);
                thongTinXoa += "(" + LichHen + " - " + DieuTri + ")";

                if (thongTinXoa == "Không thể xóa!( - )")
                {
                    if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string xoaChiTietTSB = "exec SP_ChiTietTienSuBenh_Xoa_Theo_MaBN '" + maBN + "'";
                        string xoaBenhNhan = "exec SP_BenhNhan_Xoa_Theo_MaBN '" + maBN + "'";
                        string xoaNguoi = "exec SP_Nguoi_Xoa '" + maN + "'";

                        kndl.ThucThiDuLieu_KhongTraVe(xoaChiTietTSB, conn);
                        kndl.ThucThiDuLieu_KhongTraVe(xoaBenhNhan, conn);
                        kndl.ThucThiDuLieu_KhongTraVe(xoaNguoi, conn);

                        LoadDaTaGrid();

                        dgvBenhNhan.ClearSelection();
                        if (dgvBenhNhan.Rows.Count > 0)
                        {
                            dgvBenhNhan.Rows[0].Selected = false;
                        }

                        maBN = "";

                        ti.RowsColor("clNgayGio", tmBenhNhan, dgvBenhNhan);
                    }
                }
                else
                {
                    MessageBox.Show(thongTinXoa);
                }
            }
            else
            {
                MessageBox.Show("Chọn thông tin để xóa!");
            }
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            if(maBN != "")
            {
                sua = true;
                them = false;
                ti.OpenForm_2(ref activeForm, new fBenhNhan(this));
            }    
            else
            {
                MessageBox.Show("Chọn thông tin để sửa!");
            }    
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            //ti.TrimTextBoxes(this.Controls);

            string loaihs = "";
            string sohs = "";
            string sql = "";
            string ho = "";
            string tendem = "";
            string ten = "";

            if(txtSoHoSo.TextLength > 0)
            {
                loaihs = "0";
                sohs = txtSoHoSo.Text;
            }    
            else if(txtSoHSCu.TextLength > 0)
            {
                loaihs = "1";
                sohs = txtSoHSCu.Text;
            }

            ti.TachTen(txtHoTen, ref ho, ref tendem, ref ten);

            if(rdChuaKham.Checked)
            {
                sql = "exec SP_BenhNhan_TimKiem '0', '" + loaihs + "', '" + ngayNhap + "', '" + sohs + "', '" + txtDienThoai.Text + "', N'" + ho + "%', N'" + tendem + "%', N'" + ten + "%'";
            }    
            else if(rbDaKham.Checked)
            {
                sql = "exec SP_BenhNhan_TimKiem '1', '" + loaihs + "', '" + ngayNhap + "', '" + sohs + "', '" + txtDienThoai.Text + "', N'" + ho + "%', N'" + tendem + "%', N'" + ten + "%'";
            }
            else
            {
                sql = "exec SP_BenhNhan_TimKiem '2', '" + loaihs + "', '" + ngayNhap + "', '" + sohs + "', '" + txtDienThoai.Text + "', N'" + ho + "%', N'" + tendem + "%', N'" + ten + "%'";
            }

            ti.RowsColor("clNgayGio", tmBenhNhan, dgvBenhNhan);

            kndl.KetNoiDataGridView(sql, dgvBenhNhan, conn);
        }

        private void txtSoHSCu_TextChanged(object sender, EventArgs e)
        {
            if (hsc)
            {
                txtSoHoSo.Text = "";              
            }
        }

        private void txtSoHoSo_TextChanged(object sender, EventArgs e)
        {
            if (hs)
            {
                txtSoHSCu.Text = "";
            }
        }

        private void txtSoHSCu_Click(object sender, EventArgs e)
        {
            hsc = true;
            hs = false;
        }

        private void txtSoHoSo_Click(object sender, EventArgs e)
        {
            hs = true;
            hsc = false;
        }

        private void rdChuaKham_Click(object sender, EventArgs e)
        {
            if (rdChuaKham.Checked && !isCheckedChuaKham)
            {
                rdChuaKham.Checked = false;
            }
            else
            {
                rdChuaKham.Checked = true;
                isCheckedChuaKham = false;
            }    
        }

        private void rbDaKham_Click(object sender, EventArgs e)
        {
            if (rbDaKham.Checked && !isCheckedKham)
            {
                rbDaKham.Checked = false;
            }
            else
            {
                rbDaKham.Checked = true;
                isCheckedKham = false;
            }    
        }

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            ti.ClearTextBoxes(this.Controls);

            dtpChonNgay.CustomFormat = " ";

            ngayNhap = "";

            rdChuaKham.Checked = false;
            rbDaKham.Checked = false;

            LoadDaTaGrid();

            ti.RowsColor("clNgayGio", tmBenhNhan, dgvBenhNhan);
        }

        private void rdChuaKham_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedChuaKham = rdChuaKham.Checked;
        }

        private void rbDaKham_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedKham = rbDaKham.Checked;
        }

        void openChildForm(Form childForm)
        {
            Form fdkkb = new fDangKiKhamBenh(fmf);

            fdkkb.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            fmf.pnDesktop.Controls.Add(childForm);
            fmf.pnDesktop.Tag = childForm;
            childForm.BringToFront();
            try
            {
                childForm.Show();
            }
            catch (Exception)
            {
                childForm.Show();
            }
            

        }

        private void dgvBenhNhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maBN != "")
            {
                openChildForm(new fKhamBenhDieuTri());
            }
        }

        private void fDangKiKhamBenh_Load(object sender, EventArgs e)
        {
            ti.RowsColor("clNgayGio", tmBenhNhan, dgvBenhNhan);
        }

        private void tmBenhNhan_Tick(object sender, EventArgs e)
        {
            ti.Timer_Tick("clNgayGio", dgvBenhNhan);
        }

        private void dgvBenhNhan_Sorted(object sender, EventArgs e)
        {
            ti.RowsColor("clNgayGio", tmBenhNhan, dgvBenhNhan);
        }
    }
}
