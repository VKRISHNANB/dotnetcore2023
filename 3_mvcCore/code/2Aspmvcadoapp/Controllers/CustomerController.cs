using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
namespace Aspmvcadoapp
{
    public class CustomerController : Controller
    {
         public CustomerController()
        {
           
        }
        public IActionResult Index()
        {
            var connString = @"server=VENKATHPDESKTOP\SQLEXPRESS;database=Sample;integrated security=true";
            SqlConnection cn=new SqlConnection(connString);
            cn.Open();
            ViewBag.Connextionstate=cn.State;
            SqlCommand selectcustomercmd=cn.CreateCommand();
            selectcustomercmd.CommandText="Select * from customer";
            List<Customer> clist=new List<Customer>();
            SqlDataReader customerdr=selectcustomercmd.ExecuteReader();
            
            while(customerdr.Read())
            {
                Customer c=new Customer{
                    Id=customerdr.GetInt32(0),
                    Name=customerdr.GetString(1),
                    EmailAddress=customerdr.GetString(2),
                    Salary=customerdr.GetDecimal(3)
                };
                clist.Add(c);
            }
            return View(clist);
        }
        [HttpGet]
        public IActionResult Create()
        {
          
          return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer model)
        {
            //TODO: Implement Realistic Implementation
            return RedirectToAction("Index");
        }
    }
}