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
    public partial class fNhomThuThuat : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KiemTraLoi ktl = new KiemTraLoi();

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        static public bool btnThem_active = false;
        static public bool btnSua_active = false;

        static public bool btnThemNTT_active = false;
        static public bool btnSuaNTT_active = false;

        public fNhomThuThuat()
        {
            InitializeComponent();
            LoadDataGrid();
            ActionLoad();
            ButtonPermission();
        }

        void LoadDataGrid()
        {            
            LoadDataGrid_NhomThuThuat();

            dgvNhomTT_CellClick(dgvNhomTT, new DataGridViewCellEventArgs(1, 0));       
        }

        public void LoadDataGrid_ThuThuat()
        {
            string sql_ThuThuat = "select * from vw_ThuThuat";
            kndl.KetNoiDataGridView(sql_ThuThuat, dgvTT, conn);
        }

        public void LoadDataGrid_NhomThuThuat()
        {
            string sql_NhomTT = "select * from vw_NhomThuThuat";
            kndl.KetNoiDataGridView(sql_NhomTT, dgvNhomTT, conn);
        }
     
        public static string maNhomTT = "";

        private void dgvNhomTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                maNhomTT = dgvNhomTT.Rows[e.RowIndex].Cells["clMaTT"].Value.ToString();
                kndl.KetNoiDataGridView("exec SP_ThuThuat '" + maNhomTT + "'", dgvTT, conn);
                lbTenNTT.Text = dgvNhomTT.Rows[e.RowIndex].Cells["clTenNhomTT"].Value.ToString().ToUpper();

                dgvTT_CellClick(dgvTT, new DataGridViewCellEventArgs(0, 0));

            }
            catch (Exception)
            {
                maNhomTT = "";
            }
        }

        Form activeForm = null;

        void openForm(Form form)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.Show();
        }

        private void ibtnThem_Click(object sender, EventArgs e)
        {
            btnThem_active = true;
            btnSua_active = false;
            openForm(new fThuThuat(this));              
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            if (maTT != "")
            {
                btnSua_active = true;
                btnThem_active = false;
                openForm(new fThuThuat(this));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin để sửa!");
            }    
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            btnThemNTT_active = true;
            btnSuaNTT_active = false;
            openForm(new fNhomTT(this));
        }

        private void ibtnSuaNhomTT_Click(object sender, EventArgs e)
        {
            btnSuaNTT_active = true;
            btnThemNTT_active = false;
            openForm(new fNhomTT(this));
        }

        private void ibtnXoaNhomTT_Click(object sender, EventArgs e)
        {
            if(maNhomTT != "")
            {
                string thongTinXoa = "Không thể xóa!";
                string ThuThuat = "";

                string sql_ThuThuat = "exec SP_ChiTietThuThuat_Dem '" + maNhomTT + "'";
                ThuThuat = ktl.ThongTinXoa(sql_ThuThuat, "Thủ thuật", conn);

                thongTinXoa += "(" + ThuThuat + ")";

                if (thongTinXoa == "Không thể xóa!()")
                {
                    if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            kndl.KiemTraKetNoi(conn);

                            SqlCommand cmd = new SqlCommand("SP_NhomThuThuat_Delete '" + maNhomTT + "'", conn);
                          
                            cmd.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();

                            LoadDataGrid_NhomThuThuat();

                            dgvNhomTT.ClearSelection();

                            if (dgvNhomTT.Rows.Count > 0)
                            {
                                dgvNhomTT.Rows[0].Selected = false;
                            }

                            maNhomTT = "";

                        }
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

        public static string maTT = "";

        string MaNTT = "";

        private void dgvTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maTT = dgvTT.Rows[e.RowIndex].Cells["clMaCTTT"].Value.ToString();
                MaNTT = dgvTT.Rows[e.RowIndex].Cells["clMaThuThuat"].Value.ToString();
            }
            catch (Exception)
            {
                maTT = "";
                
            }
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if (maTT != "")
            {
                string thongTinXoa = "Không thể xóa!";
                string ChiTietDieuTri = "";

                string sql_ChiTietDT = "exec ChiTietDieuTri_Dem_ThuThuat '" + maTT + "'";
                ChiTietDieuTri = ktl.ThongTinXoa(sql_ChiTietDT, "Chi tiết điều trị", conn);

                thongTinXoa += "(" + ChiTietDieuTri + ")";

                if (thongTinXoa == "Không thể xóa!()")
                {
                    if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            kndl.KiemTraKetNoi(conn);

                            SqlCommand cmd = new SqlCommand("SP_ThuThuat_Xoa '" + maTT + "'", conn);

                            cmd.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();

                            kndl.KetNoiDataGridView("exec SP_ThuThuat '" + MaNTT + "'", dgvTT, conn);

                            dgvTT.ClearSelection();

                            if (dgvTT.Rows.Count > 0)
                            {
                                dgvTT.Rows[0].Selected = false;
                            }

                            maTT = "";
                        }
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
            dgvNhomTT.ClearSelection();

            dgvNhomTT_CellClick(dgvNhomTT, new DataGridViewCellEventArgs(1, 0));

            if (dgvNhomTT.Rows.Count > 0)
            {
                dgvNhomTT.Rows[0].Selected = true;
            }
        }

        string id_per = fDangNhap.ID_Per;
        
        void ActionLoad()
        {
            if(id_per == "5")
            {
                kndl.ActionLoad(conn);
            }    
        }

        void ButtonPermission()
        {
            if(id_per == "5")
            {
                string canAdd = fDangNhap.arrThem[4];
                string canEdit = fDangNhap.arrSua[4];
                string canDelete = fDangNhap.arrXoa[4];

                ti.QuyenThaoTac(canAdd, ibtnThem);
                ti.QuyenThaoTac(canAdd, ibtnThemNhomTT);
                ti.QuyenThaoTac(canEdit, ibtnSua);
                ti.QuyenThaoTac(canEdit, ibtnSuaNhomTT);
                ti.QuyenThaoTac(canDelete, ibtnXoa);
                ti.QuyenThaoTac(canDelete, ibtnXoaNhomTT);
            }    
        }
    }
}
