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
using System.Runtime.InteropServices;

namespace QLNhaKhoa
{
    public partial class fMainForm : Form
    {
        private int borderSize = 2;

        private Size formSize;

        bool[] arrXem = new bool[14];

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        public fMainForm()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);
            customizeDesing();
            this.WindowState = FormWindowState.Maximized;                    
            LoadButton();
            LoadLogo();
        }

        void LoadLogo()
        {
            string imageLocation = fDangNhap.imageLocation;
            if(imageLocation != "")
            {
                pbxLogo.Image = new Bitmap(imageLocation);
            }    
        }

        string id_user = fDangNhap.ID_User;
        void LoadChucNang()
        {          
            string sql = "exec SP_HanhDong_MaTK '" + id_user + "'";

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();
                int i = 0;
                while(rd.Read())
                {
                    arrXem[i] = Boolean.Parse(rd["Xem"].ToString());
                    i++;
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

            TatChucNang(arrXem[0], ibtnDoiMK);
            TatChucNang(arrXem[1], ibtnQLNhanVien);
            TatChucNang(arrXem[2], ibtnPhanQuyen);
            TatChucNang(arrXem[3], ibtnTTPK);
            TatChucNang(arrXem[4], ibtnThuThuat);
            TatChucNang(arrXem[5], ibtnMauDonThuoc);
            TatChucNang(arrXem[6], ibtnDangKyKham);
            TatChucNang(arrXem[7], ibtnDanhMucDThuoc);
            TatChucNang(arrXem[9], ibtnPhieuThu);
            TatChucNang(arrXem[12], ibtnThuTienKhamBenh);
        }

        void TatChucNang(bool xem, Button btn)
        {
            if(xem == false)
            {
                btn.Enabled = false;
            }    
        }

        void LoadButton()
        {
            if(fDangNhap.ID_Per=="5")
            {
                LoadChucNang();
                ibtnDuLieu.Enabled = false;
            }    
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
   
        private void customizeDesing()
        {
            pnHomeSubmenu.Visible = false;
            pnDanhMuc.Visible = false;
            pnHoSoBenh.Visible = false;
            pnBaoCao.Visible = false;
        }

        private void hideSubmenu()
        {
            
            if(pnHomeSubmenu.Visible==true)
            {
                pnHomeSubmenu.Visible = false;
                
            }    

            if(pnDanhMuc.Visible)
            {
                pnDanhMuc.Visible = false;
            }    

            if(pnHoSoBenh.Visible)
            {
                pnHoSoBenh.Visible = false;
            }    

            if(pnBaoCao.Visible)
            {
                pnBaoCao.Visible = false;
            }    
        }

        private void showSubmenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }    
            else
            {
                subMenu.Visible = false;
            }    
        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            showSubmenu(pnHomeSubmenu);          
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnDesktop.Controls.Add(childForm);
            pnDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        string UID = fDangNhap.ID_User;

        SqlConnection conn = new SqlConnection(@Connection.conn);

        public static List<string> listper = null;
        private void fMainForm_Load(object sender, EventArgs e)
        {
            
        }
        

        private void ibtnDoiMK_Click(object sender, EventArgs e)
        {
            openChildForm(new fDoiMatKhau());
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            if (m.Msg==WM_NCCALCSIZE && m.WParam.ToInt32()==1)
            {
                return;
            }

            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void fMainForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void ibtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ibtnMaxi_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }    
            else
            {
                this.WindowState = FormWindowState.Normal;
            }    

        }

        private void ibtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ibtnBars_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            
        }

        void CollapseSubMenu(Panel pn)
        {
            foreach (Button menuButton in pn.Controls.OfType<Button>())
            {
                menuButton.Text = "";
                menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                menuButton.Padding = new Padding(0);
            }
        }

        void OpenSubMenu(Panel pn)
        {
            foreach (Button menuButton in pn.Controls.OfType<Button>())
            {
                menuButton.Text = "   " + menuButton.Tag.ToString();
                menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                menuButton.Padding = new Padding(35, 0, 0, 0);
            }
        }

        private void CollapseMenu()
        {
            
            if (this.pnMenu.Width > 200)
            {
                pnMenu.Width = 100;
                pbxLogo.Visible = false;
                ibtnBars.Dock = DockStyle.Top;
                foreach (Button menuButton in pnMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }

                foreach (Button menuButton in pnHomeSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }

                CollapseSubMenu(pnDanhMuc);
                CollapseSubMenu(pnHoSoBenh);
                CollapseSubMenu(pnBaoCao);
            }
            else
            {
                pnMenu.Width = 230;
                pbxLogo.Visible = true;
                ibtnBars.Dock = DockStyle.None;

                foreach (Button menuButton in pnMenu.Controls.OfType<Button>())
                {                                    
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);                  
                }

                foreach (Button menuButton in pnHomeSubmenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(35, 0, 0, 0);
                }

                OpenSubMenu(pnDanhMuc);
                OpenSubMenu(pnHoSoBenh);
                OpenSubMenu(pnBaoCao);
            }

            
        }

        private void ibtnQLNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new fQuanLyNhanVien());   
        }

        private void ibtnDangXuat_Click(object sender, EventArgs e)
        {
            fDangNhap fDN = new fDangNhap();
            DialogResult dr = MessageBox.Show("Đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                fDN.Show();
            }
        }

        private void ibtnPhanQuyen_Click(object sender, EventArgs e)
        {
            openChildForm(new fPhanQuyen());
        }

        private void ibtnTTPK_Click(object sender, EventArgs e)
        {
            openChildForm(new fThongTinPhongKham(this));
        }

        private void ibtnDanhMuc_Click(object sender, EventArgs e)
        {
            showSubmenu(pnDanhMuc);
        }

        private void ibtnThuThuat_Click(object sender, EventArgs e)
        {
            openChildForm(new fNhomThuThuat());
        }

        private void ibtnMauDonThuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new fMauDonThuoc());
        }

        private void ibtnHoSoBenh_Click(object sender, EventArgs e)
        {
            showSubmenu(pnHoSoBenh);
        }

        private void ibtnDangKyKham_Click(object sender, EventArgs e)
        {
            openChildForm(new fDangKiKhamBenh(this));
        }

        private void ibtnDanhMucDThuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new fDanhSachDonThuoc());
        }

        private void ibtnPhieuThu_Click(object sender, EventArgs e)
        {
            openChildForm(new fTTPhieuThu());
        }

        private void ibtnBaoCao_Click(object sender, EventArgs e)
        {
            showSubmenu(pnBaoCao);
        }

        private void ibtnThuTienKhamBenh_Click(object sender, EventArgs e)
        {
            openChildForm(new fDanhSachThuTienKhamBenh());
        }

        private void ibtnDuLieu_Click(object sender, EventArgs e)
        {
            openChildForm(new fKhoiPhucSaoLuuDL());
        }
    }
}
