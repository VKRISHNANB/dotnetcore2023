using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class DacController : Controller
    {
        private readonly ILogger<DacController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IDAC _dao;

        //public DacController(ILogger<DacController> logger, IConfiguration config)
        //{
        //    _logger = logger;
        //    _configuration = config;
        //}
        public DacController(ILogger<DacController> logger, IConfiguration config, DataAccessControl dac)
        {
            _logger = logger;
            _configuration = config;
            _dao = dac;
        }

        public IActionResult Index()
        {
            string conString =_configuration.GetConnectionString("DefaultConnection");
            ViewData["conString"] = conString;
            _dao.Run();
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
