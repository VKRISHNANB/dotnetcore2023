using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace FirstMVC.Models
{
    public class DataAccessControl:IDAC
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<DataAccessControl> _logger;

        public DataAccessControl(ILogger<DataAccessControl> logger,IConfiguration config)
        {
            _logger = logger;
            _configuration= config;
        }
        public void Run()
        {
            string conString =_configuration.GetConnectionString("DefaultConnection");

            System.Console.WriteLine(conString);
        }
    }
}