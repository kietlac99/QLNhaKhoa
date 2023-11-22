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
    public partial class fMauDonThuoc : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        KiemTraLoi ktl = new KiemTraLoi();

      

        Form activeForm = null;

        public static bool activeThemMDT = false;
        public static bool activeSuaMDT = false;
        public static bool activeThemThuoc = false;
        public static bool activeSuaThuoc = false;

        public static string maT = "";
        public static string maMDT = "";

        string maCTMDT = "";
        string id_per = fDangNhap.ID_Per;


        public fMauDonThuoc()
        {
            InitializeComponent();

            LoadMauDonThuoc();

            LoadThuoc();

            dgvMauDT_CellClick(dgvMauDT, new DataGridViewCellEventArgs(1, 0));
            dgvThuoc_CellClick(dgvThuoc, new DataGridViewCellEventArgs(1, 0));

            ActionLoad();

            ButtonPermission();
        }

        void ActionLoad()
        {
            if(id_per == "5")
            {
                kndl.ActionLoad(conn);
            }    
        }

        void ButtonPermission()
        {
            if (id_per == "5")
            {
                string add = fDangNhap.arrThem[5];
                string edit = fDangNhap.arrSua[5];
                string delete = fDangNhap.arrXoa[5];
                string search = fDangNhap.arrTimKiem[5];

                ti.QuyenThaoTac(add, ibtnThem);
                ti.QuyenThaoTac(add, ibtnThemMauDT);
                ti.QuyenThaoTac(edit, ibtnSuaMauDT);
                ti.QuyenThaoTac(edit, ibtnSua);
                ti.QuyenThaoTac(delete, ibtnXoa);
                ti.QuyenThaoTac(delete, ibtnXoaMauDT);
                ti.QuyenThaoTac(delete, ibtnXoaCTMDT);
                ti.QuyenThaoTac(search, ibtnTimKiem);

                if(ibtnSua.Enabled == false)
                {
                    dgvThuoc.Enabled = false;
                    txtSoLuong.Enabled = false;
                    dgvChiTietMDT.Enabled = false;
                }    
            }
        }

        public void LoadMauDonThuoc()
        {
            kndl.KetNoiDataGridView("select * from vw_MauDonThuoc", dgvMauDT, conn);
        }

        public void LoadThuoc()
        {
            kndl.KetNoiDataGridView("select * from vw_Thuoc", dgvThuoc, conn);
        }
      
        private void ibtnThemMauDT_Click(object sender, EventArgs e)
        {
            activeThemMDT = true;
            activeSuaMDT = false;
            ti.OpenForm(ref activeForm, new fMDT(this));
        }

        private void dgvMauDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maMDT = dgvMauDT.Rows[e.RowIndex].Cells["clMaMDT"].Value.ToString();

                kndl.KetNoiDataGridView("exec SP_ChiTietMDT_Theo_MaMDT '" + maMDT + "'", dgvChiTietMDT, conn);

                lbTenMDT.Text = dgvMauDT.Rows[e.RowIndex].Cells["clTenMDT"].Value.ToString();

                dgvChiTietMDT_CellClick(dgvChiTietMDT, new DataGridViewCellEventArgs(3, 0));
            }
            catch (Exception)
            {
                maMDT = "";
            }
        }

        private void dgvChiTietMDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maCTMDT = dgvChiTietMDT.Rows[e.RowIndex].Cells["clMaCTMDT"].Value.ToString();
            }
            catch (Exception)
            {
                maCTMDT = "";
            }
        }

        private void ibtnXoaMauDT_Click(object sender, EventArgs e)
        {
            if(maMDT!="")
            {
                string thongTinXoa = "Không thể xóa!";
                string ChiTietMDT = "";

                string sql_ChiTietMDT = "exec SP_ChiTietThuThuat_Dem '" + maMDT + "'";

                ChiTietMDT = ktl.ThongTinXoa(sql_ChiTietMDT, "Chi tiết mẫu đơn thuốc", conn);
                thongTinXoa += "(" + ChiTietMDT + ")";

                if (thongTinXoa == "Không thể xóa!()")
                {
                    if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string delete = "exec SP_MauDonThuoc_Xoa '" + maMDT + "'";

                        kndl.ThucThiDuLieu_KhongTraVe(delete, conn);

                        LoadMauDonThuoc();

                        dgvMauDT.ClearSelection();
                        if (dgvMauDT.Rows.Count > 0)
                        {
                            dgvMauDT.Rows[0].Selected = false;
                        }

                        maMDT = "";
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

        private void ibtnThem_Click(object sender, EventArgs e)
        {
            activeThemThuoc = true;
            activeSuaThuoc = false;
            ti.OpenForm(ref activeForm, new fThuoc(this));
        }

        private void ibtnSuaMauDT_Click(object sender, EventArgs e)
        {
            activeSuaMDT = true;
            activeThemMDT = false;
            ti.OpenForm(ref activeForm, new fMDT(this));
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maT = dgvThuoc.Rows[e.RowIndex].Cells["clMaT"].Value.ToString();
            }
            catch (Exception)
            {
                maT = "";
            }
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            if(maT!="")
            {
                activeSuaThuoc = true;
                activeThemThuoc = false;
                ti.OpenForm(ref activeForm, new fThuoc(this));
            }    
            else
            {
                MessageBox.Show("Chọn thông tin để sửa!");
            }    
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if (maT != "")
            {
                string thongTinXoa = "Không thể xóa!";
                string ChiTietDonThuoc = "";
                string ChiTietMDT = "";

                string sql_ChiTietDonThuoc = "exec SP_ChiTietDonThuoc_Dem_MaT '" + maT + "'";
                string sql_ChiTietMDT = "exec SP_ChiTietMauDonThuoc_Dem_MaT '" + maT + "'";

                ChiTietDonThuoc = ktl.ThongTinXoa(sql_ChiTietDonThuoc, "Chi tiết đơn thuốc", conn);
                ChiTietMDT = ktl.ThongTinXoa(sql_ChiTietMDT, "Chi tiết mẫu đơn thuốc", conn);

                thongTinXoa += "(" + ChiTietDonThuoc + " - " + ChiTietMDT + ")";

                if (thongTinXoa == "Không thể xóa!( - )")
                {
                    if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string delete = "exec SP_Thuoc_Xoa '" + maT + "'";

                        kndl.ThucThiDuLieu_KhongTraVe(delete, conn);

                        LoadThuoc();

                        dgvThuoc.ClearSelection();

                        if (dgvThuoc.Rows.Count > 0)
                        {
                            dgvThuoc.Rows[0].Selected = false;
                        }

                        maT = "";
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

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            dgvMauDT.ClearSelection();
            dgvThuoc.ClearSelection();

            dgvMauDT_CellClick(dgvMauDT, new DataGridViewCellEventArgs(1, 0));
            dgvThuoc_CellClick(dgvThuoc, new DataGridViewCellEventArgs(1, 0));

            if (dgvMauDT.Rows.Count > 0)
            {
                dgvMauDT.Rows[0].Cells[1].Selected = true;
            }

            if (dgvThuoc.Rows.Count > 0)
            {
                dgvThuoc.Rows[0].Cells[1].Selected = true;
            }

            txtSoLuong.Clear();
        }

        private void dgvThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(maMDT != "")
            {
                if (maT != "")
                {
                    string sql = "exec SP_ChiTietMDT_Them_tran '" + maMDT + "', '" + maT + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                    kndl.KetNoiDataGridView("exec SP_ChiTietMDT_Theo_MaMDT '" + maMDT + "'", dgvChiTietMDT, conn);
                }    
            }    
            else
            {
                MessageBox.Show("Vui lòng chọn mẫu đơn thuốc!");
            }    
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (maCTMDT != "")
                {
                    string sql = "exec SP_ChiTietMDT_Sua_SoLuong '" + maCTMDT + "', '" + txtSoLuong.Text + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                    kndl.KetNoiDataGridView("exec SP_ChiTietMDT_Theo_MaMDT '" + maMDT + "'", dgvChiTietMDT, conn);

                    dgvChiTietMDT.CurrentCell.Selected = true;
                }
                else
                {
                    MessageBox.Show("Chọn thông tin để sửa!");
                }    
            }    

            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void dgvChiTietMDT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maMDT != "")
            {
                if (maCTMDT != "")
                {
                    string sql = "exec SP_ChiTietMDT_Sua '" + maCTMDT + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                    kndl.KetNoiDataGridView("exec SP_ChiTietMDT_Theo_MaMDT '" + maMDT + "'", dgvChiTietMDT, conn);

                    dgvChiTietMDT.CurrentCell = dgvChiTietMDT.Rows[e.RowIndex].Cells["clTenThuoc"];

                    dgvChiTietMDT.CurrentCell.Selected = true;

                    dgvChiTietMDT.BeginEdit(true);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mẫu đơn thuốc!");
            }
        }

        private void ibtnXoaCTMDT_Click(object sender, EventArgs e)
        {
            if (maCTMDT != "")
            {
                if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string delete = "exec SP_ChiTietMDT_Xoa '" + maCTMDT + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(delete, conn);

                    kndl.KetNoiDataGridView("exec SP_ChiTietMDT_Theo_MaMDT '" + maMDT + "'", dgvChiTietMDT, conn);

                    dgvChiTietMDT.ClearSelection();

                    if (dgvChiTietMDT.Rows.Count > 0)
                    {
                        dgvChiTietMDT.Rows[0].Selected = false;
                    }

                    maCTMDT = "";
                }
            }
            else
            {
                MessageBox.Show("Chọn thông tin để xóa!");
            }
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "exec SP_Thuoc_TimKiem_TenThuoc N'" + txtThuoc.Text + "%'";

            kndl.KetNoiDataGridView(sql, dgvThuoc, conn);

            dgvThuoc.ClearSelection();

            if(dgvThuoc.Rows.Count>0)
            {
                dgvThuoc.Rows[0].Selected = false;
            }

            maT = "";
        }
    }
}
