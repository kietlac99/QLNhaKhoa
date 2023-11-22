using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QLNhaKhoa
{
    class TienIch
    {
        public void PhanNghin(TextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                try
                {
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

                    double valueBefore = double.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);

                    txt.Text = String.Format(culture, "{0:N0}", valueBefore);

                    txt.Select(txt.Text.Length, 0);
                }
                catch (Exception)
                {

                }

            }
            else
            {
                txt.Text = "0";
            }


        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }

                
            }
        }

        public void TrimTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = ctrl.Text.Trim();
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        public  void TachTen(TextBox tbName, ref string ho, ref string tenlot, ref string ten)
        {
            string fullName = tbName.Text.ToString();

            var names = fullName.Split(' ');

            if (names.Length == 1)
            {
                ten = names[0];
            }
            else if (names.Length == 2)
            {
                ho = names[0];
                ten = names[1];
            }
            else if (names.Length == 3)
            {
                ho = names[0];
                tenlot = names[1];
                ten = names[2];
            }
            else
            {
                ho = names[0];
                ten = names[names.Length - 1];
                for (int i = 1; i < names.Length - 1; i++)
                {
                    if (i == names.Length - 2)
                    {
                        tenlot += names[i];
                    }
                    else
                    {
                        tenlot += names[i] + " ";
                    }
                }
            }
        }

        private readonly string[] VietnameseSigns = new string[]

   {

        "aAeEoOuUiIdDyY",

        "áàạảãâấầậẩẫăắằặẳẵ",

        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

        "éèẹẻẽêếềệểễ",

        "ÉÈẸẺẼÊẾỀỆỂỄ",

        "óòọỏõôốồộổỗơớờợởỡ",

        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

        "úùụủũưứừựửữ",

        "ÚÙỤỦŨƯỨỪỰỬỮ",

        "íìịỉĩ",

        "ÍÌỊỈĨ",

        "đ",

        "Đ",

        "ýỳỵỷỹ",

        "ÝỲỴỶỸ"

   };
       

        public string RemoveSign4VietnameseString(string str)

        {

            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi

            for (int i = 1; i < VietnameseSigns.Length; i++)

            {

                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);

            }

            return str;

        }

        public void QuyenThaoTac(string thaoTac, Button btn)
        {
            if (thaoTac != "True")
            {
                btn.Enabled = false;
            }
        }

        public void OpenForm(ref Form activeForm, Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            try
            {
                form.Show();
            }
            catch (Exception)
            {
                form.Show();
            }
            
        }

        public void OpenForm_2(ref Form activeForm, Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;


            try
            {
                form.ShowDialog();
            }
            catch (Exception)
            {
                form.ShowDialog();
            }

        }

        public void RowsColor(string dateColumn, Timer timer, DataGridView dgv)
        {
            DateTime ngay;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(dgv.Rows[i].Cells[dateColumn].Value.ToString()))
                {
                    ngay = DateTime.Parse(DateTime.Parse(dgv.Rows[i].Cells[dateColumn].Value.ToString()).ToString("dd-MM-yyyy"));

                    if (ngay.ToString("dd-MM-yyyy") == DateTime.Today.ToString("dd-MM-yyyy"))
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                        timer.Start();
                    }
                    else if (ngay.ToString("dd-MM-yyyy") == DateTime.Today.AddDays(1).ToString("dd-MM-yyyy"))
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (ngay.ToString("dd-MM-yyyy") != DateTime.Today.ToString("dd-MM-yyyy"))
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        public void Timer_Tick(string dateColumn, DataGridView dgv)
        {
            DateTime ngay;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(dgv.Rows[i].Cells[dateColumn].Value.ToString()))
                {
                    ngay = DateTime.Parse(DateTime.Parse(dgv.Rows[i].Cells[dateColumn].Value.ToString()).ToString("dd-MM-yyyy"));

                    if (ngay.ToString("dd-MM-yyyy") == DateTime.Today.ToString("dd-MM-yyyy"))
                    {
                        if (dgv.Rows[i].DefaultCellStyle.BackColor == Color.Red)
                        {
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else if (dgv.Rows[i].DefaultCellStyle.BackColor == Color.White)
                        {
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            dgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
        }
    }


}
