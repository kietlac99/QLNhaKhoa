using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaKhoa
{
    class KetNoiDuLieu
    {
        public void KiemTraKetNoi(SqlConnection conn)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }    
        }

        public void VaoComboBox(string ketNoiBang, ComboBox cbx, string valueMember, string displayMember, SqlConnection conn)
        {
            KiemTraKetNoi(conn);
            var bindingSource = new BindingSource();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(ketNoiBang, conn))
            {
                try
                {
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;
                    cbx.DataSource = bindingSource;
                    cbx.ValueMember = valueMember;
                    cbx.DisplayMember = displayMember;                
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    conn.Close();
                }
              
            }
        }

        public void VaoComboBox_2(string ketNoiBang, ComboBox cbx, string valueMember, string displayMember, string firstItem, SqlConnection conn)
        {
            KiemTraKetNoi(conn);

            var bindingSource = new BindingSource();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(ketNoiBang, conn))
            {
                try
                {
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    DataTable table = new DataTable();

                    dataAdapter.Fill(table);

                    bindingSource.DataSource = table;

                    cbx.DataSource = bindingSource;
                    cbx.ValueMember = valueMember;
                    cbx.DisplayMember = displayMember;

                    DataRow topItem = table.NewRow();

                    try
                    {
                        if (valueMember != displayMember)
                        {
                            topItem[0] = 0;
                            topItem[1] = firstItem;
                        }
                        else
                        {
                            topItem[0] = firstItem;
                        }
                        table.Rows.InsertAt(topItem, 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void ThucThiDuLieu_KhongTraVe(string str, SqlConnection conn)
        {

            try
            {
                KiemTraKetNoi(conn);
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
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


        public void KetNoiDataGridView(string ketNoiBang, DataGridView dgv, SqlConnection conn)
        {
            KiemTraKetNoi(conn);
            var bindingSource = new BindingSource();
            
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(ketNoiBang, conn))
            {
                try
                {
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;
                    //dgv.ReadOnly = true;
                    dgv.DataSource = bindingSource;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error Loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        public void ActionLoad(SqlConnection conn)
        {
            string ID_User = fDangNhap.ID_User;

            string sql = "exec SP_HanhDong_MaTK '" + ID_User + "'";

            try
            {
                KiemTraKetNoi(conn);

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader rd = cmd.ExecuteReader();
                int i = 0;
                while (rd.Read())
                {
                    fDangNhap.arrThem[i] = rd["Them"].ToString();
                    fDangNhap.arrSua[i] = rd["Sua"].ToString();
                    fDangNhap.arrXoa[i] = rd["Xoa"].ToString();
                    fDangNhap.arrIn[i] = rd["Inn"].ToString();
                    fDangNhap.arrTimKiem[i] = rd["TimKiem"].ToString();
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
        }
    }
}
