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
    public partial class fThuoc : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        KiemTraLoi ktl = new KiemTraLoi();

        TienIch ti = new TienIch();

        fMauDonThuoc fmdt;

        string maT = fMauDonThuoc.maT;
        string tenT = "";

        public fThuoc(fMauDonThuoc fmdt)
        {
            InitializeComponent();
            this.fmdt = fmdt;
            TextLenght();
            TruyenDuLieu();
        }

        void TextLenght()
        {
            txtTenThuoc.MaxLength = 300;
            txtDonVi.MaxLength = 100;
            txtLuongDung.MaxLength = 500;
            txtCongDung.MaxLength = 500;
        }

        void TruyenDuLieu()
        {
            string sql = "exec SP_Thuoc_Theo_MaT '" + maT + "'";

            if(fMauDonThuoc.activeSuaThuoc)
            {
                try
                {
                    kndl.KiemTraKetNoi(conn);

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader rd = cmd.ExecuteReader();

                    while(rd.Read())
                    {
                        txtTenThuoc.Text = rd["TenT"].ToString();

                        tenT = txtTenThuoc.Text;

                        txtDonVi.Text = rd["DonVi"].ToString();
                        txtLuongDung.Text = rd["LuongDung"].ToString();
                        txtCongDung.Text = rd["CongDung"].ToString();
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

        bool CheckError()
        {
            bool haveError = false;

            ktl.Rong("Không được để trống!", ref haveError, erpThuoc, txtTenThuoc);
          
            return haveError;
        }

        bool CheckDuplitcate()
        {
            bool isDup = false;

            ktl.TrungLap("exec SP_Thuoc_Dem_TenThuoc N'" + txtTenThuoc.Text + "'", "Đã có tên thuốc này!", ref isDup, erpThuoc, txtTenThuoc, conn);

            return isDup;
        }

        void Them()
        {
            bool haveError = CheckError();
            bool isDup = CheckDuplitcate();

            if(haveError==false && isDup==false)
            {
                string sql = "exec SP_Thuoc_Them N'" + txtTenThuoc.Text + "', N'" + txtDonVi.Text + "', N'" + txtLuongDung.Text + "', N'" + txtCongDung.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                MessageBox.Show("Thêm thành công!");

                fmdt.LoadThuoc();

                ti.ClearTextBoxes(this.Controls);
            }    
        }

        void Sua()
        {
            bool haveError = CheckError();
            bool isDup = CheckDuplitcate();

            if(isDup && tenT == txtTenThuoc.Text)
            {
                isDup = false;
                erpThuoc.SetError(txtTenThuoc, "");
            }    

            if(haveError == false && isDup == false)
            {
                string sql = "exec SP_Thuoc_Sua '" + maT + "', N'" + txtTenThuoc.Text + "', N'" + txtDonVi.Text + "', N'" + txtLuongDung.Text + "', N'" + txtCongDung.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                MessageBox.Show("Sửa thành công!");

                fmdt.LoadThuoc();
            }    
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            if(fMauDonThuoc.activeThemThuoc)
            {
                Them();
            }   
            else if(fMauDonThuoc.activeSuaThuoc)
            {
                Sua();
            }    
        }
    }
}
