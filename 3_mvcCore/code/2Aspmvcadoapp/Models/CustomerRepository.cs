using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
namespace Aspmvcadoapp.Models
{
    public class CustomerRepository
    {
        public static List<Customer> GetCustomerList()
        {
            List<Customer> clist = new List<Customer>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectcustomercmd = cn.CreateCommand();
                String selectAllCustomers = "Select * from customer";
                selectcustomercmd.CommandText = selectAllCustomers;
                SqlDataReader customerdr = selectcustomercmd.ExecuteReader();
                while (customerdr.Read())
                {
                    Customer c = new Customer
                    {
                        Id = customerdr.GetInt32(0),
                        Name = customerdr.GetString(1),
                        EmailAddress = customerdr.GetString(2),
                        Salary = customerdr.GetDecimal(3)
                    };
                    clist.Add(c);
                } 
            }
            return clist;
        }
    public static int AddNewCustomer(Customer newCustomer)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertCustomercmd = cn.CreateCommand();
                String insertNewCustomerQuery = "insert into customer values( @id,@name,@emailAddress,@salary )";
                insertCustomercmd.Parameters.Add("@id", SqlDbType.Int).Value = newCustomer.Id;
                insertCustomercmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newCustomer.Name;
                insertCustomercmd.Parameters.Add("@emailAddress", SqlDbType.NVarChar).Value = newCustomer.EmailAddress;
                insertCustomercmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newCustomer.Salary;
                insertCustomercmd.CommandText = insertNewCustomerQuery;
                query_result = insertCustomercmd.ExecuteNonQuery();               
            }
            return query_result;
        }
    }
}
