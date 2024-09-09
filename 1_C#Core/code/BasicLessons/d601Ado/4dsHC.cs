using System.Data;
using System.Data.SqlClient;
using System;

public class AdoDataSetClient{
// public static void  Main(string[] args){
// 	String strConnect ; 
// 	strConnect = "server=doit;database=northwind;uid=sa;pwd=sa"; 
// 	SqlConnection con = new SqlConnection(strConnect);
// 	String strSelect ; 
// 	strSelect = "select firstName,LastName from employees";
// 	SqlDataAdapter objDataAdapter = new SqlDataAdapter();
// 	DataTable dt=new DataTable();
// 	dt.TableName="Employee";
//  try{
// 	objDataAdapter.SelectCommand = new SqlCommand();
// 	objDataAdapter.SelectCommand .Connection=con;
// 	objDataAdapter.SelectCommand.CommandText=strSelect;
// 	objDataAdapter.Fill(dt);
// objDataAdapter=null;
// 	DataSet ds=new DataSet();
//       	ds.Tables.Add(dt);
//      	Console.WriteLine(dt.Rows[0][1]+" ");      	
//       	Console.WriteLine(ds.HasChanges().ToString());
//       	dt.Rows[0][1]=args[0];
//      	Console.WriteLine(dt.Rows[0][1]+" ");
//       	Console.WriteLine(ds.HasChanges().ToString()); 
// 	ds.RejectChanges();
// 	     	Console.WriteLine(dt.Rows[0][1]+" ");
// 	      	Console.WriteLine(ds.HasChanges().ToString()); 
// 	}catch (Exception objError) { Console.WriteLine(objError.Message);
//    }
// }
}