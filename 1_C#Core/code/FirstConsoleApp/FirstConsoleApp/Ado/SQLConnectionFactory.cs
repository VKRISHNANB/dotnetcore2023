using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
namespace ADO
{
    public static class SQLConnectionFactory
    {
        /** SQLConnection Factory */
        public static SqlConnection GetSampleConnection()
        {
            String strConnect = @"Data Source=BVKASUS2022\SQLEXPRESS;Initial Catalog=Sample;Integrated Security=True;encrypt=false";             
           // String strConnect = @"Data Source=BVKASUS2022\SQLEXPRESS;Initial Catalog=Sample;User=sa;Password=Pass123$;encrypt=false";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = strConnect;
            return cn;
        }
         public static  SqlConnection GetNorthwindConnection()
        {
            String strConnect = "Data Source=BVKASUS2022\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI;encrypt=false";             
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = strConnect;
            return cn;
        }

    }
}
