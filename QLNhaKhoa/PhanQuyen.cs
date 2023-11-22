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
    public partial class fPhanQuyen : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        KiemTraLoi ktl = new KiemTraLoi();

        TienIch ti = new TienIch();

        bool ThemClicked = false;

        bool SuaClicked = false;

        string maNV_ChuaCoTK = "";

        string maNV_CoTK = "";

        string maTK = "";

        string tenTK = "";
        string maHD = "";
   

        public fPhanQuyen()
        {
            InitializeComponent();
            LoadThongTin();
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
                string canAdd = fDangNhap.arrThem[2];
                string canEdit = fDangNhap.arrSua[2];
                string canDelete = fDangNhap.arrXoa[2];
                string canSearch = fDangNhap.arrTimKiem[2];

                ti.QuyenThaoTac(canAdd, ibtnThem);
                ti.QuyenThaoTac(canEdit, ibtnSua);
                ti.QuyenThaoTac(canDelete, ibtnXoa);
                ti.QuyenThaoTac(canSearch, ibtnTimKiem);
            }
        }

        void LoadThongTin()
        {
            pnTTNguoiDung.Enabled = false;
            TextLength();
            
            TruyenDataGrid_TaiKhoan();          
        }

        private void TruyenDataGrid_TaiKhoan()
        {
            string str = "select * from vw_NhanVien_TaiKhoan";

            kndl.KetNoiDataGridView(str, dgvTaiKhoan, conn);
        }

       

        private void TextLength()
        {
            txtTenDangNhap.MaxLength = 30;
            txtMatKhau.MaxLength = 127;
            txtTaiKhoan.MaxLength = 30;
        }

        bool CheckDuplicate()
        {
            string sqlKiemTraTrung_TenTK = "exec SP_TaiKhoan_TenTK_Dem '" + txtTenDangNhap.Text + "'";
            bool isDuplicate = false;
            ktl.TrungLap(sqlKiemTraTrung_TenTK, "Tên tài khoản đã được sử dụng!", ref isDuplicate, erpPhanQuyen, txtTenDangNhap, conn);
            return isDuplicate;
        }

        bool CheckError()
        {
            bool haveError = false;
            
            ktl.Rong("Bạn chưa nhập tài khoản!", ref haveError, erpPhanQuyen, txtTenDangNhap);
            
            ktl.Rong("Bạn chưa nhập mật khẩu!", ref haveError, erpPhanQuyen, txtMatKhau);
                        
            return haveError;
        }

        void BatThaoTac()
        {
            pnTTNguoiDung.Enabled = true;
            ibtnThem.Enabled = false;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;

            
        }

        void TatThaoTac()
        {

            
            pnTTNguoiDung.Enabled = false;
            ibtnThem.Enabled = true;
            ibtnSua.Enabled = true;
            ibtnXoa.Enabled = true;

            if (ThemClicked)
            {
                cbxNhanVien.DataSource = null;
            }
            else if(SuaClicked)
            {
                cbxNhanVien.Items.Clear();
            }    

            SuaClicked = false;
            ThemClicked = false;

            
            
            cbxNhanVien.Enabled = true;


            Clear();
        }

        private void ibtnThem_Click(object sender, EventArgs e)
        {

            kndl.VaoComboBox("select * from vw_NhanVien_TaiKhoan_NotHave", cbxNhanVien, "MaNV", "HoTen", conn);
            if (cbxNhanVien.SelectedValue != null)
            {
                maNV_ChuaCoTK = cbxNhanVien.SelectedValue.ToString();
                BatThaoTac();
                ThemClicked = true;
                SuaClicked = false;                
            }
            else
            {
                MessageBox.Show("Không có nhân viên cần thêm tài khoản!");
            }    

            
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            TruyenDataGrid_TaiKhoan();
            dgvQuyen.DataSource = null;
        }
     
        void Them()
        {
            ti.RemoveSign4VietnameseString(txtTenDangNhap.Text);
            ti.RemoveSign4VietnameseString(txtMatKhau.Text);

            bool haveError = CheckError();
            bool isDuplicate = CheckDuplicate();
                    
            if(haveError == false && isDuplicate == false)
            {


                string Insert_TaiKhoan = "exec SP_TaiKhoan_Them '" + txtTenDangNhap.Text + "', '" + txtMatKhau.Text + "', '" + maNV_ChuaCoTK + "'";

                kndl.ThucThiDuLieu_KhongTraVe(Insert_TaiKhoan, conn);

                TruyenDataGrid_TaiKhoan();

                MessageBox.Show("Thêm thành công!");

                cbxNhanVien.DataSource = null;

                kndl.VaoComboBox("select * from vw_NhanVien_TaiKhoan_NotHave", cbxNhanVien, "MaNV", "HoTen", conn);
                Clear();
            }    
        }

        void Sua()
        {
            ti.RemoveSign4VietnameseString(txtTenDangNhap.Text);
            ti.RemoveSign4VietnameseString(txtMatKhau.Text);

            bool haveError = CheckError();
            bool isDuplicate = CheckDuplicate();

            if (isDuplicate && txtTenDangNhap.Text == tenTK)
            {
                isDuplicate = false;
                erpPhanQuyen.SetError(txtTenDangNhap, "");
            }

            if(haveError ==false && isDuplicate==false)
            {
                string Update_TaiKhoan = "exec SP_TaiKhoan_Sua '" + maTK + "', '" + txtTenDangNhap.Text + "', '" + txtMatKhau.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(Update_TaiKhoan, conn);

                MessageBox.Show("Sửa thành công!");

                TruyenDataGrid_TaiKhoan();

                TatThaoTac();

                ButtonPermisson();
            }    
        }

        void Clear()
        {
            ti.ClearTextBoxes(this.Controls);
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if(ThemClicked)
            {
                Them();
                
            }    
            else if(SuaClicked)
            {
                Sua();
            }    
        }

        private void ibtnHuy_Click(object sender, EventArgs e)
        {
            TatThaoTac();
            ButtonPermisson();
            erpPhanQuyen.SetError(txtTenDangNhap, "");
            erpPhanQuyen.SetError(txtMatKhau, "");
        }



        private void ibtnSua_Click(object sender, EventArgs e)
        {
            if (maNV_CoTK != "")
            {
                TruyenDuLieu();

                BatThaoTac();
                SuaClicked = true;
                ThemClicked = false;
                cbxNhanVien.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chọn thông tin để sửa!");
            }    
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maTK = dgvTaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString(); 
                
                maNV_CoTK = dgvTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();


                if (ThemClicked == false && SuaClicked == false)
                {
                    string sql = "exec SP_HanhDong_MaTK '" + maTK + "'";
                    kndl.KetNoiDataGridView(sql, dgvQuyen, conn);
                }
            }
            catch (Exception)
            {
                maNV_CoTK = "";             
            }   
        }

        void TruyenDuLieu()
        {
            string sql = "exec SP_TaiKhoan_MaNV_LayThongTin '" + maNV_CoTK + "'";

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    cbxNhanVien.Items.Add(rd["HoTen"].ToString());
                    txtTenDangNhap.Text = rd["TenTK"].ToString();
                    tenTK = txtTenDangNhap.Text;
                    txtMatKhau.Text = rd["MatKhau"].ToString();
                   
                }
                cbxNhanVien.SelectedIndex = 0;
                cmd.Dispose();
            }
            catch (Exception ex)
            {             
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        void ReadOnlyCheckBox()
        {
            
            for (int i = 0; i < dgvQuyen.Rows.Count; i++)
            {
                if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Khôi phục và sao lưu")
                {
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                }
                else if(dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Đổi mật khẩu")
                {
                    dgvQuyen.Rows[i].Cells[2].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[4].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[6].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Quản lý nhân viên")
                {                    
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;                  
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Phân quyền")
                {                 
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Thông tin phòng khám")
                {
                    dgvQuyen.Rows[i].Cells[2].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[4].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[6].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Nhóm thủ thuật")
                {
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[6].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Thuốc - Mẫu thuốc")
                {
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                }
                else if(dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Đăng ký khám bệnh")
                {
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Danh mục đơn thuốc")
                {
                    dgvQuyen.Rows[i].Cells[2].ReadOnly = true;
                }
                else if(dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Danh sách lịch hẹn")
                {
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Phiếu thu")
                {
                    dgvQuyen.Rows[i].Cells[2].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[3].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[4].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Danh sách bệnh nhân khám bệnh")
                {
                    dgvQuyen.Rows[i].Cells[2].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[3].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[4].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Danh sách bệnh nhân nợ tiền")
                {
                    dgvQuyen.Rows[i].Cells[2].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[3].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[4].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Danh sách thu tiền khám bệnh")
                {
                    dgvQuyen.Rows[i].Cells[2].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[3].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[4].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[5].ReadOnly = true;
                }
                else if (dgvQuyen.Rows[i].Cells[0].Value.ToString() == "Báo cáo tổng thu")
                {
                    dgvQuyen.Rows[i].Cells[2].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[3].ReadOnly = true;
                    dgvQuyen.Rows[i].Cells[4].ReadOnly = true;
                }
            }
        }

        private void dgvQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {               
                ReadOnlyCheckBox();
                maHD = dgvQuyen.Rows[e.RowIndex].Cells[9].Value.ToString();            
            }
            catch (Exception)
            {

                
            }
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if(maNV_CoTK!="")
            {
                DialogResult dr = MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    string Delete_TaiKhoan = "exec SP_TaiKhoan_Xoa '" + maTK + "', '" + maNV_CoTK + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(Delete_TaiKhoan, conn);

                    MessageBox.Show("Xóa thành công!");

                    TruyenDataGrid_TaiKhoan();

                    dgvTaiKhoan.ClearSelection();

                    if (dgvTaiKhoan.Rows.Count > 0)
                    {
                        dgvTaiKhoan.Rows[0].Selected = false;
                    }

                    maNV_CoTK = "";
                }    
            }   
            else
            {
                MessageBox.Show("Chọn thông tin để xóa!");
            }    
        }

        private void dgvQuyen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQuyen.DataSource != null)
            {
                string Update_Quyen = "exec SP_HanhDong_Sua '" + maHD + "', '" + dgvQuyen.Rows[e.RowIndex].Cells[1].Value.ToString() + "', '" + dgvQuyen.Rows[e.RowIndex].Cells[2].Value.ToString() + "', '" + dgvQuyen.Rows[e.RowIndex].Cells[3].Value.ToString() + "', '" + dgvQuyen.Rows[e.RowIndex].Cells[4].Value.ToString() + "', '" + dgvQuyen.Rows[e.RowIndex].Cells[5].Value.ToString() + "', '" + dgvQuyen.Rows[e.RowIndex].Cells[6].Value.ToString() + "'";
                kndl.ThucThiDuLieu_KhongTraVe(Update_Quyen, conn);
            }
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "exec SP_TaiKhoan_TimKiem '%" + txtTaiKhoan.Text + "%'";

            kndl.KetNoiDataGridView(sql, dgvTaiKhoan, conn);

            dgvTaiKhoan.ClearSelection();

            if(dgvTaiKhoan.Rows.Count >0)
            {
                dgvTaiKhoan.Rows[0].Selected = false;
            }

            maNV_CoTK = "";
        }
    }
}
