using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVienNhom
{
    public partial class Form2 : Form
    {
        BangDiemBLL bllBD;
        public Form2()
        {
            InitializeComponent();
            bllBD = new BangDiemBLL();
        }

        public void ShowallBD()
        {
            DataTable dt = bllBD.getallBangDiem();
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(labelMSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelMSV.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(labelMHP.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học phần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelMHP.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(labelDiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelDiem.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                BangDiem bd = new BangDiem();
                NhanVien nv = new NhanVien();
                SqlCommand cmd = new SqlCommand();
                nv.TENDN = Form1.SaveInf.TenDN;
                nv.MATKHAU = Form1.SaveInf.MatKhau;
                nv.MANV = bllBD.GetMaNV(nv);
                bd.MASV = txtMaSV.Text;
                bd.MAHP = txtMaHP.Text;
                bd.DIEMTHI = txtDiem.Text;
                if (bllBD.InsertBangDiem(bd, nv))
                {
                    ShowallBD();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowallBD();
        }

    } 
}
