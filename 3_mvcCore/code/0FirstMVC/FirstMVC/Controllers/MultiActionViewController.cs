using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace SampleA.Controllers
{
    public class MultiActionViewController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
      
    }
}