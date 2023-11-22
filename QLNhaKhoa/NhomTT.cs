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
    public partial class fNhomTT : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        KiemTraLoi ktl = new KiemTraLoi();

        fNhomThuThuat ntt;

        public fNhomTT(fNhomThuThuat nt)
        {
            InitializeComponent();
            txtNhomTT.MaxLength = 300;
            this.ntt = nt;
        }

        bool CheckError()
        {
            bool haveError = false;

            ktl.Rong("Không được để trống!", ref haveError, erpNhomTT, txtNhomTT);

            return haveError;
        }


        void Sua()
        {
            if (fNhomThuThuat.maNhomTT != "")
            {
                bool haveError = CheckError();

                if (haveError == false)
                {
                    try
                    {
                        kndl.KiemTraKetNoi(conn);
                        SqlCommand cmd = new SqlCommand("exec SP_NhomThuThuat_AddOrEdit '" + fNhomThuThuat.maNhomTT + "', N'" + txtNhomTT.Text + "'", conn);
                        cmd.ExecuteNonQuery();

                        ntt.LoadDataGrid_NhomThuThuat();

                        MessageBox.Show("Sửa thành công!");
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
            else
            {
                MessageBox.Show("Chọn thông tin để sửa!");
            }    
        }

        private void Them()
        {
            bool haveError = CheckError();

            if (haveError == false)
            {
                try
                {
                    kndl.KiemTraKetNoi(conn);
                    SqlCommand cmd = new SqlCommand("exec SP_NhomThuThuat_AddOrEdit '0', N'" + txtNhomTT.Text + "'", conn);
                    cmd.ExecuteNonQuery();

                    ntt.LoadDataGrid_NhomThuThuat();

                    MessageBox.Show("Thêm thành công!");
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

        private void txtNhomTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if (fNhomThuThuat.btnThemNTT_active)
                {
                    Them();
                }
                else if (fNhomThuThuat.btnSuaNTT_active)
                {
                    Sua();
                }
            }    
        }
    }
}
