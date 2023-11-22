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
    public partial class fKhoiPhucSaoLuuDL : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        public fKhoiPhucSaoLuuDL()
        {
            InitializeComponent();
        }

        private void btnMoSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtViTriSaoLuu.Text = fbd.SelectedPath;

                btnSaoLuu.Enabled = true;
            }    
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            string database = conn.Database.ToString();

            if(txtViTriSaoLuu.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn vị trí để sao lưu!");
            }    
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK = '" + txtViTriSaoLuu.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                kndl.ThucThiDuLieu_KhongTraVe(cmd, conn);

                MessageBox.Show("Dữ liệu đã được sao lưu thành công!");

                btnSaoLuu.Enabled = false;
            }    
        }

        private void btnMoKhoiPhuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Khôi phục dữ liệu";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtViTriKhoiPhuc.Text = ofd.FileName;
                btnKhoiPhuc.Enabled = true;
            }    
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            string database = conn.Database.ToString();

            kndl.KiemTraKetNoi(conn);

            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, conn);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + txtViTriKhoiPhuc.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, conn);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, conn);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Khôi phục dữ liệu thành công!");

                btnKhoiPhuc.Enabled = false;
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
}
