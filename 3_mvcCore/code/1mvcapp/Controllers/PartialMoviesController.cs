using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace SampleA.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Start()
        {
            return View();
        }
    }
}