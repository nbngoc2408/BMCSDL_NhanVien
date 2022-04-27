using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVienNhom
{

    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source=LAPTOP-5RJTUDEG;Initial Catalog=QLSVNhom;Integrated Security=True";
        }

        public SqlConnection GetConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
