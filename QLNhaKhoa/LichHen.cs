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
    public partial class fLichHen : Form
    {
        SqlConnection conn = new SqlConnection(Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        string maDT = fKhamBenhDieuTri.maDT;
        string maNV = fDangNhap.maNV;
        string maBN = fDangKiKhamBenh.maBN;
        string maLH = "";

        bool suaClicked = false;
        bool themClicked = false;

        public fLichHen()
        {
            InitializeComponent();

            LoadThongTin();

            LoadBenhNhan();

            LoadDataGrid();           
        }

        void LoadDataGrid()
        {
            kndl.KetNoiDataGridView("exec SP_LichHen_Theo_MaBN '" + maBN + "'", dgvLichHen, conn);         
        }        

        void LoadThongTin()
        {
            dtpNgay.Format = DateTimePickerFormat.Custom;
            dtpNgay.CustomFormat = "dd-MM-yyyy";

            dtpGio.Format = DateTimePickerFormat.Custom;
            dtpGio.CustomFormat = "HH:mm:ss";
            dtpGio.ShowUpDown = true;

            LayTenNhanVien();

            dtpNgay.Enabled = false;
            dtpGio.Enabled = false;

            txtNoiDung.Enabled = false;
            txtGhiChu.Enabled = false;

            ibtnLuu.Enabled = false;
        }

        private void LayTenNhanVien()
        {
            kndl.VaoComboBox("select * from vw_NhanVien_Lay_Ten_BacSy", cbxBacSy, "MaNV", "HoTen", conn);

            string query = "exec SP_NhanVien_Lay_TenNV_Theo_MaNV '" + maNV + "'";

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(query, conn);

                cbxBacSy.SelectedValue = cmd.ExecuteScalar().ToString();

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

        void LoadBenhNhan()
        {
            string query = "exec SP_DieuTri_Lay_TenBN_Theo_MaDT '" + maDT + "'";

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lbLichHen.Text += rd["HoTen"].ToString();
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

        private void dgvLichHen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!themClicked)
            {
                try
                {
                    maLH = dgvLichHen.Rows[e.RowIndex].Cells["clMaLH"].Value.ToString();

                    string ngay = DateTime.Parse(dgvLichHen.Rows[e.RowIndex].Cells["clNgay"].Value.ToString()).ToString("dd-MM-yyyy");
                    string gio = DateTime.Parse(dgvLichHen.Rows[e.RowIndex].Cells["clGio"].Value.ToString()).ToString("HH:mm:ss");

                    dtpNgay.Value = DateTime.Parse(ngay);
                    dtpGio.Value = DateTime.Parse(gio);

                    cbxBacSy.SelectedValue = dgvLichHen.Rows[e.RowIndex].Cells["clMaNV"].Value.ToString();

                    string noiDung = dgvLichHen.Rows[e.RowIndex].Cells["clNoiDung"].Value.ToString();
                    string ghiChu = dgvLichHen.Rows[e.RowIndex].Cells["clGhiChu"].Value.ToString();

                    txtNoiDung.Text = noiDung.Replace("<br />", "\r\n");
                    txtGhiChu.Text = ghiChu.Replace("<br />", "\r\n");
                }
                catch (Exception)
                {

                }
            }
        } 

        private void ibtnRefresh_Click(object sender, EventArgs e)
        {
            themClicked = false;
            suaClicked = false;

            dtpNgay.Value = DateTime.Now;
            dtpGio.Value = DateTime.Now;

            txtGhiChu.Enabled = false;
            txtNoiDung.Enabled = false;

            dtpNgay.Enabled = false;
            dtpGio.Enabled = false;

            LayTenNhanVien();

            txtNoiDung.Clear();
            txtGhiChu.Clear();

            if (ibtnLuu.Enabled)
            {
                ibtnLuu.Enabled = false;
            }

            if (!ibtnThem.Enabled)
            {
                ibtnThem.Enabled = true;
            }

            if(!ibtnSua.Enabled)
            {
                ibtnSua.Enabled = true;
            }    

            if(!ibtnXoa.Enabled)
            {
                ibtnXoa.Enabled = true;
            }

            LoadDataGrid();

            ti.RowsColor("clNgay", tmLichHen, dgvLichHen);
        }

        void HienOThongTin()
        {
            ibtnLuu.Enabled = true;
            ibtnXoa.Enabled = false;

            dtpNgay.Enabled = true;
            dtpGio.Enabled = true;

            txtNoiDung.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {     
            if (!string.IsNullOrEmpty(maLH))
            {
                suaClicked = true;
                themClicked = false;

                ibtnThem.Enabled = false;

                HienOThongTin();              
            }
        }

        private void ibtnThem_Click(object sender, EventArgs e)
        {
            ti.ClearTextBoxes(this.Controls);

            dtpNgay.Value = DateTime.Now;
            dtpGio.Value = DateTime.Now;

            cbxBacSy.SelectedValue = maNV;

            themClicked = true;
            suaClicked = false;

            ibtnSua.Enabled = false;

            HienOThongTin();
        }

        void TatOThongTin()
        {
            txtGhiChu.Enabled = false;
            txtNoiDung.Enabled = false;

            dtpNgay.Enabled = false;
            dtpGio.Enabled = false;
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            string ngayGio = dtpNgay.Value.ToString("dd-MM-yyyy") + " " + dtpGio.Value.ToString("HH:mm:ss");
            string noiDung = txtNoiDung.Text.Replace("\r\n", "<br />");
            string ghiChu = txtGhiChu.Text.Replace("\r\n", "<br />");

            if (themClicked)
            {            
                string query = "exec SP_LichHen_Them '" + maBN + "', '" + maNV + "', '" + ngayGio + "', N'" + noiDung + "', N'" + ghiChu + "'";

                kndl.ThucThiDuLieu_KhongTraVe(query, conn);
                MessageBox.Show("Thêm thành công!");

                ibtnRefresh_Click(sender, e);

                TatOThongTin();

                LoadDataGrid();

                ti.RowsColor("clNgay", tmLichHen, dgvLichHen);
            }    
            else if(suaClicked)
            {
                if(!string.IsNullOrEmpty(maLH))
                {
                    string query = "exec SP_LichHen_Sua '" + maLH + "', '" + ngayGio + "', N'" + noiDung + "', N'" + ghiChu + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(query, conn);
                    MessageBox.Show("Sửa thành công!");

                    ibtnRefresh_Click(sender, e);

                    TatOThongTin();

                    LoadDataGrid();

                    ti.RowsColor("clNgay", tmLichHen, dgvLichHen);
                }    
            }    
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(maLH))
            {
                if (MessageBox.Show("Xác nhận xóa?", "Xóa lịch hẹn!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "exec SP_LichHen_Xoa '" + maLH + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(query, conn);

                    LoadDataGrid();

                    ti.RowsColor("clNgay", tmLichHen, dgvLichHen);

                    MessageBox.Show("Xóa thành công!");

                    ibtnRefresh_Click(sender, e);
                }
            }    
        }

        private void fLichHen_Load(object sender, EventArgs e)
        {
            ti.RowsColor("clNgay", tmLichHen, dgvLichHen);

            dgvLichHen.ClearSelection();
        }

        private void tmLichHen_Tick(object sender, EventArgs e)
        {
            ti.Timer_Tick("clNgay", dgvLichHen);
        }

        private void dgvLichHen_Sorted(object sender, EventArgs e)
        {
            ti.RowsColor("clNgay", tmLichHen, dgvLichHen);
        }
    }
}
