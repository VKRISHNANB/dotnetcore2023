
using Oracle.ManagedDataAccess.Client;
public  class ORAConnectionFactory
{
    /** OracleConnection Factory */
    public static  OracleConnection GetConnection()
    {
        String db = "localhost//XE";            
         string sysUser = "system";
         string sysPwd = "Pass123$"; 
        OracleConnection cn = new OracleConnection();
        String conStringDBA = "User Id=" + sysUser + ";Password=" + sysPwd + ";Data Source=" + db + ";";
        cn.ConnectionString = conStringDBA;
        return cn;
    }
}

