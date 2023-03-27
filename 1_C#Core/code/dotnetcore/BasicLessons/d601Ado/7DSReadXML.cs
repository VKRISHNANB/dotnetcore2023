using System.Data;
using System;

public class AdoXMLClient{
public static void  RunAdoXMLClient(){
	DataSet ds = new DataSet();
 try{
	ds.ReadXmlSchema("emp.xsd");
	ds.ReadXml("emp.xml");
	//DataGrid1.DataSource=ds;
	for (int i=0 ;i<8 ;i++){
	   Console.Write(ds.Tables[0].Rows[i][1]+" ");
	   Console.WriteLine(ds.Tables[0].Rows[i][2]);
	}
     }catch (Exception objError) { Console.WriteLine(objError); }
 }
}