using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Aspmvcadoapp.Models;
namespace Aspmvcadoapp
{
    public class CustomerController : Controller
    {
         public CustomerController()
        {
           
        }
        public IActionResult Index()
        {
            List<Customer> clist = CustomerRepository.GetCustomerList();
            ViewBag.CustomerCount = clist.Count;
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
            try
            {
                if (!TryValidateModel(model))
                {
                    return View("Create");
                }
                CustomerRepository.AddNewCustomer(model);
            }
            catch (Exception err)
            {
                ViewBag.Error = err.Message;
                if (err.InnerException != null)
                    ViewBag.InnerError = err.InnerException.Message;
                return View("Create");
            }
            return RedirectToAction("Index");
        }
    }
}