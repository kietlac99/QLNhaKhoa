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
    public partial class fSoDoHamRang : Form
    {
        SqlConnection conn = new SqlConnection(@Connection.conn);

        KetNoiDuLieu kndl = new KetNoiDuLieu();

        string[] arrRang = new string[52];

        string maCTDT = fKhamBenhDieuTri.maCTDT;

        fKhamBenhDieuTri fkbdt;

        public fSoDoHamRang(fKhamBenhDieuTri fkbdt)
        {
            InitializeComponent();

            LoadThongTin();

            LoadDuLieu();

            this.fkbdt = fkbdt;
        }

        void LoadThongTin()
        {
            ckbxHamNguoiLon.Checked = true;
            ckbxHamTreEm.Checked = true;
        }

        void LoadDuLieu()
        {
            string sql = "exec SP_ChiTietDieuTri_LayThongTin_Rang '" + maCTDT + "'";

            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();

                int i = 0;

                while(rd.Read())
                {
                    arrRang[i] = rd["MaR"].ToString();

                    i++;
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

            for(int i=0; i<52; i++)
            {
                if(arrRang[i] == "1")
                {
                    pbxR55.BackColor = Color.Yellow;
                }
                else if(arrRang[i] == "2")
                {
                    pbxR54.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "3")
                {
                    pbxR53.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "4")
                {
                    pbxR52.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "5")
                {
                    pbxR51.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "6")
                {
                    pbxR61.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "7")
                {
                    pbxR62.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "8")
                {
                    pbxR63.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "10")
                {
                    pbxR64.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "11")
                {
                    pbxR65.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "12")
                {
                    pbxR85.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "13")
                {
                    pbxR84.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "14")
                {
                    pbxR83.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "15")
                {
                    pbxR82.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "16")
                {
                    pbxR81.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "17")
                {
                    pbxR71.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "18")
                {
                    pbxR72.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "19")
                {
                    pbxR73.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "20")
                {
                    pbxR74.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "21")
                {
                    pbxR75.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "22")
                {
                    pbxR18.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "23")
                {
                    pbxR17.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "24")
                {
                    pbxR16.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "25")
                {
                    pbxR15.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "26")
                {
                    pbxR14.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "27")
                {
                    pbxR13.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "28")
                {
                    pbxR12.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "29")
                {
                    pbxR11.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "30")
                {
                    pbxR21.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "31")
                {
                    pbxR22.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "32")
                {
                    pbxR23.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "33")
                {
                    pbxR24.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "34")
                {
                    pbxR25.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "35")
                {
                    pbxR26.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "36")
                {
                    pbxR27.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "37")
                {
                    pbxR28.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "38")
                {
                    pbxR48.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "39")
                {
                    pbxR47.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "40")
                {
                    pbxR46.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "41")
                {
                    pbxR45.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "42")
                {
                    pbxR44.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "43")
                {
                    pbxR43.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "44")
                {
                    pbxR42.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "45")
                {
                    pbxR41.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "46")
                {
                    pbxR31.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "47")
                {
                    pbxR32.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "48")
                {
                    pbxR33.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "49")
                {
                    pbxR34.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "50")
                {
                    pbxR35.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "51")
                {
                    pbxR36.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "52")
                {
                    pbxR37.BackColor = Color.Yellow;
                }
                else if (arrRang[i] == "53")
                {
                    pbxR38.BackColor = Color.Yellow;
                }
            }
        }

        void ChangePictureBorderColor(PictureBox pbx, string maR)
        {
            string sql = "exec SP_ChiTietDieuTriRang_Them '" + maR + "', '" + maCTDT + "'";
            if (pbx.BackColor == Color.Transparent)
            {
                pbx.BackColor = Color.Yellow;

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                fkbdt.LoadDataDieuTri();

                fkbdt.dgvDieuTri_CellClick(fkbdt.dgvDieuTri, new DataGridViewCellEventArgs(1, 0));
            }
            else if(pbx.BackColor == Color.Yellow)
            {
                pbx.BackColor = Color.Transparent;

                sql = "SP_ChiTietDieuTriRang_Xoa '" + maR + "', '" + maCTDT + "'";

                kndl.ThucThiDuLieu_KhongTraVe(sql, conn);

                fkbdt.LoadDataDieuTri();

                fkbdt.dgvDieuTri_CellClick(fkbdt.dgvDieuTri, new DataGridViewCellEventArgs(1, 0));
            }

        }

        private void pbxR55_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR55, "1"); 
        }          

        private void pbxR54_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR54, "2");
        }

        private void pbxR53_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR53, "3");
        }

        private void pbxR52_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR52, "4");
        }

        private void pbxR51_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR51, "5");
        }

        private void pbxR61_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR61, "6");
        }

        private void pbxR62_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR62, "7");
        }

        private void pbxR63_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR63, "8");
        }

        private void pbxR64_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR64, "10");
        }

        private void pbxR65_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR65, "11");
        }

        private void pbxR18_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR18, "22");
        }

        private void pbxR17_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR17, "23");
        }

        private void pbxR16_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR16, "24");
        }

        private void pbxR15_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR15, "25");
        }

        private void pbxR14_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR14, "26");
        }

        private void pbxR13_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR13, "27");
        }

        private void pbxR12_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR12, "28");
        }

        private void pbxR11_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR11, "29");
        }

        private void pbxR21_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR21, "30");
        }

        private void pbxR22_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR22, "31");
        }

        private void pbxR23_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR23, "32");
        }

        private void pbxR24_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR24, "33");
        }

        private void pbxR25_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR25, "34");
        }

        private void pbxR26_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR26, "35");
        }

        private void pbxR27_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR27, "36");
        }

        private void pbxR28_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR28, "37");
        }

        private void pbxR48_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR48, "38");
        }

        private void pbxR47_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR47, "39");
        }

        private void pbxR46_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR46, "40");
        }

        private void pbxR45_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR45, "41");
        }

        private void pbxR44_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR44, "42");
        }

        private void pbxR43_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR43, "43");
        }

        private void pbxR42_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR42, "44");
        }

        private void pbxR41_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR41, "45");
        }

        private void pbxR31_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR31, "46");
        }

        private void pbxR32_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR32, "47");
        }

        private void pbxR33_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR33, "48");
        }

        private void pbxR34_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR34, "49");
        }

        private void pbxR35_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR35, "50");
        }

        private void pbxR36_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR36, "51");
        }

        private void pbxR37_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR37, "52");
        }

        private void pbxR38_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR38, "53");
        }

        private void pbxR85_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR85, "12");
        }

        private void pbxR84_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR84, "13");
        }

        private void pbxR83_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR83, "14");
        }

        private void pbxR82_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR82, "15");
        }

        private void pbxR81_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR81, "16");
        }

        private void pbxR71_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR71, "17");
        }

        private void pbxR72_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR72, "18");
        }

        private void pbxR73_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR73, "19");
        }

        private void pbxR74_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR74, "20");
        }

        private void pbxR75_Click(object sender, EventArgs e)
        {
            ChangePictureBorderColor(pbxR75, "21");
        }

        void TatHamNguoiLon()
        {
            pbxR18.Visible = false;
            pbxR17.Visible = false;
            pbxR16.Visible = false;
            pbxR15.Visible = false;
            pbxR14.Visible = false;
            pbxR12.Visible = false;
            pbxR13.Visible = false;
            pbxR11.Visible = false;
            pbxR21.Visible = false;
            pbxR22.Visible = false;
            pbxR23.Visible = false;
            pbxR24.Visible = false;
            pbxR25.Visible = false;
            pbxR26.Visible = false;
            pbxR27.Visible = false;
            pbxR28.Visible = false;
            pbxR48.Visible = false;
            pbxR47.Visible = false;
            pbxR46.Visible = false;
            pbxR45.Visible = false;
            pbxR44.Visible = false;
            pbxR43.Visible = false;
            pbxR42.Visible = false;
            pbxR41.Visible = false;
            pbxR31.Visible = false;
            pbxR32.Visible = false;
            pbxR33.Visible = false;
            pbxR34.Visible = false;
            pbxR35.Visible = false;
            pbxR36.Visible = false;
            pbxR37.Visible = false;
            pbxR38.Visible = false;
        }

        void BatHamNguoiLon()
        {
            pbxR18.Visible = true;
            pbxR17.Visible = true;
            pbxR16.Visible = true;
            pbxR15.Visible = true;
            pbxR14.Visible = true;
            pbxR12.Visible = true;
            pbxR13.Visible = true;
            pbxR11.Visible = true;
            pbxR21.Visible = true;
            pbxR22.Visible = true;
            pbxR23.Visible = true;
            pbxR24.Visible = true;
            pbxR25.Visible = true;
            pbxR26.Visible = true;
            pbxR27.Visible = true;
            pbxR28.Visible = true;
            pbxR48.Visible = true;
            pbxR47.Visible = true;
            pbxR46.Visible = true;
            pbxR45.Visible = true;
            pbxR44.Visible = true;
            pbxR43.Visible = true;
            pbxR42.Visible = true;
            pbxR41.Visible = true;
            pbxR31.Visible = true;
            pbxR32.Visible = true;
            pbxR33.Visible = true;
            pbxR34.Visible = true;
            pbxR35.Visible = true;
            pbxR36.Visible = true;
            pbxR37.Visible = true;
            pbxR38.Visible = true;
        }

        void TatHamTreEm()
        {
            pbxR55.Visible = false;
            pbxR54.Visible = false;
            pbxR53.Visible = false;
            pbxR52.Visible = false;
            pbxR51.Visible = false;
            pbxR61.Visible = false;
            pbxR65.Visible = false;
            pbxR64.Visible = false;
            pbxR63.Visible = false;
            pbxR62.Visible = false;
            pbxR85.Visible = false;
            pbxR84.Visible = false;
            pbxR81.Visible = false;
            pbxR82.Visible = false;
            pbxR83.Visible = false;
            pbxR71.Visible = false;
            pbxR72.Visible = false;
            pbxR73.Visible = false;
            pbxR74.Visible = false;
            pbxR75.Visible = false;
        }

        void BatHamTreEm()
        {
            pbxR55.Visible = true;
            pbxR54.Visible = true;
            pbxR53.Visible = true;
            pbxR52.Visible = true;
            pbxR51.Visible = true;
            pbxR61.Visible = true;
            pbxR65.Visible = true;
            pbxR64.Visible = true;
            pbxR63.Visible = true;
            pbxR62.Visible = true;
            pbxR85.Visible = true;
            pbxR84.Visible = true;
            pbxR81.Visible = true;
            pbxR82.Visible = true;
            pbxR83.Visible = true;
            pbxR71.Visible = true;
            pbxR72.Visible = true;
            pbxR73.Visible = true;
            pbxR74.Visible = true;
            pbxR75.Visible = true;
        }

        private void ckbxHamNguoiLon_CheckedChanged(object sender, EventArgs e)
        {
            if(!ckbxHamNguoiLon.Checked)
            {
                TatHamNguoiLon();
            }
            else
            {
                BatHamNguoiLon();
            }
        }

        private void ckbxHamTreEm_CheckedChanged(object sender, EventArgs e)
        {
            if(!ckbxHamTreEm.Checked)
            {
                TatHamTreEm();
            }
            else
            {
                BatHamTreEm();
            }
        }
    }
}
