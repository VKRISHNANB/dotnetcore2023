using System.Data;
using Microsoft.Data.SqlClient;
using System;
/*
To use ADO.NET functionalities in VS code we need to add the nuget package reference to 
Microsoft.Data.SqlClient. Open *.csproj file and put following code into it.
 <ItemGroup>
   <PackageReference Include="Microsoft.Data.SqlClient" Version="5.0.1" />
 </ItemGroup>
*/
namespace ADO
{
    public class AdoSQLConnectedClient
    {
        public static void TestConnected()
        {
           
            SqlConnection con = null;
            try
            {
                con = ADO.SQLConnectionFactory.GetNorthwindConnection();
                con.Open();
                Console.WriteLine(con.State);
            }
            catch (Exception objError)
            {
                Console.WriteLine("ERROR!!! " + objError.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void GetAllEmployees()
        {
            String strResult;
            String strSelect;
            strSelect = "select * from employees";
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader objDR = null;
            try
            {
                con = ADO.SQLConnectionFactory.GetNorthwindConnection();
                con.Open();
                cmd = new SqlCommand(strSelect, con);
                objDR = cmd.ExecuteReader();
                while (objDR.Read())
                {
                    strResult = "  " + objDR[0] + "  " + objDR[1] + "  " + objDR[2];
                    Console.WriteLine(strResult);
                }

            }
            catch (Exception objError)
            {
                Console.WriteLine("ERROR!!! " + objError.Message);
            }
            finally
            {
                objDR.Close();
                con.Close();
            }
        }
        public static void FindByID(int id)
        {
            String strResult;
            String strSelect;
            strSelect = "select * from employees where employeeid=@id";
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader objDR = null;
            try
            {
                con = ADO.SQLConnectionFactory.GetNorthwindConnection();
                con.Open();
                cmd = new SqlCommand(strSelect, con);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                objDR = cmd.ExecuteReader();
                while (objDR.Read())
                {
                    strResult = "  " + objDR[0] + "  " + objDR[1] + "  " + objDR[2];
                    Console.WriteLine(strResult);
                }

            }
            catch (Exception objError)
            {
                Console.WriteLine("ERROR!!! " + objError.Message);
            }
            finally
            {
                objDR.Close();
                con.Close();
            }
        }
        public static void Add(String fname,String lname)
        {
            String strInsert = "insert into employees(FirstName,LastName) values(@fname,@lname)";
            SqlConnection con = null;
            SqlCommand cmd = null;
            int result = 0;
            try
            {
                con = ADO.SQLConnectionFactory.GetNorthwindConnection();
                con.Open();
                cmd = new SqlCommand(strInsert, con);
                cmd.Parameters.Add("fname", SqlDbType.NVarChar).Value = fname;
                cmd.Parameters.Add("lname", SqlDbType.NVarChar).Value = lname;
                result = cmd.ExecuteNonQuery();
                Console.WriteLine("Result "+result);
            }
            catch (Exception objError)
            {
                Console.WriteLine("ERROR!!! " + objError.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void Modify(int id,String fname, String lname)
        {
            String strUpdate = "Update employees set FirstName=@fname,LastName=@lname where employeeid=@id";
            SqlConnection con = null;
            SqlCommand cmd = null;
            int result = 0;
            try
            {
                con = ADO.SQLConnectionFactory.GetNorthwindConnection();
                con.Open();
                cmd = new SqlCommand(strUpdate, con);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("fname", SqlDbType.Int).Value = fname;
                cmd.Parameters.Add("lname", SqlDbType.Int).Value = lname;
                result = cmd.ExecuteNonQuery();
                Console.WriteLine("Result " + result);
            }
            catch (Exception objError)
            {
                Console.WriteLine("ERROR!!! " + objError.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void Delete(int id)
        {
            String strDelete = "Delete from employees where employeeid=@id";
            SqlConnection con = null;
            SqlCommand cmd = null;
            int result = 0;
            try
            {
                con = ADO.SQLConnectionFactory.GetNorthwindConnection();
                con.Open();
                cmd = new SqlCommand(strDelete, con);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                result = cmd.ExecuteNonQuery();
                Console.WriteLine("Result " + result);
            }
            catch (Exception objError)
            {
                Console.WriteLine("ERROR!!! " + objError.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}