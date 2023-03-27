using System.Data;
using System.Data.SqlClient;
using System;

public class AdoSQLUpdateClient{
    public static void  TestAdoSQLUpdate(){
           SqlConnection con = ADOConnected.SQLConnectionFactory.GetNorthwindConnection();
            String strSelect ; 
            strSelect = "select * from employees";
        SqlDataAdapter objDataAdapter;
        DataTable dt;
            objDataAdapter= new SqlDataAdapter();
            dt=new DataTable();
        try{
            objDataAdapter.SelectCommand = new SqlCommand();
            objDataAdapter.SelectCommand.Connection=con;
            objDataAdapter.SelectCommand.CommandText=strSelect;
            objDataAdapter.Fill(dt);
            DataSet ds=new DataSet();
            ds.Tables.Add(dt);
            Console.WriteLine(dt.Rows[0][1]+" ");      	
            Console.WriteLine(ds.HasChanges().ToString());
            dt.Rows[0][1]="Venkat";
                Console.WriteLine(dt.Rows[0][1]+" ");      	
                Console.WriteLine(ds.HasChanges().ToString());

        SqlCommandBuilder cb=new SqlCommandBuilder(objDataAdapter);
        cb.QuotePrefix ="[";
        cb.QuoteSuffix="]"; 
        objDataAdapter.UpdateCommand = cb.GetUpdateCommand();
        objDataAdapter.InsertCommand = cb.GetInsertCommand();
        objDataAdapter.DeleteCommand = cb.GetDeleteCommand();

        objDataAdapter.Update(dt);
                Console.WriteLine("After Update "+dt.Rows[0][1]+" ");      	
                Console.WriteLine(ds.HasChanges().ToString());

        }catch (Exception objError) { Console.WriteLine(objError.Message);}
    }
}