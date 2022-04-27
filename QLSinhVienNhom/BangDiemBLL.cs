using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienNhom
{
    class BangDiemBLL
    {
        BangDiemDAL dalBD;
        public BangDiemBLL()
        {
            dalBD = new BangDiemDAL();
        }

        public DataTable getallBangDiem()
        {
            return dalBD.getallBangDiem();
        }

        public bool InsertBangDiem(BangDiem bd, NhanVien nv)
        {
            return dalBD.InsertBangDiem(bd, nv);
        }

        public string GetMaNV(NhanVien nv)
        {
            return dalBD.GetMaNV(nv);
        }
    }
}
