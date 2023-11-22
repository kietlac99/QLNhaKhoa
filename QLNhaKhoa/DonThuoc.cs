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
    public partial class fDonThuoc : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        string maBN = fDangKiKhamBenh.maBN;
        string maMDT = "";
        string maT_TheoMau = "";
        string maT = "";
        string maDT = fKhamBenhDieuTri.maDT;
        string maDThuoc = "";
        string maCTDThuoc = "";
        string maLD = "";
        string maLoiDan = "";
        string id_per = fDangNhap.ID_Per;

        int newPrescription = 1;

        bool LoiDanLoaded = false;

        public fDonThuoc()
        {
            InitializeComponent();

            LoadThongTin();

            TruyenTTBenhNhan();

            TruyenTSBenh();

            TruyenDataLoiDan();

            LoiDanLoaded = true;

            LoadMauDonThuoc();

            LoadThuoc();

            ButtonPermission();
        }

        void ButtonPermission()
        {
            if (id_per == "5")
            {
                string canPrint = fDangNhap.arrIn[7];

                ti.QuyenThaoTac(canPrint, ibtnIn);
            }
        }

        void LoadThongTin()
        {
            ckbxChayMau.Enabled = false;
            ckbxDaDay.Enabled = false;
            ckbxDiUng.Enabled = false;
            ckbxHuyetAp.Enabled = false;
            ckbxPhoi.Enabled = false;
            ckbxThaiSan.Enabled = false;
            ckbxThapKhop.Enabled = false;
            ckbxTieuDuong.Enabled = false;
            ckbxTimMach.Enabled = false;
            ckbxTruyenNhiem.Enabled = false;

            dtpNgayKe.Enabled = false;
            dtpNgayKe.Format = DateTimePickerFormat.Custom;
            dtpNgayKe.Value = DateTime.Today;
            dtpNgayKe.CustomFormat = "dd-MM-yyyy";
            

            kndl.VaoComboBox_2("select * from vw_NhanVien_TenNhanVien", cbxNguoiKe, "MaNV", "HoTen", "----(Chọn bác sỹ)----", conn);

            cbxNguoiKe.SelectedIndex = 0;
        }

        void TruyenTTBenhNhan()
        {
            if(fDanhSachDonThuoc.DSDonThuoc)
            {
                maBN = fDanhSachDonThuoc.maBN;
                maDT = fDanhSachDonThuoc.maDT;
                maDThuoc = fDanhSachDonThuoc.maDThuoc;

                kndl.KetNoiDataGridView("exec SP_ChiTietDonThuoc_Chon '" + maDThuoc + "'", dgvCTDonThuoc, conn);

                string query = "exec SP_ChiTietLoiDan_LayTT_Theo_MaDThuoc '" + maDThuoc + "'";

                try
                {
                    kndl.KiemTraKetNoi(conn);

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader rd = cmd.ExecuteReader();

                    while(rd.Read())
                    {
                        if (!maLoiDan.Contains(rd["MaLD"].ToString()))
                        {
                            maLoiDan += rd["MaLD"].ToString() + ",";
                        }

                        txtLoiDan.Text += rd["LoiDan"].ToString() + "\r\n";
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

                query = "exec SP_DonThuoc_Lay_NguoiKe '" + maDThuoc + "'";

                try
                {
                    kndl.KiemTraKetNoi(conn);

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cbxNguoiKe.SelectedValue = cmd.ExecuteScalar().ToString();

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

            string sql = "exec TTBenhNhan_DonThuoc '" + maBN + "'";

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (!string.IsNullOrEmpty(rd["NgaySinh"].ToString()))
                    {
                        DateTime ngaySinh = DateTime.Parse(rd["NgaySinh"].ToString());
                        txtNgaySinh.Text = ngaySinh.ToString("dd-MM-yyyy");
                    }
                    else
                    {
                        txtNgaySinh.Text = "";
                    }    

                    txtMaHS.Text = rd["MaBN"].ToString();
                    txtHoTen.Text = rd["HoTen"].ToString();
                    txtGioiTinh.Text = rd["GioiTinh"].ToString();                   
                    
                    txtDienThoai.Text = rd["SoDT"].ToString();
                    txtDiaChi.Text = rd["DiaChi"].ToString();
                    txtGhiChu.Text = rd["GhiChu"].ToString();
                    this.Text = "KÊ ĐƠN THUỐC CHO BỆNH NHÂN: " + txtHoTen.Text.ToUpper();
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

        void TruyenTSBenh()
        {
            string[] arrMaTSB = new string[10];

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

        void TruyenDataLoiDan()
        {
            kndl.KetNoiDataGridView("select * from vw_LoiDanBenhNhan", dgvDanhSachLoiDan, conn);
        }

        void LoadMauDonThuoc()
        {
            kndl.KetNoiDataGridView("select * from vw_MauDonThuoc", dgvMauDT, conn);
        }

        void LoadThuoc()
        {
            kndl.KetNoiDataGridView("select * from DonThuoc_ThongTinThuoc", dgvDanhMucThuoc, conn);
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

        private void txtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvMauDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maMDT = dgvMauDT.Rows[e.RowIndex].Cells["clMaMDT"].Value.ToString();

                kndl.KetNoiDataGridView("exec SP_ChiTietMDT_Theo_MaMDT '" + maMDT + "'", dgvChiTietMDT, conn);

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
                maT_TheoMau = dgvChiTietMDT.Rows[e.RowIndex].Cells["clMaThuoc"].Value.ToString();
            }
            catch (Exception)
            {
                maT_TheoMau = "";
            }
        }

        private void dgvDanhMucThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maT = dgvDanhMucThuoc.Rows[e.RowIndex].Cells["clMaT"].Value.ToString();
            }
            catch (Exception)
            {
                maT = "";
            }
        }

        private void dgvChiTietMDT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NhapDonThuoc(maT_TheoMau);
        }

        private void NhapDonThuoc(string maThuoc)
        {
            if (maThuoc != "")
            {
                if (cbxNguoiKe.SelectedIndex == 0)
                {
                    MessageBox.Show("Chọn người kê đơn thuốc!");
                    cbxNguoiKe.Focus();
                }
                else
                {
                    string query = "exec SP_DonThuoc_Them '" + maDT + "', '" + cbxNguoiKe.SelectedValue + "', '" + dtpNgayKe.Value.Date.ToString() + "', '" + newPrescription + "', '" + maThuoc + "'";

                    if(fDanhSachDonThuoc.DSDonThuoc)
                    {
                        query = "exec SP_DonThuoc_Sua '" + maDThuoc + "', '" + cbxNguoiKe.SelectedValue + "', '" + dtpNgayKe.Value.Date.ToString() + "', '" + maThuoc + "'";
                    }    

                    newPrescription = 0;

                    kndl.ThucThiDuLieu_KhongTraVe(query, conn);

                    query = "exec SP_ChiTietDonThuoc_Moi";

                    if(fDanhSachDonThuoc.DSDonThuoc)
                    {
                        query = "exec SP_ChiTietDonThuoc_Chon '" + maDThuoc + "'";
                    }    

                    kndl.KetNoiDataGridView(query, dgvCTDonThuoc, conn);

                }
            }
        }

        private void dgvDanhMucThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NhapDonThuoc(maT);
        }

        private void dgvCTDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maCTDThuoc = dgvCTDonThuoc.Rows[e.RowIndex].Cells["clMaCTDThuoc"].Value.ToString();

                if (!fDanhSachDonThuoc.DSDonThuoc)
                {
                    maDThuoc = dgvCTDonThuoc.Rows[e.RowIndex].Cells["clMaDThuoc"].Value.ToString();
                }
            }
            catch (Exception)
            {
                maCTDThuoc = "";
            }
        }

        private void dgvCTDonThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(fDanhSachDonThuoc.DSDonThuoc)
            {
                string query = "exec SP_ChiTietDonThuoc_Xoa '" + maCTDThuoc + "'";

                kndl.ThucThiDuLieu_KhongTraVe(query, conn);

                kndl.KetNoiDataGridView("exec SP_ChiTietDonThuoc_DaXoa '" + maDThuoc + "'", dgvCTDonThuoc, conn);
            }    
            else if(maCTDThuoc != "")
            {
                string query = "exec SP_ChiTietDonThuoc_Delete '" + maCTDThuoc + "', '" + maDThuoc + "'";

                kndl.ThucThiDuLieu_KhongTraVe(query, conn);

                kndl.KetNoiDataGridView("exec SP_ChiTietDonThuoc_DaXoa '" + maDThuoc + "'", dgvCTDonThuoc, conn);

                if (dgvCTDonThuoc.Rows.Count == 0)
                {
                    newPrescription = 1;

                    ClearLoiDan();
                }    
            }    
        }

        private void dgvDanhSachLoiDan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (LoiDanLoaded)
            {
                string query = "exec SP_LoiDanBenhNhan_Them_Sua '" + maLD + "', N'" + dgvDanhSachLoiDan.Rows[e.RowIndex].Cells["clLoiDan"].Value.ToString() + "'";

                kndl.ThucThiDuLieu_KhongTraVe(query, conn);
            }
        }

        private void dgvDanhSachLoiDan_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this.dgvDanhSachLoiDan, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }    
        }

        private void dgvDanhSachLoiDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maLD = dgvDanhSachLoiDan.Rows[e.RowIndex].Cells["clMaLD"].Value.ToString();
            }
            catch (Exception)
            {
                maLD = "0";
            }
        }

        private void xoaLoiDanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(maLD != "0")
            {
                string query = "exec SP_LoiDanBenhNhan_Xoa '" + maLD + "'";

                kndl.ThucThiDuLieu_KhongTraVe(query, conn);

                TruyenDataLoiDan();
            }    
        }

        private void dgvDanhSachLoiDan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(fDanhSachDonThuoc.DSDonThuoc)
            {
                if(dgvCTDonThuoc.Rows.Count > 0)
                {
                    if (maLD != "0")
                    {
                        if (!maLoiDan.Contains(maLD))
                        {
                            maLoiDan += maLD + ",";

                            txtLoiDan.Text += dgvDanhSachLoiDan.Rows[e.RowIndex].Cells["clLoiDan"].Value.ToString() + "\r\n";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kê thuốc trước khi dặn!");
                }
            }    
            else if (newPrescription != 1)
            {
                if (maLD != "0")
                {
                    if (!maLoiDan.Contains(maLD))
                    {
                        maLoiDan += maLD + ",";

                        txtLoiDan.Text += dgvDanhSachLoiDan.Rows[e.RowIndex].Cells["clLoiDan"].Value.ToString() + "\r\n";
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kê thuốc trước khi dặn!");
            }    
        }

        void RemoveAt<T>(ref T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                arr[a] = arr[a + 1];
            }
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);
        }

        private void fDonThuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            LuuDonThuoc();

            fDanhSachDonThuoc.DSDonThuoc = false;
        }

        private void LuuDonThuoc()
        {
            string query = "";

            if (maLoiDan != "")
            {
                var arrMaLD = maLoiDan.Split(',');

                RemoveAt(ref arrMaLD, arrMaLD.Length - 1);

                for (int i = 0; i < arrMaLD.Length; i++)
                {
                    query = "exec ChiTietLoiDan_Sua '" + arrMaLD[i] + "'";

                    if (fDanhSachDonThuoc.DSDonThuoc)
                    {
                        query = "exec SP_ChiTietLoiDan_Sua '" + arrMaLD[i] + "', '" + maDThuoc + "'";
                    }

                    kndl.ThucThiDuLieu_KhongTraVe(query, conn);
                }               
            }
          

            if (dgvCTDonThuoc.Rows.Count > 0 && cbxNguoiKe.SelectedIndex != 0)
            {
                int DSDonThuoc = 1;
                if(!fDanhSachDonThuoc.DSDonThuoc)
                {
                    maDThuoc = "";
                    DSDonThuoc = 0;
                }

                query = "exec SP_DonThuoc_Sua_NguoiKe '" + cbxNguoiKe.SelectedValue + "', '" + maDThuoc + "', '" + DSDonThuoc + "'";             

                kndl.ThucThiDuLieu_KhongTraVe(query, conn);
            }
        }

        private void txtLoiDan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            ClearLoiDan();

            if (fDanhSachDonThuoc.DSDonThuoc)
            {
                string query = "exec SP_ChiTietLoiDan_Xoa_Theo_DThuoc '" + maDThuoc + "'";

                kndl.ThucThiDuLieu_KhongTraVe(query, conn);
            }
        }

        private void ClearLoiDan()
        {
            txtLoiDan.Clear();

            maLoiDan = "";
        }

        private void ibtnIn_Click(object sender, EventArgs e)
        {
            if(cbxNguoiKe.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn người kê đơn thuốc!");
            }    
            else if(dgvCTDonThuoc.Rows.Count < 1)
            {
                MessageBox.Show("Kê đơn thuốc trước khi in!");
            }    
            else
            {
                if (fDanhSachDonThuoc.DSDonThuoc)
                {
                    using (fInDonThuoc_2 form = new fInDonThuoc_2())
                    {
                        LuuDonThuoc();
                        form.ShowDialog();
                    }
                }
                else
                {
                    using (fInDonThuoc_1 form = new fInDonThuoc_1())
                    {
                        LuuDonThuoc();
                        form.ShowDialog();
                    }
                }
            }    
        }
    }
}
