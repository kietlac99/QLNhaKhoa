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
    public partial class fPhieuThu : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        string maBN = fDangKiKhamBenh.maBN;
        string maTK = fDangNhap.ID_User;
        string maDT = fKhamBenhDieuTri.maDT;
        string maPT = fTTPhieuThu.maPT;
        string id_per = fDangNhap.ID_Per;
        string ngayThu = "";

        bool TTPhieuThu = fTTPhieuThu.TTPhieuThu;

        fKhamBenhDieuTri fkbdt;

        public fPhieuThu(fKhamBenhDieuTri fkbdt)
        {
            InitializeComponent();

            LoadThongTin();

            TruyenDuLieu();

            ButtonPermission();

            this.fkbdt = fkbdt;
        }

        void ButtonPermission()
        {
            if (id_per == "5")
            {
                string canPrint = fDangNhap.arrIn[9];

                ti.QuyenThaoTac(canPrint, ibtnLuuIn);
            }
        }

        void TruyenDuLieu()
        {
            if (!TTPhieuThu)
            {
                kndl.VaoComboBox("exec SP_PhieuThu_Theo_NhanVien '" + maTK + "'", cbxNhanVienThu, "MaNV", "TenTK", conn);

                string sql = "exec SP_PhieuThu_TTNguoiNop '" + maBN + "'";

                try
                {
                    kndl.KiemTraKetNoi(conn);

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        txtNguoiNop.Text = rd["HoTen"].ToString();

                        txtSoDT.Text = rd["SoDt"].ToString();

                        txtDiaChi.Text = rd["DiaChi"].ToString();
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
            else
            {
                string sql = "exec SP_PhieuThu_LoadThongTin '" + maPT + "'";
                string maThanhToan = "";

                try
                {
                    kndl.KiemTraKetNoi(conn);

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        txtNguoiNop.Text = rd["HoTen"].ToString();

                        txtSoDT.Text = rd["SoDt"].ToString();

                        txtDiaChi.Text = rd["DiaChi"].ToString();

                        dtpNgayThu.Value = DateTime.Parse(rd["NgayThu"].ToString());

                        string noiDung = rd["NoiDung"].ToString().Replace("<br />", "\r\n");
                        txtNoiDung.Text = noiDung;

                        txtSoTien.Text = rd["SoTien"].ToString();

                        maThanhToan = rd["maThanhToan"].ToString();

                        cbxNhanVienThu.Items.Add(rd["TenTK"].ToString());
                    }

                    cbxNhanVienThu.SelectedIndex = 0;

                    if (maThanhToan == "1")
                    {
                        rbThanhToanTM.Checked = true;
                    }
                    else if (maThanhToan == "2")
                    {
                        rbChuyenKhoan.Checked = true;
                    }
                    else
                    {
                        rbQuetThe.Checked = true;
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

        void LoadThongTin()
        {
            cbxNhanVienThu.Enabled = false;

            txtSoTien.MaxLength = 13;

            dtpNgayThu.Enabled = false;

            dtpNgayThu.Value = DateTime.Now;

            dtpNgayThu.Format = DateTimePickerFormat.Custom;

            dtpNgayThu.CustomFormat = "dd-MM-yyyy hh:mm";

            ngayThu = dtpNgayThu.Value.ToString();

            txtSoTien.Text = "0";

            if(TTPhieuThu)
            {
                rbChuyenKhoan.Enabled = false;
                rbQuetThe.Enabled = false;
                rbThanhToanTM.Enabled = false;

                ibtnLuu.Visible = false;
                ibtnLuuIn.Visible = false;
                ibtnIn.Visible = true;
            }    
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(TTPhieuThu)
            {
                e.Handled = true;
            }    
            else 
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }    
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            ti.PhanNghin(txtSoTien);
        }

        private void txtNguoiNop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            LuuPhieuThu();
        }

        private void LuuPhieuThu()
        {
            string noiDung = "";

            noiDung = txtNoiDung.Text.Replace("\r\n", "<br />");

            string maThanhToan = "";

            if (rbThanhToanTM.Checked)
            {
                maThanhToan = "1";
            }
            else if (rbChuyenKhoan.Checked)
            {
                maThanhToan = "2";
            }
            else if (rbQuetThe.Checked)
            {
                maThanhToan = "3";
            }

            if (maThanhToan != "" && txtSoTien.Text != "0")
            {
                string sql = "exec SP_PhieuThu_Them '" + maDT + "', '" + cbxNhanVienThu.SelectedValue + "', '" + maThanhToan + "', '" + ngayThu + "', N'" + noiDung + "', '" + txtSoTien.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                double daThanhToan = double.Parse(fkbdt.txtDaThanhToan.Text);

                double soTien = double.Parse(txtSoTien.Text);

                daThanhToan += soTien;

                fkbdt.txtDaThanhToan.Text = daThanhToan.ToString();

                string sql_2 = "exec SP_DieuTri_Update_DaThanhToan '" + maDT + "', '" + daThanhToan.ToString() + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql_2, conn);               

                MessageBox.Show("Lưu thành công!");

                Clear();
            }
            else if (maThanhToan == "" && txtSoTien.Text == "0")
            {
                MessageBox.Show("Chọn hình thức thanh toán và Nhập số tiền!");
            }
            else if (txtSoTien.Text == "0")
            {
                MessageBox.Show("Nhập số tiền!");
            }
            else
            {
                MessageBox.Show("Chọn hình thức thanh toán!");
            }
        }

        private void ibtnLuuIn_Click(object sender, EventArgs e)
        {
            string noiDung = "";

            noiDung = txtNoiDung.Text.Replace("\r\n", "<br />");

            string maThanhToan = "";

            if (rbThanhToanTM.Checked)
            {
                maThanhToan = "1";
            }
            else if (rbChuyenKhoan.Checked)
            {
                maThanhToan = "2";
            }
            else if (rbQuetThe.Checked)
            {
                maThanhToan = "3";
            }

            if (maThanhToan != "" && txtSoTien.Text != "0")
            {
                string sql = "exec SP_PhieuThu_Them '" + maDT + "', '" + cbxNhanVienThu.SelectedValue + "', '" + maThanhToan + "', '" + ngayThu + "', N'" + noiDung + "', '" + txtSoTien.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                double daThanhToan = double.Parse(fkbdt.txtDaThanhToan.Text);

                double soTien = double.Parse(txtSoTien.Text);

                daThanhToan += soTien;

                fkbdt.txtDaThanhToan.Text = daThanhToan.ToString();

                string sql_2 = "exec SP_DieuTri_Update_DaThanhToan '" + maDT + "', '" + daThanhToan.ToString() + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql_2, conn);

                MessageBox.Show("Lưu thành công!");

                Clear();

                using (fInPhieuThu form = new fInPhieuThu())
                {
                    form.ShowDialog();
                }
            }
            else if (maThanhToan == "" && txtSoTien.Text == "0")
            {
                MessageBox.Show("Chọn hình thức thanh toán và Nhập số tiền!");
            }
            else if (txtSoTien.Text == "0")
            {
                MessageBox.Show("Nhập số tiền!");
            }
            else
            {
                MessageBox.Show("Chọn hình thức thanh toán!");
            }           
        }

        void Clear()
        {
            txtNoiDung.Clear();
            txtSoTien.Text = "0";

            rbChuyenKhoan.Checked = false;
            rbQuetThe.Checked = false;
            rbThanhToanTM.Checked = false;
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(TTPhieuThu)
            {
                e.Handled = true;
            }    
        }

        private void fPhieuThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            fTTPhieuThu.TTPhieuThu = false;
        }

        private void ibtnIn_Click(object sender, EventArgs e)
        {
            using (InPhieuThu_2 form = new InPhieuThu_2())
            {
                form.ShowDialog();
            }
        }
    }
}
