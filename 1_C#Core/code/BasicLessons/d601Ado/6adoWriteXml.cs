using System.Data;
using System.Data.SqlClient;
using System;

public class AdoXMLWritter{
// public static void  Main(){
// 	String strConnect ; 
// 	strConnect = "server=doit;database=northwind;uid=sa;pwd=sa"; 
// 	String strSelect ; 
// 	strSelect = "select Employeeid,firstname,lastname from employees";
// 	SqlDataAdapter objDataAdapter = new SqlDataAdapter();
// 	DataTable dt=new DataTable();
//  try{
// 	SqlConnection con = new SqlConnection(strConnect);
// 	objDataAdapter.SelectCommand = new SqlCommand();
// 	objDataAdapter.SelectCommand .Connection=con;
// 	objDataAdapter.SelectCommand.CommandText=strSelect;
// 	objDataAdapter.Fill(dt);

// DataSet objDataSet=new DataSet();
// dt.TableName="Employees";
// objDataSet.Tables.Add(dt);
// objDataSet.WriteXml("Emp.xml");
// objDataSet.WriteXmlSchema("Emp.xsd");
// Console.WriteLine("XML created");
//       }catch (Exception objError) { Console.WriteLine(objError.Message);
//    }
// }
}