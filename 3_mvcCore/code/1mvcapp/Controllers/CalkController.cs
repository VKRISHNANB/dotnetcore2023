using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace SampleA.Controllers
{
    public class CalkController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: /Calk/Add?x=50&y=10
        public ActionResult Add(int x,int y)
        {
            int result = x + y;
            ViewData.Add("Result", "Add:"+result);
            return View("CalkResult");
        }
        // GET: /Calk/Multiply?x=50&y=10
        public ActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData.Add("Result", "Multiply:" + result);
            return View("CalkResult");
        }
        // GET: /Calk/Divide?x=50&y=10
        public ActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData.Add("Result", "Divide:" + result);
            return View("CalkResult");
        }
        // GET: /Calk/Substract?x=50&y=10
        public ActionResult Substract(int x, int y)
        {
            int result = x - y;
            ViewData.Add("Result", "Substract:" + result);
            return View("CalkResult");
        }

    }
}