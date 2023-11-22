using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa
{
    public class KiemTraLoi
    {
        KetNoiDuLieu kndl = new KetNoiDuLieu();

        public void TrungLap(string sqlQuery, int doDai, string errorInfo, ref bool haveError, ErrorProvider erp, TextBox txt, SqlConnection conn)
        {
            try
            {
                kndl.KiemTraKetNoi(conn);
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                int iDem = (int)cmd.ExecuteScalar();
                if (txt.TextLength == doDai)
                {
                    if (iDem > 0)
                    {
                        erp.SetError(txt, errorInfo);
                        txt.Focus();
                        haveError = true;
                    }
                    else
                    {
                        erp.SetError(txt, "");
                    }
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

        public void TrungLap(string sqlQuery, string errorInfo, ref bool haveError, ErrorProvider erp, TextBox txt, SqlConnection conn)
        {
            try
            {
                kndl.KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                int iDem = (int)cmd.ExecuteScalar();

                if (txt.Text != "")
                {
                    if (iDem > 0)
                    {
                        erp.SetError(txt, errorInfo);
                        txt.Focus();
                        haveError = true;
                    }
                    else
                    {
                        erp.SetError(txt, "");
                    }
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

        public void Rong(string errorInfo, ref bool haveErrror, ErrorProvider erp, TextBox txt)
        {
            if (txt.Text == "")
            {
                erp.SetError(txt, errorInfo);
                haveErrror = true;
                txt.Focus();
            }
            else
            {
                erp.SetError(txt, "");
            }
        }
        

        public void DoDai(string errorInfo, int doDai, ref bool haveErrror, ErrorProvider erp, TextBox txt)
        {
            if(txt.TextLength > 0)
            {
                if (txt.TextLength != doDai)
                {
                    erp.SetError(txt, errorInfo);
                    haveErrror = true;
                    txt.Focus();
                }
                else
                {
                    erp.SetError(txt, "");
                }
            }                      
        }

        bool Xoa(string sql, SqlConnection conn)
        {
            bool canDelete = true;
            try
            {
                kndl.KiemTraKetNoi(conn);
                SqlCommand cmd = new SqlCommand(sql, conn);
                int iDem = (int)cmd.ExecuteScalar();
                if(iDem >0)
                {
                    canDelete = false;
                }    
                else
                {
                    canDelete = true;
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
            return canDelete;

        }

        public string ThongTinXoa(string sql, string relative, SqlConnection conn)
        {
            string strRelative = "";

            bool canDelete = Xoa(sql, conn);

            if(canDelete == false)
            {
                strRelative = relative;
            }

            return strRelative;
        }
    }
}
