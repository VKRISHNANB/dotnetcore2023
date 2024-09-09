using System.Data;
using System;

public class AdoXMLReader{
public static void  TestAdoXMLReader(){
	DataSet objDataSet = new DataSet();
	DataTable dt=new DataTable();
 try{
	objDataSet.ReadXml("Emp.xml");
	objDataSet.ReadXmlSchema("Emp.xsd");
	dt=objDataSet.Tables["Employees"];
	int colCount=dt.Columns.Count;
	int rowCount=dt.Rows.Count;
	Console.WriteLine("Col Count: "+colCount);
	Console.WriteLine("Rol Count: "+rowCount);
	for (int i=0 ;i<rowCount ;i++){
	  for (int j=0 ;j<13 ;j++){
	     Console.Write(dt.Rows[i][j] +" ");
	  }   
	  Console.WriteLine();
	}
     }catch (Exception objError) { Console.WriteLine(objError); }
 }
}