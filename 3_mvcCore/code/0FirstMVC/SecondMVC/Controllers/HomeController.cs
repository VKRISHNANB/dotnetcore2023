using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspFirstMVCCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace AspFirstMVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Menu()
        {
            _logger.Log(LogLevel.Information, "Testing");
            return View();
        }
        public IActionResult Index()
        {
           
            return View();
        }
        // Method Overload
        [HttpPost]
        public ActionResult Index(int x,IFormCollection collection)
        {
            StringBuilder data=new StringBuilder(500);
            data.Append("x:");
            data.Append(x);
            data.Append(" ");
            data.Append("name:");
            data.Append(collection["name"]);
            data.Append(" ");
            data.Append("password:");
            data.Append(collection["password"]);
            //foreach (var item in collection)
            //{
            //    data.Append(item.Key);
            //    data.Append(":");
            //    data.Append(item.Value);
            //    data.Append(" ");
            //}
            ViewData["x"] = data.ToString();
            return View("IndexPost");
        }
        
        public ActionResult DoTask(int? x)
        {
            if(x.HasValue)
            {
                ViewData["id"]=x.Value;
            }
            else
            {
                ViewData["id"] = 0;
            }
            return View();
        }
        // Redirect to Action
        public ActionResult Test()
        {
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Start()
        {
            return View("StartForm");
        }
       
        public ActionResult Echo(String name, String city)
        {
            String s1 = "user " + name + " from City=" + city;
            ViewData.Add("Data1", s1);
            return View();
        }
        public ActionResult SayHello(String name)
        {
            //Home/SayHello?name=Venkat
            String s1 = ("Hello " + name);
            ViewData.Add("Data1", s1);
            return View("Echo");
        }
        /* Passing an Object to ViewData*/
        public IActionResult GetBook()
        {
            Book b1 = new Book() { AuthorName = "H Lee" };
            ViewData["book"] = b1;
            return View();
        }

        [ResponseCache(Duration = 15)]
        public IActionResult GetTime()
        {
            String todate = DateTime.Now.ToLongTimeString();
            ViewData["date"] = todate;
            return View();
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
