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
    public partial class fChonThuThuat : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        string maBN = fDangKiKhamBenh.maBN;
        string maNhomTT = "";
        string maCTTT = "";
        string maNV = fDangNhap.maNV;
        string maDT = fKhamBenhDieuTri.maDT;

        string ngayKham = DateTime.Today.Date.ToString();

        fKhamBenhDieuTri fkbdt;

        public fChonThuThuat(fKhamBenhDieuTri fkbdt)
        {
            InitializeComponent();

            LoadDataNhomTT();

            LoadDataThuThuatDuocChon();

            this.fkbdt = fkbdt;
        }

        void LoadDataThuThuatDuocChon()
        {
            kndl.KetNoiDataGridView("exec SP_ChiTietDieuTri_HienThuThuat '0', '" + maDT + "'", dgvThuThuatDuocChon, conn);
        }

        void LoadDataNhomTT()
        {
            kndl.KetNoiDataGridView("select * from [vw_NhomThuThuat]", dgvNhomTT, conn);
        }

        private void dgvNhomTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maNhomTT = dgvNhomTT.Rows[e.RowIndex].Cells["clMaTT"].Value.ToString();

                kndl.KetNoiDataGridView("exec SP_ThuThuat '" + maNhomTT + "'", dgvThuThuat, conn);
            }
            catch (Exception)
            {
                
            }
        }

        private void dgvThuThuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                maCTTT = dgvThuThuat.Rows[e.RowIndex].Cells["clMaCTTT"].Value.ToString();              
            }
            catch (Exception)
            {
                maCTTT = "";
            }
        }

        private void dgvThuThuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maCTTT != "")
            {
                
                string sql = "exec SP_DieuTri_Them '0', '" + maBN + "', '" + maNV + "', '" + maCTTT + "', '" + ngayKham + "'";
                string datagrid = "exec SP_ChiTietDieuTri_HienThuThuat '1', '" + maDT + "'";

                if (maDT != "")
                {
                    sql = "exec SP_DieuTri_Them '" + maDT + "', '" + maBN + "', '" + maNV + "', '" + maCTTT + "', '" + ngayKham + "'";
                    datagrid = "exec SP_ChiTietDieuTri_HienThuThuat '0', '" + maDT + "'";
                    kndl.ThucThiDuLieu_KhongTraVe(sql, conn);
                }       
                else
                {
                    kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                    string sql_MaDT = "select * from vw_DieuTri_Moi";

                    try
                    {
                        kndl.KiemTraKetNoi(conn);

                        SqlCommand cmd = new SqlCommand(sql_MaDT, conn);

                        SqlDataReader rd = cmd.ExecuteReader();

                        while(rd.Read())
                        {
                            maDT = rd["MaDT"].ToString();
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

                kndl.KetNoiDataGridView(datagrid, dgvThuThuatDuocChon, conn);

                fkbdt.LoadDataDieuTri();

                fkbdt.dgvDieuTri_CellClick(fkbdt.dgvDieuTri, new DataGridViewCellEventArgs(1, 0));
            }   
        }

        private void dgvThuThuatDuocChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
