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
    public partial class fThongTinPhongKham : Form
    {
        fMainForm fMainForm;

        public fThongTinPhongKham(fMainForm fMain)
        {
            InitializeComponent();
            TextLength();
            LoadDuLieu();
            ActionLoad();
            ButtonPermisson();
            LoadImage();
            this.fMainForm = fMain;
        }

        private void LoadImage()
        {
            if (imageLocation != "")
            {
                pbxLogo.Image = new Bitmap(imageLocation);
            }
        }

        TienIch ti = new TienIch();

        string imageLocation = fDangNhap.imageLocation;

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        SqlConnection conn = new SqlConnection(@Connection.conn);

        KiemTraLoi ktl = new KiemTraLoi();

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
                string canEdit = fDangNhap.arrSua[3];
                ti.QuyenThaoTac(canEdit, ibtnLuu);
                ti.QuyenThaoTac(canEdit, btnChonLogo);
            }
        }

        void TextLength()
        {
            txtTenPK.MaxLength = 300;
            txtDiaChi.MaxLength = 300;
            txtSoDT.MaxLength = 10;
            txtKCB.MaxLength = 300;
            txtWebsite.MaxLength = 300;
        }

        void LoadDuLieu()
        {
            string sql = "select * from vw_PhongKham";
            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    txtTenPK.Text = rd["TenPK"].ToString();
                    txtDiaChi.Text = rd["DiaChi"].ToString();
                    txtKCB.Text = rd["GiayPhepKBC"].ToString();
                    txtSoDT.Text = rd["Sodt"].ToString();
                    txtWebsite.Text = rd["Website"].ToString();
                    imageLocation = rd["HinhAnh"].ToString();
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

        private void btnChonLogo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";


                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbxLogo.Image = new Bitmap(dialog.FileName);
                    
                }

                imageLocation = dialog.FileName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool CheckError()
        {
            bool haveError = false;

            ktl.DoDai("Số điện thoại không khả dụng!", 10, ref haveError, erpPhongKham, txtSoDT);

            if(txtSoDT.TextLength<=0)
            {
                erpPhongKham.SetError(txtSoDT, "");
            }    

            return haveError;
        }

        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            ti.RemoveSign4VietnameseString(txtWebsite.Text);
            bool haveError = CheckError();

            if (haveError == false)
            {             
                string sql = "exec SP_PhongKham_Sua N'" + txtTenPK.Text + "', N'" + txtDiaChi.Text + "', '" + txtSoDT.Text + "', N'" + txtKCB.Text + "', '" + txtWebsite.Text + "', N'" + imageLocation + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                fMainForm.pbxLogo.Image = new Bitmap(imageLocation);

                MessageBox.Show("Lưu thành công!");

                LoadDuLieu();
            }
        }
    }
}
