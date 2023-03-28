using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace aspnetmvcapp.Models
{
    public class DataAccessControl:IDAC
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<DataAccessControl> _logger;

        public DataAccessControl(ILogger<DataAccessControl> logger,IConfiguration config)
        {
            _logger = logger;
            _configuration = config;
        }
        public void Run()
        {
            string conString =_configuration.GetConnectionString("DefaultConnection");
            _logger.Log(LogLevel.Information, conString, null);
            System.Console.WriteLine(conString);
        }
    }
}