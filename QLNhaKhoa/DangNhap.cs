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
    public partial class fDangNhap : Form
    {
        TienIch ti = new TienIch();

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        public static string[] arrThem = new string[14];
        public static string[] arrSua = new string[14];
        public static string[] arrXoa = new string[14];
        public static string[] arrIn = new string[14];
        public static string[] arrTimKiem = new string[14];

        public static string maNV = "";

        public static string imageLocation = "";

        public fDangNhap()
        {
            InitializeComponent();
            LoadImage();
        }

        SqlConnection conn = new SqlConnection(@Connection.conn);

        void LoadImage()
        {
            string sql = "select * from vw_PhongKham";
            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();


                while (rd.Read())
                {                    
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

        string getMaNV(string id_user)
        {
            string maNV = "";

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand("exec NhanVien_LayMaNVTheoTaiKhoan '" + id_user + "'", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        maNV = dr["MaNV"].ToString();
                    }
                }
            }
            catch (Exception ect)
            {
                MessageBox.Show(ect.ToString());
            }
            finally
            {
                conn.Close();
            }

            return maNV;
        }

        private string getID()
        {
            txtUsername.Text = ti.RemoveSign4VietnameseString(txtUsername.Text);
            txtPassword.Text = ti.RemoveSign4VietnameseString(txtPassword.Text);

            string id = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec SP_TaiKhoan '" + txtUsername.Text + "', '" + txtPassword.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt!=null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        id = dr["MaTK"].ToString();
                    }    
                }    
            }
            catch(Exception ect)
            {
                MessageBox.Show(ect.ToString());
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private string get_PerID(string id_user)
        {
            string id_per = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("exec SP_TaiKhoan_LayMaQ '" + id_user + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id_per = dr["MaQ"].ToString();
                    }
                }
            }
            catch (Exception ect)
            {
                MessageBox.Show(ect.ToString());
            }
            finally
            {
                conn.Close();
            }
            return id_per;
        }

        public static string ID_User = "";
        public static string ID_Per = "";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {


            ID_User = getID();
            ID_Per = get_PerID(ID_User);
            maNV = getMaNV(ID_User);

            if (ID_Per == "5")
            {
                kndl.ActionLoad(conn);
            }

            if(ID_User != "")
            {
                fMainForm fmain = new fMainForm();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }   
            
        }
      
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }    
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

       
    }
}
