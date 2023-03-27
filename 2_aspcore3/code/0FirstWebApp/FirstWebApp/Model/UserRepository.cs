using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace FirstWebApp.Model
{
    public class UserRepository
    {
        public User GetUser(String name, String pwd)
        {
            User user = null;
            SqlConnection cn = new SqlConnection();
            SqlCommand selectcmd = null;
            SqlDataReader userDR = null;
            try
            {
                cn.ConnectionString = @"Data Source=BVKASUS2022\SQLEXPRESS;Initial Catalog=sample;integrated security=true;encrypt=false"; ;
                cn.Open();
                selectcmd = cn.CreateCommand();
                selectcmd.CommandText = "Select * from Members where name=@name and password=@pwd";
                selectcmd.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
                selectcmd.Parameters.Add("pwd", SqlDbType.NVarChar).Value = pwd;
                userDR = selectcmd.ExecuteReader();
                if(userDR.Read())
                {
                    user = new User
                    {
                        Name = userDR.GetString(1),
                        Password = userDR.GetString(2)
                    };
                }
            }
            finally
            {
                if (userDR != null) userDR.Close();
                if (cn != null)
                {
                    if(cn.State==ConnectionState.Open)
                        cn.Close();
                }
            }
            return user;
        }
    }
}
