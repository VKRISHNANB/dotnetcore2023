using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace FirstMVC
{
    public class CustomerController : Controller
    {
        readonly SampleContext _dbcontext;
        //List<Customer> clist = new List<Customer>();
        public CustomerController(SampleContext context)
        {
            _dbcontext=context;
        }
        public IActionResult Index()
        {
            //clist[0] = new Customer();
            var allcustomers=_dbcontext.Customer.ToList();
            return View(allcustomers);
        }
        public IActionResult Create()
        {            
            return View(new Customer());
        }
        // POST: Customer/Create
        [HttpPost]
        public ActionResult AddCustomer(Customer newcustomer)
        {
            try
            {
               if(! TryValidateModel(newcustomer))
                {
                    return View("Create");
                }
                _dbcontext.Customer.Add(newcustomer);
                _dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception err)
            {
                ViewBag.Error=err.Message;
                if(err.InnerException!=null)
                    ViewBag.InnerError=err.InnerException.Message;
                return View("Create");
            }
        }
        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            Customer c1 = (from c in _dbcontext.Customer 
            where c.Id ==id
            select c).First();
            return View(c1);
        }
        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                Customer c1=_dbcontext.Customer.Find(id);
                TryUpdateModelAsync(c1);
               // _dbcontext.Entry(c1).State = EntityState.Unchanged;
                _dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
           catch(Exception err)
            {
                ViewBag.Error=err.Message;
                if(err.InnerException!=null)
                    ViewBag.InnerError=err.InnerException.Message;
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            Customer c1 = (from c in _dbcontext.Customer 
            where c.Id ==id
            select c).First();
            return View(c1);
        }
         
        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            Customer c1 = (from c in _dbcontext.Customer 
            where c.Id ==id
            select c).First();
            return View(c1);
        }
        
        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,  Customer customer)
        {
            try
            {
                Customer c1=_dbcontext.Customer.Find(id);
                _dbcontext.Customer.Remove(c1);
                _dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
             catch(Exception err)
            {
                ViewBag.Error=err.Message;
                if(err.InnerException!=null)
                    ViewBag.InnerError=err.InnerException.Message;
                return View();
            }
        }
 
       
    }
}