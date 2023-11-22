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
    public partial class fMDT : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        KiemTraLoi ktl = new KiemTraLoi();

        TienIch ti = new TienIch();

        fMauDonThuoc fmdt;

        public fMDT(fMauDonThuoc fmdt)
        {
            InitializeComponent();

            txtMDT.MaxLength = 200;

            this.fmdt = fmdt;
        }

        bool CheckError()
        {
            bool haveError = false;

            ktl.Rong("Không được để trống!", ref haveError, erpMDT, txtMDT);

            return haveError;
        }

        void Them()
        {
            bool haveError = CheckError();

            if (haveError == false)
            {
                string sql = "exec SP_MauDonThuoc_Them N'" + txtMDT.Text + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                MessageBox.Show("Thêm thành công!");

                fmdt.LoadMauDonThuoc();

                ti.ClearTextBoxes(this.Controls);
            }
        }

        void Sua()
        {
            if (fMauDonThuoc.maMDT != "")
            {
                bool haveError = CheckError();

                if (haveError == false)
                {
                    string sql = "exec SP_MauDonThuoc_Sua '" + fMauDonThuoc.maMDT + "', N'" + txtMDT.Text + "'";

                    kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                    MessageBox.Show("Sửa thành công!");

                    fmdt.LoadMauDonThuoc();
                }
            }
            else
            {
                MessageBox.Show("Chọn thông tin để sửa!");
            }    
        }
        private void txtMDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if(fMauDonThuoc.activeThemMDT)
                {
                    Them();
                }  
                else if(fMauDonThuoc.activeSuaMDT)
                {
                    Sua();
                }    
            }    
        }
    }
}
