using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa
{
    public partial class fDanhSachThuTienKhamBenh : Form
    {
        public static DateTime tuNgay;
        public static DateTime denNgay;

        TienIch ti = new TienIch();

        string id_per = fDangNhap.ID_Per;

        public fDanhSachThuTienKhamBenh()
        {
            InitializeComponent();

            LoadThongTin();

            ButtonPermission();
        }

        void ButtonPermission()
        {
            if (id_per == "5")
            {
                string canSearch = fDangNhap.arrTimKiem[12];

                ti.QuyenThaoTac(canSearch, ibtnTimKiem);
            }
        }

        void LoadThongTin()
        {
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd-MM-yyyy";
            dtpTuNgay.MaxDate = DateTime.Today;
            tuNgay = dtpTuNgay.Value;

            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd-MM-yyyy";
            dtpDenNgay.MaxDate = DateTime.Now;
            denNgay = dtpDenNgay.Value;
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            tuNgay = dtpTuNgay.Value;
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            denNgay = dtpDenNgay.Value;
        }

        private void ibtnTimKiem_Click(object sender, EventArgs e)
        {
            using(fInDSThuTienKhamBenh form = new fInDSThuTienKhamBenh())
            {
                form.ShowDialog();
            }    
        }
    }
}
