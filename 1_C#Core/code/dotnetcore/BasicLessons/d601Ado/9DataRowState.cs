using System;
using System.Data;
public class DataTableDemo{
private static void TestDataTableDemo() {
   //Run a function to create a DataTable with one column.
   DataTable myTable = MakeTable();
   DataRow myRow;

   // Create a new DataRow.
   myRow = myTable.NewRow();
   // Detached row.
   Console.WriteLine("New Row " + myRow.RowState);

   myTable.Rows.Add(myRow);
   // New row.
   Console.WriteLine("AddRow " + myRow.RowState);

   myTable.AcceptChanges();
   // Unchanged row.
   Console.WriteLine("AcceptChanges " + myRow.RowState);

   myRow["FirstName"] = "Scott";
   // Modified row.
   Console.WriteLine("Modified " + myRow.RowState);

   myRow.Delete();
   // Deleted row.
   Console.WriteLine("Deleted " + myRow.RowState);
}

private static DataTable MakeTable(){
   // Make a simple table with one column.
   DataTable dt = new DataTable("myTable");
   DataColumn dcFirstName = new DataColumn("FirstName", Type.GetType("System.String"));
   dt.Columns.Add(dcFirstName);
   return dt;
}
}