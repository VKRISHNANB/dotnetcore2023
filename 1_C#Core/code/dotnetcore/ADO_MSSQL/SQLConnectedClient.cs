using System.Data;
using Microsoft.Data.SqlClient;
using System;

/*
To use ADO.NET functionalities in VS code we need to add the nuget package reference toSystem.Data.SqlClient. Open *.csproj file and put following code into it.
<PackageReference Include="System.Data.SqlClient" Version="4.6.0" />
*/
public class AdoSQLConnectedClient
{
    public static void TestConnection()
    {
        String strResult;
        String strSelect;
        strSelect = "select * from employees";
        try
        {
            SqlConnection con = ADOConnected.SQLConnectionFactory.GetNorthwindConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(strSelect, con);
            SqlDataReader objDR;
            objDR = cmd.ExecuteReader();
            while (objDR.Read())
            {
                strResult = "  " + objDR[1];
                Console.WriteLine(strResult);
            }
            objDR.Close();
            con.Close();
        }
        catch (Exception objError)
        {
            Console.WriteLine("ERROR!!! " + objError.Message);
        }
    }
}
