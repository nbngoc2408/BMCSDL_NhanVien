using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVienNhom
{
    class BangDiemDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;

        public BangDiemDAL()
        {
            dc = new DataConnection();
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


         public DataTable getallBangDiem()
        {
            //string sql = "select MASV, MAHP, convert(varchar(max), DIEMTHI, 1) as DIEMTHI from BANGDIEM";
            //string sql = "select MASV, MAHP, DIEMTHI from BANGDIEM";
            //SqlConnection con = dc.GetConnect();
            //da = new SqlDataAdapter(sql, con);
            //con.Open();
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();
            //return dt;

            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = "Select_BangDiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@TenDN", SqlDbType.VarChar).Value = Form1.SaveInf.TenDN;
                cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = Form1.SaveInf.MatKhau;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                con.Close();
            }
            catch (Exception ex)
            {
                return dt;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool InsertBangDiem(BangDiem bd, NhanVien nv)
        {
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand();
            try
            {
                cmd.CommandText = "SP_InsertBangDiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = bd.MASV;
                cmd.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = bd.MAHP;
                int Diem = Convert.ToInt32(bd.DIEMTHI);
                cmd.Parameters.Add("@Diem", SqlDbType.Int).Value = Diem;
                cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nv.MANV;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public string GetMaNV(NhanVien nv)
        {
            
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand();
            try
            {
                cmd.CommandText = "select PUBKEY " +
                    "from NHANVIEN " +
                    "where TENDN = @TenDN and MATKHAU = CONVERT(varbinary, HASHBYTES('SHA1', @MatKhau))";
                cmd.Connection = con;
                cmd.Parameters.Add("@TenDN", SqlDbType.VarChar).Value = nv.TENDN;
                cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = nv.MATKHAU;
                con.Open();
                var result = cmd.ExecuteScalar();
                con.Close();
                return result.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
