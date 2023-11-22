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
    public partial class fQuanLyNhanVien : Form
    {
        KetNoiDuLieu kndl = new KetNoiDuLieu();

        SqlConnection conn = new SqlConnection(@Connection.conn);

        KiemTraLoi ktl = new KiemTraLoi();

        TienIch ti = new TienIch();

        static public bool btnThem_active = false;
        static public bool btnSua_active = false;
        public fQuanLyNhanVien()
        {
            InitializeComponent();
            TruyenDataGrid();
            ActionLoad();
            ButtonPermisson();
        }

        string id_per = fDangNhap.ID_Per;

        void ActionLoad()
        {
            
            if (id_per == "5")
            {
                kndl.ActionLoad(conn);
            }
        }

        void ButtonPermisson()
        {
            if (id_per == "5")
            {
                string canAdd = fDangNhap.arrThem[1];
                string canEdit = fDangNhap.arrSua[1];
                string canDelete = fDangNhap.arrXoa[1];
                string canSearch = fDangNhap.arrTimKiem[1];

                ti.QuyenThaoTac(canAdd, ibtnThem);
                ti.QuyenThaoTac(canEdit, ibtnSua);
                ti.QuyenThaoTac(canDelete, ibtnXoa);
                ti.QuyenThaoTac(canSearch, ibtnTimKiem);
            }
        }

        public void TruyenDataGrid()
        {
            kndl.KetNoiDataGridView("select * from vw_TTNhanVien", dgvTTNhanVien, conn);           
        }

        Form activeForm = null;
        void openForm(Form form)
        {
            if (activeForm != null)
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
            openForm(new fTTNhanVien(this));
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            if (maN!="")
            {
                btnThem_active = false;
                btnSua_active = true;
                openForm(new fTTNhanVien(this));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin để sửa!");
            }    
        }

        public static string maN = "";
        public static string maNV = "";
        
        private void dgvTTNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {              
                maN = dgvTTNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();  
                maNV = dgvTTNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception)
            {
                maN = "";
                maNV = "";
            }
            
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if (maNV != "")
            {
                string thongTinXoa = "Không thể xóa!";
                string LichHen = "";
                string DieuTri = "";
                string PhieuThu = "";
                string DonThuoc = "";
                string NhomDieuTri = "";

                string sql_LichHen = "exec SP_LichHen_NhanVien_Dem '" + maNV + "'";
                string sql_DieuTri = "exec SP_DieuTri_NhanVien_Dem '" + maNV + "'";
                string sql_PhieuThu = "exec SP_PhieuThu_NhanVien_Dem '" + maNV + "'";
                string sql_DonThuoc = "exec SP_DonThuoc_NhanVien_Dem '" + maNV + "'";
                string sql_NhomDieuTri = "exec SP_NhomDieuTri_NhanVien_Dem '" + maNV + "'";

                LichHen = ktl.ThongTinXoa(sql_LichHen, "Lịch hẹn", conn);
                DieuTri = ktl.ThongTinXoa(sql_DieuTri, "Điều trị", conn);
                PhieuThu = ktl.ThongTinXoa(sql_PhieuThu, "Phiếu thu", conn);
                DonThuoc = ktl.ThongTinXoa(sql_DonThuoc, "Đơn thuốc", conn);
                NhomDieuTri = ktl.ThongTinXoa(sql_NhomDieuTri, "Nhóm điều trị", conn);

                thongTinXoa += "(" + LichHen + " - " + DieuTri + " - " + PhieuThu + " - " + DonThuoc + " - " + NhomDieuTri + ")";
                
                if(thongTinXoa == "Không thể xóa!( -  -  -  - )")
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult==DialogResult.Yes)
                    {
                        string Delete_Nguoi = "exec SP_Nguoi_Xoa '" + maN + "'";
                        string Delete_NhanVien = "exec SP_NhanVien_Xoa '" + maNV + "'";

                        kndl.ThucThiDuLieu_KhongTraVe(Delete_NhanVien, conn);
                        kndl.ThucThiDuLieu_KhongTraVe(Delete_Nguoi, conn);

                        MessageBox.Show("Xóa thành công!");

                        TruyenDataGrid();

                        dgvTTNhanVien.ClearSelection();

                        if (dgvTTNhanVien.Rows.Count > 0)
                        {
                            dgvTTNhanVien.Rows[0].Selected = false;
                        }

                        maNV = "";
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

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            string ho = "";
            string tendem = "";
            string ten = "";
            ti.TachTen(txtHoTen, ref ho, ref tendem, ref ten);

            string sql = "exec SP_NhanVien_HoTen N'" + ho + "%', N'" + tendem + "%', N'" + ten + "%'";

            kndl.KetNoiDataGridView(sql, dgvTTNhanVien, conn);

            dgvTTNhanVien.ClearSelection();

            if(dgvTTNhanVien.Rows.Count > 0 )
            {
                dgvTTNhanVien.Rows[0].Selected = false;
            }

            maNV = "";
        }

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            TruyenDataGrid();
        }
    }
}
