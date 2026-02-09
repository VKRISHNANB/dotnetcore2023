using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ASPWebAPIDemoA.Models;
using Microsoft.AspNetCore.Cors;

namespace ASPWebAPIDemoA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        readonly SampleContext _dbcontext;
        public CustomerController(SampleContext context,ILogger<CustomerController> logger)
        {
            _dbcontext=context;
             _logger = logger;
        }
        public IEnumerable<Customer> Index()
        {
            var allcustomers=_dbcontext.Customer.ToList();
            return allcustomers;
        }
#region InsertUpdateDelete        
        // POST: Customer/Create
        // [HttpPost]
        // public ActionResult AddCustomer(Customer newcustomer)
        // {
        //     _dbcontext.Customer.Add(newcustomer);
        //     _dbcontext.SaveChanges();
        //     return RedirectToAction("Index");
        // }
        // // POST: Customer/Edit/5
        // [HttpPost]
        // public ActionResult Edit(int id, Customer customer)
        // {
        //         Customer c1=_dbcontext.Customer.Find(id);
        //         TryUpdateModelAsync(c1);
        //        // _dbcontext.Entry(c1).State = EntityState.Unchanged;
        //         _dbcontext.SaveChanges();
        //         return RedirectToAction("Index");
        // }
        // // POST: Customer/Delete/5
        // [HttpPost]
        // public ActionResult Delete(int id,  Customer customer)
        // {
        //     Customer c1=_dbcontext.Customer.Find(id);
        //     _dbcontext.Customer.Remove(c1);
        //     _dbcontext.SaveChanges();
        //     return RedirectToAction("Index");
        // }
        #endregion
    }
}