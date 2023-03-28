using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Aspmvcadoapp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=BVKASUS2022\SQLEXPRESS;database=Sample;integrated security=true";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
