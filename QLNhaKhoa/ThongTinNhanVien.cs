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
    public partial class fTTNhanVien : Form
    {
        KiemTraLoi ktl = new KiemTraLoi();

        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        fQuanLyNhanVien fqlnv;

        string ngaySinh = "";
        public fTTNhanVien(fQuanLyNhanVien fql)
        {
            InitializeComponent();
            SetTextLength();
            this.fqlnv = fql;
        }

        private void SetTextLength()
        {
            txtHo.MaxLength = 100;
            txtTen.MaxLength = 100;
            txtTenDem.MaxLength = 100;
            txtCCCD.MaxLength = 12;
            txtDiaChi.MaxLength = 300;
            txtViTri.MaxLength = 200;
            txtCongViec.MaxLength = 300;
            txtSoDT.MaxLength = 10;
        }

        string maN = fQuanLyNhanVien.maN;
        string maNV = fQuanLyNhanVien.maNV;
        string CCCD = "";
        string SoDT = "";
      
        void TruyenDuLieu()
        {
            string sql = "exec SP_Nguoi_NhanVien '" + maN + "'";

            if (fQuanLyNhanVien.btnSua_active)
            {
                try
                {
                    kndl.KiemTraKetNoi(conn);
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        txtHo.Text = rd["Ho"].ToString();
                        txtTenDem.Text = rd["TenDem"].ToString();
                        txtTen.Text = rd["Ten"].ToString();                       
                        dtpNgaySinh.Value = DateTime.Parse(rd["NgaySinh"].ToString());
                        ngaySinh = dtpNgaySinh.Value.ToString();
                        cbxGioiTinh.Text = rd["GioiTinh"].ToString();
                        txtCCCD.Text = rd["CCCD"].ToString();
                        CCCD = txtCCCD.Text;
                        txtSoDT.Text = rd["SoDT"].ToString();
                        SoDT = txtSoDT.Text;
                        txtDiaChi.Text = rd["DiaChi"].ToString();
                        txtViTri.Text = rd["Vitri"].ToString();
                        cbxVaiTro.Text = rd["TenVT"].ToString();
                        txtCongViec.Text = rd["CongViec"].ToString();
                        txtGhiChu.Text = rd["GhiChu"].ToString();
                        txtMucLuong.Text = rd["MucLuong"].ToString();
                    }
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
        }

        private void fQLNhanVien_Load(object sender, EventArgs e)
        {

            
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.MaxDate = DateTime.Today;
            dtpNgaySinh.CustomFormat = " ";
            ngaySinh = "";
           
            cbxGioiTinh.Items.Add("Nam");
            cbxGioiTinh.Items.Add("Nữ");

            kndl.VaoComboBox("Select * from vw_VaiTro", cbxVaiTro, "MaVT", "TenVT", conn);
            TruyenDuLieu();

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {          
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            ngaySinh = dtpNgaySinh.Value.Date.ToString();  
            
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        void Clear()
        {
            ti.ClearTextBoxes(this.Controls);
            dtpNgaySinh.CustomFormat = " ";
            ngaySinh = "";
            cbxGioiTinh.SelectedIndex = 0;
            cbxVaiTro.SelectedIndex = 0;
        }


        

        bool CheckDuplicate()
        {
            string sqlKiemTraTrung_CCCD = "exec SP_Nguoi_CCCD_Dem '" + txtCCCD.Text + "'";
            string sqlKiemTraTrung_SoDT = "exec SP_Nguoi_SoDT_Dem '" + txtSoDT.Text + "'";
            bool isDuplicate = false;
            ktl.TrungLap(sqlKiemTraTrung_CCCD, 12, "CCCD đã được sử dụng!", ref isDuplicate, erpTTNhanVien, txtCCCD, conn);
            ktl.TrungLap(sqlKiemTraTrung_SoDT, 10, "Số điện thoại đã được sử dụng!", ref isDuplicate, erpTTNhanVien, txtSoDT, conn);
            return isDuplicate;
        }

        bool CheckError()
        {                      
            bool haveError = false;          
          
            ktl.Rong("Vui lòng nhập tên!", ref haveError, erpTTNhanVien, txtTen);     
            ktl.Rong("Vui lòng nhập số CCCD!", ref haveError, erpTTNhanVien, txtCCCD);
     
            ktl.DoDai("CCCD không khả dụng!", 12, ref haveError, erpTTNhanVien, txtCCCD);                        
            ktl.DoDai("Số điện thoại không khả dụng!", 10, ref haveError, erpTTNhanVien, txtSoDT);

            if (txtSoDT.TextLength < 1)
            {
                erpTTNhanVien.SetError(txtSoDT, "");
            }
                
            ti.TrimTextBoxes(this.Controls);

            return haveError;
        }
       
        void Them()
        {
            bool haveError = CheckError();
            bool isDuplicate = CheckDuplicate();
             
            if (haveError == false && isDuplicate == false)
            {
                string Insert_Nguoi = "exec SP_Nguoi_Them N'" + txtHo.Text + "', N'" + txtTenDem.Text + "', N'" + txtTen.Text + "', '" + ngaySinh + "', N'" + cbxGioiTinh.Text + "', '" + txtCCCD.Text + "', '" + txtSoDT.Text + "', N'" + txtDiaChi.Text + "'";
                string Insert_NhanVien = "exec SP_NhanVien_Them '" + cbxVaiTro.SelectedValue + "', '" + txtCCCD.Text + "', N'" + txtCongViec.Text + "', N'" + txtGhiChu.Text + "', '" + txtMucLuong.Text + "', N'" + txtViTri.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(Insert_Nguoi, conn);
                kndl.ThucThiDuLieu_KhongTraVe(Insert_NhanVien, conn);

                fqlnv.TruyenDataGrid();
                MessageBox.Show("Thêm thành công!");

                Clear();              
            }
        }
              
        void Sua()
        {
            bool haveError = CheckError();
            bool isDuplicate_CCCD = false;
            bool isDuplicate_SoDT = false;

            string sqlKiemTraTrung_CCCD = "exec SP_Nguoi_CCCD_Dem '" + txtCCCD.Text + "'";
            string sqlKiemTraTrung_SoDT = "exec SP_Nguoi_SoDT_Dem '" + txtSoDT.Text + "'";

            ktl.TrungLap(sqlKiemTraTrung_CCCD, 12, "CCCD đã được sử dụng!", ref isDuplicate_CCCD, erpTTNhanVien, txtCCCD, conn);
            ktl.TrungLap(sqlKiemTraTrung_SoDT, 10, "Số điện thoại đã được sử dụng!", ref isDuplicate_SoDT, erpTTNhanVien, txtSoDT, conn);

            if (isDuplicate_CCCD && txtCCCD.Text == CCCD)
            {
                isDuplicate_CCCD = false;
                erpTTNhanVien.SetError(txtCCCD, "");
            }

            if (isDuplicate_SoDT && txtSoDT.Text == SoDT)
            {
                isDuplicate_SoDT = false;
                erpTTNhanVien.SetError(txtSoDT, "");
            }


            if (haveError == false && isDuplicate_CCCD == false && isDuplicate_SoDT == false)
            {
                string Update_Nguoi = "exec SP_Nguoi_Sua '" + maN + "', N'" + txtHo.Text + "', N'" + txtTenDem.Text + "', N'" + txtTen.Text + "', '" + ngaySinh + "', N'" + cbxGioiTinh.Text + "', '" + txtCCCD.Text + "', '" + txtSoDT.Text + "', N'" + txtDiaChi.Text + "'";
                string Update_NhanVien = "exec SP_NhanVien_Sua '" + maNV + "', '" + cbxVaiTro.SelectedValue + "', N'" + txtCongViec.Text + "', N'" + txtGhiChu.Text + "', '" + txtMucLuong.Text + "', N'" + txtViTri.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(Update_Nguoi, conn);
                kndl.ThucThiDuLieu_KhongTraVe(Update_NhanVien, conn);

                fqlnv.TruyenDataGrid();
                MessageBox.Show("Lưu thành công!");
                TruyenDuLieu();
            }    
        }

        private void ibtnLuu_Them_Click(object sender, EventArgs e)
        {
            if (fQuanLyNhanVien.btnThem_active)
            {
                Them();
                
            }
            else if (fQuanLyNhanVien.btnSua_active)
            {
                
                Sua();
            }
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMucLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
      
    }
}
