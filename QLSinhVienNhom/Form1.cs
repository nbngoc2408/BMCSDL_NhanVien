using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienNhom
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=LAPTOP-5RJTUDEG;Initial Catalog=QLSVNhom;Integrated Security=True";
        SqlConnection sqlConn = null;
        public Form1()
        {
            InitializeComponent();
        }

        public class SaveInf
        {
            static public string TenDN;
            static public string MatKhau;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn = new SqlConnection(strcon);
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                {
                    sqlConn.Open();
                }
                NhanVien nv = new NhanVien();
                string acc = txtTaiKhoan.Text;
                SaveInf.TenDN = txtTaiKhoan.Text;
                //TenDangNhap = txtTaiKhoan.Text;
                string pass = txtMatKhau.Text;
                SaveInf.MatKhau = txtMatKhau.Text;
                string passCT = MH.toSHA1(pass).ToUpper();
                string querry = "select * from NHANVIEN where TENDN = '" + acc + "' and convert(varchar(max),MATKHAU,1) = '0x" + passCT + "'";
                SqlCommand cmd = new SqlCommand(querry, sqlConn);
                SqlDataReader data = cmd.ExecuteReader();
                bool result = data.Read();
                data.Close();
                cmd.Cancel();
                if (result == true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối không thành côngxyz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    public static class MH
    {
        public static string toSHA1(string str)
        {
            string result = "";
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            SHA1CryptoServiceProvider SHA1 = new SHA1CryptoServiceProvider();
            buffer = SHA1.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                result += buffer[i].ToString("x2");
            }

            return result;
        }
    }
}
