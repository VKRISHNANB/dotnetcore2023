using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FirstMVC.Models
{
    public class SqlHelper
    {
        public static String GetConnectionString()
        {
            var connString = @"server=DESKTOP-LSEVB9U;database=Sample;
                                integrated security=true;Encrypt=false;";
            return connString;
        }
        public static SqlConnection CreateConnection()
        {
           
            SqlConnection sqlcn = new SqlConnection(GetConnectionString());
            return sqlcn;
        }
    }
}
