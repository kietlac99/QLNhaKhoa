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
    public partial class fThuThuat : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        TienIch ti = new TienIch();

        KiemTraLoi ktl = new KiemTraLoi();

        fNhomThuThuat fntt;

        string maTT = fNhomThuThuat.maTT;

        public fThuThuat(fNhomThuThuat fn)
        {
            InitializeComponent();
            txtTenThuThuat.MaxLength = 300;
            txtDonGia.MaxLength = 10;

            kndl.VaoComboBox("select * from vw_NhomThuThuat", cbxTenNhomTT, "MaTT", "TenNhomTT", conn);
            this.fntt = fn;
            TruyenDuLieu();
        }
        

        void TruyenDuLieu()
        {
            string sql = "exec SP_ThuThuat_Theo_MaTT '" + maTT + "'";

            if(fNhomThuThuat.btnSua_active)
            {
                try
                {
                    kndl.KiemTraKetNoi(conn);

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader rd = cmd.ExecuteReader();

                    while(rd.Read())
                    {
                        txtTenThuThuat.Text = rd["TenTT"].ToString();
                        cbxTenNhomTT.Text = rd["TenNhomTT"].ToString();
                        txtDonGia.Text = rd["DonGia"].ToString();
                        txtGiamGia.Text = rd["GiamGia"].ToString();
                        txtLyDoGiamGia.Text = rd["LyDoGiamGia"].ToString();
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

        void Them()
        {
            bool haveError = CheckError();
            if(haveError==false)
            {
                string Insert_ThuThuat = "exec SP_ThuThuat_Them '" + cbxTenNhomTT.SelectedValue + "', N'" + txtTenThuThuat.Text + "', '" + txtDonGia.Text + "', '" + txtGiamGia.Text + "', N'" + txtLyDoGiamGia.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(Insert_ThuThuat, conn);

                MessageBox.Show("Thêm thành công!");

                kndl.KetNoiDataGridView("exec SP_ThuThuat '" + cbxTenNhomTT.SelectedValue + "'", fntt.dgvTT, conn);

                fntt.lbTenNTT.Text = cbxTenNhomTT.Text;

                ti.ClearTextBoxes(this.Controls);
            }    
        }

        
        void Sua()
        {
            bool haveError = CheckError();
            if(haveError == false)
            {
                string Update_ThuThuat = "exec SP_ThuThuat_Sua '" + maTT + "', '" + cbxTenNhomTT.SelectedValue + "', N'" + txtTenThuThuat.Text + "', '" + txtDonGia.Text + "', '" + txtGiamGia.Text + "', N'" + txtLyDoGiamGia.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(Update_ThuThuat, conn);

                MessageBox.Show("Sửa thành công !");

                fntt.lbTenNTT.Text = cbxTenNhomTT.Text;

                kndl.KetNoiDataGridView("exec SP_ThuThuat '" + cbxTenNhomTT.SelectedValue + "'", fntt.dgvTT, conn);
            }    
        }

        private bool CheckError()
        {
            bool haveError = false;

            ktl.Rong("Vui lòng nhập tên thủ thuật!", ref haveError, erpThuThuat, txtTenThuThuat);

            ktl.Rong("Vui lòng nhập đơn giá!", ref haveError, erpThuThuat, txtDonGia);

            return haveError;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            float box_float = 0;
            float.TryParse(txtGiamGia.Text, out box_float);
            if(box_float < 0 && txtGiamGia.Text != "")
            {
                txtGiamGia.Text = "0";
            }  
            else if(box_float >100 && txtGiamGia.Text !="")
            {
                txtGiamGia.Text = "100";
            }    
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if(fNhomThuThuat.btnThem_active)
            {
                Them();
            }   
            else if(fNhomThuThuat.btnSua_active)
            {
                Sua();
            }    
        }
    }
}
