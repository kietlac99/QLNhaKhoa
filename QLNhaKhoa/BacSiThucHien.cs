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
    public partial class fBacSiThucHien : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        fKhamBenhDieuTri fkbdt;

        string maCTDT = fKhamBenhDieuTri.maCTDT;

        string maNV_BS = "";
        string maNV_TT = "";
        string maNDT_BS = "";
        string maNDT_TT = "";

        public fBacSiThucHien(fKhamBenhDieuTri fkbdt)
        {
            InitializeComponent();

            LoadDataBacSi();

            LoadDataTroThu();

            LoadDataBSDuocChon();

            LoadDataTTDuocChon();

            LoadThongTin();

            this.fkbdt = fkbdt;
        }

        void LoadThongTin()
        {
            if(dgvBSDuocChon.Rows.Count > 0)
            {
                dgvBacSi.Enabled = false;
            }                
        }

        void LoadDataBacSi()
        {
            kndl.KetNoiDataGridView("select * from vw_NhanVien_BacSi", dgvBacSi, conn);
        }

        void LoadDataTroThu()
        {
            kndl.KetNoiDataGridView("select * from vw_NhanVien_TroThu", dgvTroThu, conn);
        }

        void LoadDataBSDuocChon()
        {
            kndl.KetNoiDataGridView("exec SP_NhomDieuTri_Theo_MaCTDT '" + maCTDT + "'", dgvBSDuocChon, conn);
        }

        void LoadDataTTDuocChon()
        {
            kndl.KetNoiDataGridView("exec SP_NhomDieuTri_Theo_MaCTDT_TroThu '" + maCTDT + "'", dgvTTDuocChon, conn);
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maNV_BS = dgvBacSi.Rows[e.RowIndex].Cells["clMaNV"].Value.ToString();
            }
            catch (Exception)
            {
                maNV_BS = "";
            }
        }

        private void dgvBacSi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(maNV_BS != "")
            {
                string sql = "exec SP_NhomDieuTri_BacSi_Them '" + maCTDT + "', '" + maNV_BS + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                LoadDataBSDuocChon();

                dgvBacSi.Enabled = false;

                fkbdt.LoadDataDieuTri();

                fkbdt.dgvDieuTri_CellClick(fkbdt.dgvDieuTri, new DataGridViewCellEventArgs(1, 0));
            }    
        }

        private void dgvBSDuocChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maNDT_BS = dgvBSDuocChon.Rows[e.RowIndex].Cells["clMaNDT"].Value.ToString();
            }
            catch (Exception)
            {
                maNDT_BS = "";
            }
        }

        private void dgvBSDuocChon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(maNDT_BS != "")
            {
                string sql = "exec SP_NhomDieuTri_BacSi_Xoa '" + maNDT_BS + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                LoadDataBSDuocChon();

                dgvBacSi.Enabled = true;

                fkbdt.LoadDataDieuTri();

                fkbdt.dgvDieuTri_CellClick(fkbdt.dgvDieuTri, new DataGridViewCellEventArgs(1, 0));
            }    
        }

        private void dgvTroThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maNV_TT = dgvTroThu.Rows[e.RowIndex].Cells["clMaNhanVien"].Value.ToString();
            }
            catch (Exception)
            {
                maNV_TT = "";
            }
        }

        private void dgvTroThu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maNV_TT != "")
            {
                if (dgvBSDuocChon.Rows.Count > 0)
                {
                    string sql = "exec SP_NhomDieuTri_TroThu_Them '" + maCTDT + "', '" + maNV_TT + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                    LoadDataTTDuocChon();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bác sĩ thực hiện trước!");
                }    
            }
        }

        private void dgvTTDuocChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maNDT_TT = dgvTTDuocChon.Rows[e.RowIndex].Cells["clMaNhomDT"].Value.ToString();
            }
            catch (Exception)
            {
                maNDT_TT = "";
            }
        }

        private void dgvTTDuocChon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(maNDT_TT != "")
            {
                string sql = "exec SP_NhomDieuTri_TroThu_Xoa '" + maNDT_TT + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                LoadDataTTDuocChon();
            }    
        }
    }
}
