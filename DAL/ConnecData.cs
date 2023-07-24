using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnecData
    { 
        public static SqlConnection conncetion()
        {
            string get_cn_string = System.Configuration.ConfigurationManager.ConnectionStrings["connect_string"].ConnectionString;
            string conlink = get_cn_string;
            //string conlink = @"Data Source=LAPTOP-MFIH9F2J\SQLEXPRESS;Initial Catalog=QL_TS;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conlink);
            return conn;
        }
    }
}
