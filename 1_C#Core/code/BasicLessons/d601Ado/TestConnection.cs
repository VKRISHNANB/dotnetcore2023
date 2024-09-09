// dotnet add package Oracle.ManagedDataAccess.Core
using Oracle.ManagedDataAccess.Client;

public class OracleConnectionClient
{
    public static void TestConnected()
    {
        String strResult;
        String strSelect;
        strSelect = "select * from employees";
        OracleConnection con = null;
        OracleCommand cmd = null;
        OracleDataReader objDR=null;
        try
        {
            con = ORAConnectionFactory.GetConnection();
            con.Open();
            System.Console.WriteLine(con.State);
            cmd = new OracleCommand(strSelect, con);
            objDR = cmd.ExecuteReader();
            while (objDR.Read())
            {
                strResult = "  " + objDR[0] + " " + objDR[1];
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
}
