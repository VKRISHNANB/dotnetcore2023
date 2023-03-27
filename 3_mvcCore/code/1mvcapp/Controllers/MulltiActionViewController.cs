using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace SampleA.Controllers
{
    public class MulltiActionViewController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChildList()
        {
            return View();
        }
        public ActionResult Display(string section)
        {
            ViewData.Add("data1", section);
            return View();
        }
    }
}