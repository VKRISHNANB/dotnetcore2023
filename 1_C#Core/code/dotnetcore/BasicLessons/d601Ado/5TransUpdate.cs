using System.Data;
using System.Data.SqlClient;
using System;

public class AdoSQLTransClient{
// public static void  Main(String[] args){
// 	String strConnect ; 
// 	strConnect = "server=doit;database=northwind;uid=sa;pwd=sa"; 
// 	String strSelect ; 
// 	strSelect = "select * from employees";
// SqlDataAdapter objDataAdapter;
// DataTable dt;
// 	 objDataAdapter= new SqlDataAdapter();
// 	dt=new DataTable();
// 	SqlTransaction trans=null;
// 	SqlConnection con =null;
//  try{
// 	con= new SqlConnection(strConnect);
// 	objDataAdapter.SelectCommand = new SqlCommand();
// 	objDataAdapter.SelectCommand.Connection=con;
// 	objDataAdapter.SelectCommand.CommandText=strSelect;
	
// 	objDataAdapter.Fill(dt);
// 	 	DataSet ds=new DataSet();
//       	ds.Tables.Add(dt);
//      	Console.WriteLine(dt.Rows[0][1]+" ");      	
//       	Console.WriteLine(ds.HasChanges().ToString());
//    	dt.Rows[0][1]=args[0];
//      	Console.WriteLine(dt.Rows[0][1]+" ");      	
//       	Console.WriteLine(ds.HasChanges().ToString());
	
// con.Open();
// trans=con.BeginTransaction();
// objDataAdapter.SelectCommand.Transaction=trans;
// SqlCommandBuilder cb=new SqlCommandBuilder(objDataAdapter);
// cb.QuotePrefix ="[";
// cb.QuoteSuffix="]"; 
// objDataAdapter.UpdateCommand = cb.GetUpdateCommand();
// objDataAdapter.InsertCommand = cb.GetInsertCommand();
// objDataAdapter.DeleteCommand = cb.GetDeleteCommand();
// objDataAdapter.Update(dt);
// 	//trans.Rollback();//
// 	trans.Commit();
//      	Console.WriteLine("After Update "+dt.Rows[0][1]+" ");      	
//       	Console.WriteLine(ds.HasChanges().ToString());

//   }catch (Exception objError) { 
//   	trans.Rollback();
//         Console.WriteLine(objError.Message);}
// }
// finally{
// 	con.Close();
// }
}