using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-H7QDFO7\SQLEXPRESS;Initial Catalog=QLBTS;Integrated Security=True");

    }
}
