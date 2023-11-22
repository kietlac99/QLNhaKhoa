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
    public partial class fBenhNhan : Form
    {
        SqlConnection conn = new SqlConnection(Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        KiemTraLoi ktl = new KiemTraLoi();

        TienIch ti = new TienIch();

        fDangKiKhamBenh fdkkb;

        string[] arrMaTSB = new string[10];

        string ngaySinh = "";
        string ngayNhap = "";
        string maBN = fDangKiKhamBenh.maBN;
        string maN = fDangKiKhamBenh.maN;
        string ho = "";
        string tendem = "";
        string ten = "";
        string sodt = "";

        public fBenhNhan(fDangKiKhamBenh fdkkb)
        {
            InitializeComponent();

            LoadThongTin();

            TruyenDuLieu();

            this.fdkkb = fdkkb;
        }

        void LoadThongTin()
        {
            
            txtHo.MaxLength = 100;
            txtTenDem.MaxLength = 100;
            txtTen.MaxLength = 100;
            txtSoDT.MaxLength = 10;
            txtDiaChi.MaxLength = 300;
            txtEmail.MaxLength = 320;
            txtLyDo.MaxLength = 300;
            txtGhiChu.MaxLength = 300;
            txtKhanCap.MaxLength = 1000;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.MaxDate = DateTime.Today;
            dtpNgaySinh.CustomFormat = " ";

            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Value = DateTime.Today;
            dtpNgayNhap.CustomFormat = "dd-MM-yyyy";

            ngaySinh = "";
            ngayNhap = dtpNgayNhap.Value.Date.ToString();

            cbxGioiTinh.Items.Add("Nam");
            cbxGioiTinh.Items.Add("Nữ");
            cbxGioiTinh.SelectedIndex = 0;
        }

        void TruyenTTBenhNhan()
        {
            string sql = "exec SP_BenhNhan_Theo_MaBN '" + maBN + "'";
            try
            {
                txtSoHoSo.Text = maBN;

                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    txtHo.Text = rd["Ho"].ToString();
                    txtTenDem.Text = rd["TenDem"].ToString();
                    txtTen.Text = rd["Ten"].ToString();
                    txtSoDT.Text = rd["SoDT"].ToString();
                    txtDiaChi.Text = rd["DiaChi"].ToString();
                    txtEmail.Text = rd["Email"].ToString();
                    txtLyDo.Text = rd["LyDoKham"].ToString();
                    txtGhiChu.Text = rd["GhiChu"].ToString();
                    txtKhanCap.Text = rd["KhanCap"].ToString();

                    cbxGioiTinh.Text = rd["GioiTinh"].ToString();

                    if (rd["NgaySinh"].ToString() != "")
                    {
                        dtpNgaySinh.Value = DateTime.Parse(rd["NgaySinh"].ToString());
                    }

                    dtpNgayNhap.Value = DateTime.Parse(rd["NgayNhap"].ToString());

                    ngaySinh = dtpNgaySinh.Value.Date.ToString();              
                }

                txtSoDT.Text = txtHo.Text.Replace(" ", String.Empty);

                ho = txtHo.Text;
                tendem = txtTenDem.Text;
                ten = txtTen.Text;
                sodt = txtSoDT.Text;               
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

        void TruyenSoHSCu()
        {
            txtHSCu.Text = "";
            string sql = "";

            if (fDangKiKhamBenh.them)
            {
                sql = "exec SP_BenhNhan_TimHSC N'" + txtHo.Text + "', N'" + txtTenDem.Text + "', N'" + txtTen.Text + "', '" + txtSoDT.Text + "'";
            }
            else if (fDangKiKhamBenh.sua)
            {
                sql = "exec SP_BenhNhan_TimHSC_2 N'" + txtHo.Text + "', N'" + txtTenDem.Text + "', N'" + txtTen.Text + "', '" + txtSoDT.Text + "'";
            }

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while(rd.Read())
                {
                    txtHSCu.Text += rd["MaBN"] + ", ";
                }                              
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

        void TruyenTSB()
        {
            string sql = "exec SP_ChiTietTienSuBenh_Theo_MaBN '" + maBN + "'";

            int i = 0;

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();
               
                while(rd.Read())
                {
                    arrMaTSB[i] = rd["maTSB"].ToString();
                    i++;
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            for(int j = 0; j<10; j++)
            {
                if(arrMaTSB[j] == "1")
                {
                    ckbxChayMau.Checked = true;
                }    
                else if(arrMaTSB[j] == "2")
                {
                    ckbxDiUng.Checked = true;
                }
                else if (arrMaTSB[j] == "3")
                {
                    ckbxThapKhop.Checked = true;
                }
                else if (arrMaTSB[j] == "4")
                {
                    ckbxHuyetAp.Checked = true;
                }
                else if (arrMaTSB[j] == "5")
                {
                    ckbxTimMach.Checked = true;
                }
                else if (arrMaTSB[j] == "6")
                {
                    ckbxTieuDuong.Checked = true;
                }
                else if (arrMaTSB[j] == "7")
                {
                    ckbxDaDay.Checked = true;
                }
                else if (arrMaTSB[j] == "8")
                {
                    ckbxPhoi.Checked = true;
                }
                else if (arrMaTSB[j] == "9")
                {
                    ckbxTruyenNhiem.Checked = true;
                }
                else if (arrMaTSB[j] == "10")
                {
                    ckbxThaiSan.Checked = true;
                }
            }    
        }

        void TruyenDuLieu()
        {
            if(fDangKiKhamBenh.sua)
            {
                TruyenTTBenhNhan();
                TruyenTSB();
                TruyenSoHSCu();
            }    
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            ngaySinh = dtpNgaySinh.Value.Date.ToString();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (fDangKiKhamBenh.them)
            {
                TruyenSoHSCu();
                if (txtHo.TextLength == 0 && txtTenDem.TextLength == 0 && txtTen.TextLength == 0 && txtSoDT.TextLength == 0)
                {
                    txtHSCu.Text = "";
                }
            }
        }       

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if(fDangKiKhamBenh.them)
            {
                Them();
            }    
            else if(fDangKiKhamBenh.sua)
            {
                Sua();
            }    
        }

        bool CheckError()
        {
            bool haveError = false;

            ktl.Rong("Không được để trống!", ref haveError, erpBenhNhan, txtTen);

            ktl.DoDai("Số điện thoại không khả dụng!", 10, ref haveError, erpBenhNhan, txtSoDT);

            ti.TrimTextBoxes(this.Controls);

            return haveError;
        }

        private void Sua()
        {
            bool haveError = CheckError();

            if(haveError == false)
            {
                string upNguoi = "exec SP_Nguoi_Sua '" + maN + "', N'" + txtHo.Text + "', N'" + txtTenDem.Text + "', N'" + txtTen.Text + "', '" + ngaySinh + "', N'" + cbxGioiTinh.Text + "', '', '" + txtSoDT.Text + "', N'" + txtDiaChi.Text + "'";
                string upBenhNhan = "";

                if (ho == txtHo.Text && tendem == txtTenDem.Text && ten == txtTen.Text && sodt == txtSoDT.Text)
                {
                    upBenhNhan = "exec SP_BenhNhan_Sua '', '', '', '', '" + maBN + "', N'" + txtEmail.Text + "', N'" + txtLyDo.Text + "', N'" + txtGhiChu.Text + "', N'" + txtKhanCap.Text + "'";
                }
                else
                {
                    upBenhNhan = "exec SP_BenhNhan_Sua N'" + txtHo.Text + "', N'" + txtTenDem.Text + "', N'" + txtTen.Text + "', '" + txtSoDT.Text + "', '" + maBN + "', N'" + txtEmail.Text + "', N'" + txtLyDo.Text + "', N'" + txtGhiChu.Text + "', N'" + txtKhanCap.Text + "'";
                }

                kndl.ThucThiDuLieu_KhongTraVe(upNguoi, conn);
                kndl.ThucThiDuLieu_KhongTraVe(upBenhNhan, conn);

                SuaChiTietTSB(1, ckbxChayMau);
                SuaChiTietTSB(2, ckbxDiUng);
                SuaChiTietTSB(3, ckbxThapKhop);
                SuaChiTietTSB(4, ckbxHuyetAp);
                SuaChiTietTSB(5, ckbxTimMach);
                SuaChiTietTSB(6, ckbxTieuDuong);
                SuaChiTietTSB(7, ckbxDaDay);
                SuaChiTietTSB(8, ckbxPhoi);
                SuaChiTietTSB(9, ckbxTruyenNhiem);
                SuaChiTietTSB(10, ckbxThaiSan);

                fdkkb.LoadDaTaGrid();

                ti.RowsColor("clNgayGio", fdkkb.tmBenhNhan, fdkkb.dgvBenhNhan);

                MessageBox.Show("Sửa thành công!");
            }    
        }

        void SuaChiTietTSB(int maTSB, CheckBox ckbx)
        {
            string sql = "";
            if (ckbx.Checked == true)
            {
                sql = "exec ChiTietTienSuBenh_Sua '" + maBN + "', '" + maTSB + "', '1'";               
            }
            else
            {
                sql = "exec ChiTietTienSuBenh_Sua '" + maBN + "', '" + maTSB + "', '0'";
            }
            kndl.ThucThiDuLieu_KhongTraVe(sql, conn);
        }

        private void Them()
        {
            bool haveError = CheckError();

            if (haveError == false)
            {
                string themNguoi = "exec SP_Nguoi_Them N'" + txtHo.Text + "', N'" + txtTenDem.Text + "', N'" + txtTen.Text + "', '" + ngaySinh + "', N'" + cbxGioiTinh.Text + "', '', '" + txtSoDT.Text + "', N'" + txtDiaChi.Text + "'";
                string themBenhNhan = "exec SP_BenhNhan_Them N'" + txtHo.Text + "', N'" + txtTenDem.Text + "', N'" + txtTen.Text + "', '" + txtSoDT.Text + "', N'" + txtEmail.Text + "', N'" + txtLyDo.Text + "', N'" + txtGhiChu.Text + "', N'" + txtKhanCap.Text + "', N'" + ngayNhap + "'";

                kndl.ThucThiDuLieu_KhongTraVe(themNguoi, conn);

                kndl.ThucThiDuLieu_KhongTraVe(themBenhNhan, conn);

                ThemChiTietTSB(1, ckbxChayMau);
                ThemChiTietTSB(2, ckbxDiUng);
                ThemChiTietTSB(3, ckbxThapKhop);
                ThemChiTietTSB(4, ckbxHuyetAp);
                ThemChiTietTSB(5, ckbxTimMach);
                ThemChiTietTSB(6, ckbxTieuDuong);
                ThemChiTietTSB(7, ckbxDaDay);
                ThemChiTietTSB(8, ckbxPhoi);
                ThemChiTietTSB(9, ckbxTruyenNhiem);
                ThemChiTietTSB(10, ckbxThaiSan);

                fdkkb.LoadDaTaGrid();

                ti.RowsColor("clNgayGio", fdkkb.tmBenhNhan, fdkkb.dgvBenhNhan);

                MessageBox.Show("Thêm thành công!");

                Clear();
            }   
        }

        void ThemChiTietTSB(int maTSB, CheckBox ckbx)
        {
            if (ckbx.Checked == true)
            {
                string sql = "exec SP_ChiTietTienSuBenh_Them '" + maTSB + "'";
                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);
            }    
        }

        void Clear()
        {
            ti.ClearTextBoxes(this.Controls);
            dtpNgaySinh.CustomFormat = " ";
            ngaySinh = "";
            cbxGioiTinh.SelectedIndex = 0;
        }
    }
}
