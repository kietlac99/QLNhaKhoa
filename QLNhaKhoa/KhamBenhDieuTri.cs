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
    public partial class fKhamBenhDieuTri : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        string maBN = fDangKiKhamBenh.maBN;

        public static string maCTDT = "";
        public static string maDT = "";

        bool xoaCTDT = false;
        bool xoaDT = false;

        string[] arrMaTSB = new string[10];

        Form activeForm = null;

        public fKhamBenhDieuTri()
        {
            InitializeComponent();

            LoadThongTin();

            TruyenTTBenhNhan();

            TruyenTSB();

            LoadDataDieuTri();

            dgvDieuTri_CellClick(dgvDieuTri, new DataGridViewCellEventArgs(1, 0));
        }

     
        public void LoadDataDieuTri()
        {
            kndl.KetNoiDataGridView("exec SP_DieuTri '" + maBN + "'", dgvDieuTri, conn);
        }

        void SetTextBoxesValue(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.Text = "0";
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

                while (rd.Read())
                {
                    arrMaTSB[i] = rd["maTSB"].ToString();
                    i++;
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

            for (int j = 0; j < 10; j++)
            {
                if (arrMaTSB[j] == "1")
                {
                    ckbxChayMau.Checked = true;
                }
                else if (arrMaTSB[j] == "2")
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

        void LoadTongTien()
        {
            try
            {
                if (dgvChiTietDT.Rows.Count > 0)
                {
                    double tong = 0;
                    int dem = dgvChiTietDT.Rows.Count;

                    for (int i = 0; i < dem; i++)
                    {
                        tong += double.Parse(dgvChiTietDT.Rows[i].Cells["clPhaiThanhToan"].Value.ToString());
                    }

                    txtTongTien.Text = tong.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        void LoadTongTienKM()
        {
            try
            {
                if(dgvChiTietDT.Rows.Count > 0)
                {
                    double tong = 0;
                    int dem = dgvChiTietDT.Rows.Count;

                    for (int i = 0; i < dem; i++)
                    {
                        tong += double.Parse(dgvChiTietDT.Rows[i].Cells["clThanhTien"].Value.ToString()) * float.Parse(dgvChiTietDT.Rows[i].Cells["clGiamGia"].Value.ToString())/100f;
                    }

                    txtTongTienKM.Text = tong.ToString();
                }    
            }
            catch (Exception)
            {

            }
        }

        void LoadThongTin()
        {
            dtpNgayKham.Value = DateTime.Today;
            dtpNgayKham.Format = DateTimePickerFormat.Custom;
            dtpNgayKham.CustomFormat = "dd-MM-yyyy";

            SetTextBoxesValue(txtTongTien);
            SetTextBoxesValue(txtTongTienKM);
            SetTextBoxesValue(txtDaThanhToan);
            SetTextBoxesValue(txtConNo);

            txtDaThanhToan.MaxLength = 13;
        }

        void TruyenTTBenhNhan()
        {
            string sql = "exec SP_BenhNhan '" + maBN + "'";

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while(rd.Read())
                {                    
                    if (!string.IsNullOrEmpty(rd["NgaySinh"].ToString()))
                    {
                        DateTime ngaySinh;
                        ngaySinh = DateTime.Parse(rd["NgaySinh"].ToString());
                        txtNgaySinh.Text = ngaySinh.ToString("dd-MM-yyyy");
                    }
                    else
                    {
                        txtNgaySinh.Text = "";
                    }    

                    txtMaHS.Text = rd["MaBN"].ToString();
                    txtHoTen.Text = rd["HoTen"].ToString();
                    txtGioiTinh.Text = rd["GioiTinh"].ToString();
                    
                    txtTuoi.Text = rd["Tuoi"].ToString();
                    txtDienThoai.Text = rd["SoDT"].ToString();
                    txtDiaChi.Text = rd["DiaChi"].ToString();
                    txtLyDoKham.Text = rd["LyDoKham"].ToString();
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

        private void txtMaHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
       
        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNgaySinh_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtLyDoKham_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTongTienKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtConNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            PhanNghin(txtTongTien);


            try
            {
                double tongTien = double.Parse(txtTongTien.Text);

                double daThanhToan = double.Parse(txtDaThanhToan.Text);

                double conNo = tongTien - daThanhToan;

                txtConNo.Text = conNo.ToString();
            }
            catch (Exception)
            {

            }
           
        }

        private void txtDaThanhToan_TextChanged(object sender, EventArgs e)
        {
            PhanNghin(txtDaThanhToan);

            double tongTien = double.Parse(txtTongTien.Text);

            double daThanhToan = double.Parse(txtDaThanhToan.Text);

            double conNo = tongTien - daThanhToan;

            txtConNo.Text = conNo.ToString();
        }

        private void PhanNghin(TextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                try
                {
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

                    double valueBefore = double.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);

                    txt.Text = String.Format(culture, "{0:N0}", valueBefore);

                    txt.Select(txt.Text.Length, 0);
                }
                catch (Exception)
                {

                }
                
            }
            else 
            {
                txt.Text = "0";
            }

            
        }

        private void txtTongTienKM_TextChanged(object sender, EventArgs e)
        {
            PhanNghin(txtTongTienKM);
        }

        private void txtConNo_TextChanged(object sender, EventArgs e)
        {
            PhanNghin(txtConNo);
        }

        private void txtDaThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;                  
        }

        private void ibtnKhamBenh_Click(object sender, EventArgs e)
        {
            using (fChonThuThuat form = new fChonThuThuat(this))
            {
                try
                {
                    form.ShowDialog();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                
            }    
        }

        public void dgvDieuTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maDT = dgvDieuTri.Rows[e.RowIndex].Cells["clMaDT"].Value.ToString();

                kndl.KetNoiDataGridView("exec SP_ChiTietDieuTri '" + maDT + "'", dgvChiTietDT, conn);

                xoaDT = true;
                xoaCTDT = false;
            }
            catch (Exception)
            {
                maDT = "";
            }

            LoadTongTien();

            LoadTongTienKM();

            if (maDT != "")
            {
                string sql = "exec SP_DieuTri_TTThanhToan '" + maDT + "'";
                try
                {
                    kndl.KiemTraKetNoi(conn);

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        txtDaThanhToan.Text = rd["DaThanhToan"].ToString();
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

                if(txtDaThanhToan.Text == "0")
                {
                    txtConNo.Text = txtTongTien.Text;
                }    
            }
        }

        private void dgvChiTietDT_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(dgvChiTietDT.Rows[e.RowIndex].Cells["clGiamGia"].Value.ToString()))
                {
                    dgvChiTietDT.Rows[e.RowIndex].Cells["clGiamGia"].Value = "0";
                }
            }
            catch (Exception)
            {

            }

            try
            {
                if (maCTDT != "")
                {
                    string chuanDoanChiTiet = dgvChiTietDT.Rows[e.RowIndex].Cells["clChuanDoanChiTiet"].Value.ToString();
                    string noiDungThuThuat = dgvChiTietDT.Rows[e.RowIndex].Cells["clNoiDungThuThuat"].Value.ToString();
                    string giamGia = dgvChiTietDT.Rows[e.RowIndex].Cells["clGiamGia"].Value.ToString();
                    string lyDoGiamGia = dgvChiTietDT.Rows[e.RowIndex].Cells["clLyDoGiamGia"].Value.ToString();
                    string soLuong = dgvChiTietDT.Rows[e.RowIndex].Cells["clSoLuong"].Value.ToString();

                    string sql = "exec SP_ChiTietDieuTri_Sua '" + maCTDT + "', '" + chuanDoanChiTiet + "', '" + noiDungThuThuat + "', '" + soLuong + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                    kndl.KetNoiDataGridView("exec SP_ChiTietDieuTri '" + maDT + "'", dgvChiTietDT, conn);
                }
            }
            catch (Exception)
            {

            }

            LoadTongTien();

            LoadTongTienKM();
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            string sql = "exec SP_ChiTietDieuTri_Xoa '" + maCTDT + "'";
            if (xoaCTDT)
            {
                if(maCTDT != "")
                {
                    if(MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                        kndl.KetNoiDataGridView("exec SP_ChiTietDieuTri '" + maDT + "'", dgvChiTietDT, conn);

                        MessageBox.Show("Xóa thành công!");

                        dgvChiTietDT.ClearSelection();
                        if (dgvChiTietDT.Rows.Count > 0)
                        {
                            dgvChiTietDT.Rows[0].Selected = false;
                        }

                        maCTDT = "";
                    }                                        
                }    
            }   
            else if(xoaDT)
            {
                if(maDT != "")
                {
                    if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sql = "exec SP_DieuTri_Xoa '" + maDT + "'";

                        kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                        LoadDataDieuTri();

                        kndl.KetNoiDataGridView("exec SP_ChiTietDieuTri '" + maDT + "'", dgvChiTietDT, conn);

                        MessageBox.Show("Xóa thành công!");

                        dgvDieuTri.ClearSelection();
                        if (dgvDieuTri.Rows.Count > 0)
                        {
                            dgvDieuTri.Rows[0].Selected = false;
                        }

                        maDT = "";
                    }
                }    
            }    
        }

        private void dgvChiTietDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                maCTDT = dgvChiTietDT.Rows[e.RowIndex].Cells["clMaCTDT"].Value.ToString();

                xoaCTDT = true;
                xoaDT = false;
            }
            catch (Exception)
            {
                maCTDT = "";
            }
        }

        private void AllowNumberOnly(Object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void dgvChiTietDT_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dgvChiTietDT.CurrentCell.ColumnIndex == 11)
            {
                e.Control.KeyPress -= AllowNumberOnly;
                e.Control.KeyPress += AllowNumberOnly;
            }    
        }

        private void dgvChiTietDT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvChiTietDT.Rows[e.RowIndex].Cells["clRang"].Selected)
                {
                    ti.OpenForm_2(ref this.activeForm, new fSoDoHamRang(this));
                }
                else if(dgvChiTietDT.Rows[e.RowIndex].Cells["clBacSyTroThu"].Selected)
                {
                    ti.OpenForm_2(ref this.activeForm, new fBacSiThucHien(this));
                }    
            }
            catch (Exception)
            {

            }          
        }

        private void ibtnThanhToan_Click(object sender, EventArgs e)
        {
            if(maDT != "")
            {
                ti.OpenForm_2(ref this.activeForm, new fPhieuThu(this));
            }    
        }

        private void ibtnDonThuoc_Click(object sender, EventArgs e)
        {
            if(maDT != "")
            {
                ti.OpenForm_2(ref this.activeForm, new fDonThuoc());
            }    
        }

        private void ibtnLichHen_Click(object sender, EventArgs e)
        {
            ti.OpenForm_2(ref this.activeForm, new fLichHen());
        }

        private void ibtnInBenhAn_Click(object sender, EventArgs e)
        {
            if (maDT != "")
            {
                ti.OpenForm_2(ref this.activeForm, new fIn_PhieuDieuTri());
            }
        }
    }
}
