using System.Data;
using System.Data.SqlClient;
using System;

public class AdoSQLDisconnectedClient{
 public static void  TestAdoSQLDisconnectedClient(){
	SqlConnection con = ADOConnected.SQLConnectionFactory.GetNorthwindConnection();
	String strSelect ; 
	strSelect = "select firstName,LastName from employees";
	SqlDataAdapter objDataAdapter = new SqlDataAdapter();
	DataTable dt=new DataTable();
	dt.TableName="Employee";
    try{
        objDataAdapter.SelectCommand = new SqlCommand();
        objDataAdapter.SelectCommand .Connection=con;
        objDataAdapter.SelectCommand.CommandText=strSelect;
        objDataAdapter.Fill(dt);
        Console.WriteLine("Conn State : " + con.State.ToString());
        objDataAdapter=null;

        int colCount=dt.Columns.Count;
        int rowCount=dt.Rows.Count;
        Console.WriteLine("Col Count: "+colCount);
        Console.WriteLine("Rol Count: "+rowCount);
        for (int i=0 ;i<rowCount ;i++){
            for (int j=0 ;j<2 ;j++){
                    Console.Write(dt.Rows[i][j] +" ");
            }
            Console.WriteLine();
            }
     }catch (Exception objError) { Console.WriteLine(objError.Message);
   }
 }
}