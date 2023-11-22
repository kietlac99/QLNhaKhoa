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
    public partial class fDoiMatKhau : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);
     
        TienIch ti = new TienIch();

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        public fDoiMatKhau()
        {
            InitializeComponent();
            txtMKCu.MaxLength = 127;
            txtMKMoi.MaxLength = 127;
            txtXNMK.MaxLength = 127;
            ActionLoad();
            ButtonPermisson();
        }

        string id_per = fDangNhap.ID_Per;
        void ActionLoad()
        {
           
            if (id_per == "5")
            {
                kndl.ActionLoad(conn);
            }
        }


        void ButtonPermisson()
        {
            if (id_per == "5")
            {
                string canEdit = fDangNhap.arrSua[0];
                ti.QuyenThaoTac(canEdit, btnXacNhan);
            }
        }

        void Clear()
        {
            ti.ClearTextBoxes(this.Controls);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            txtMKCu.Text = ti.RemoveSign4VietnameseString(txtMKCu.Text);
            txtMKMoi.Text = ti.RemoveSign4VietnameseString(txtMKMoi.Text);
            txtXNMK.Text = ti.RemoveSign4VietnameseString(txtXNMK.Text);


            string sqlquery = "exec SP_KiemTraMatKhau '" + fDangNhap.ID_User + "', '" + txtMKCu.Text + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                if (dt.Rows.Count > 0)
                {
                    erpDoiMK.SetError(txtMKCu, "");
                    if(txtMKMoi.Text==txtXNMK.Text)
                    {
                        erpDoiMK.SetError(txtXNMK, "");
                        sqlquery = "exec SP_DoiMatKhau '" + fDangNhap.ID_User + "', '" + txtMKMoi.Text + "'";
                        cmd = new SqlCommand(sqlquery, conn);
                        da = new SqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công!", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }  
                    else
                    {
                        erpDoiMK.SetError(txtXNMK, "Mật khẩu không khớp!");
                    }    
                    
                }
                else
                {
                    erpDoiMK.SetError(txtMKCu, "Sai mật khẩu!");
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

        private void txtMKCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtMKMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtXNMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
