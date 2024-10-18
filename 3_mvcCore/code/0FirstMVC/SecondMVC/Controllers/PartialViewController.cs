using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace SampleA.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good friends";
            return View();
        }
    }
}