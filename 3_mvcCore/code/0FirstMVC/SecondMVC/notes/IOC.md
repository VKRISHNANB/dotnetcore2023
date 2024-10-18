Adding Service Dependency
---
Accessing Db Connection string from appsettings.json
---
   <h3>In appsettings.json:</h3>   

    {
      "ConnectionStrings": {
        "DefaultConnection": "server=...;database=Sample;integrated security=true;MultipleActiveResultSets=true"},
      "Logging": {
         "LogLevel": {
            "Default": "Information",
            "Microsoft": "Warning",
            "Microsoft.Hosting.Lifetime": "Information"
          }
        },
      "AllowedHosts": "*"
    }

<h3>In Startup.cs</h3>   

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);
        }

<h3>HomeController</h3>   

    using Microsoft.Extensions.Configuration;
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger,IConfiguration config)
        {
            _logger = logger;
            _configuration= config;
        }
        public IActionResult Index()
        {
            string conString =_configuration.GetConnectionString("DefaultConnection");
            Console.WriteLine(conString);
            return View();
        }
    }

<hr/>

Using DAC as a Service
---

<h3>Dependency injection :</h3>

   . The use of an interface or base class to abstract the dependency implementation.  
   . Registration of the dependency in a service container. ASP.NET Core provides a built-in service container, IServiceProvider. Services are registered in the app's <b>Startup.ConfigureServices()</b> method.  
   . Injection of the service into the constructor of the class where it's used. The framework takes on the responsibility of creating an instance of the dependency and disposing of it when it's no longer needed.  

Create an interface   

    public interface IDAC
    {
        void Run();
    }

Create an implementer for the interface   

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

In Startup.cs   

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IConfiguration>(Configuration);
        // The registration scopes the service lifetime to the lifetime of a single request
        services.AddScoped<IDAC,DataAccessControl>();
    }

In Home Controller

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Configuration;
    public class HomeController : Controller
    {
      private readonly ILogger<HomeController> _logger;
      private readonly IDAC _dao;
      public HomeController(ILogger<HomeController> logger,IDAC dac)
      {
          _logger = logger;
          _dao= dac;
      }
      public IActionResult Index()
      {
          _dao.Run();
          return View();
      }
    }

<hr/>

Get Services Manually   
---

It is not required to include dependency services in the constructor. We can access dependent services configured with built-in IoC container manually using RequestServices property of HttpContext as shown below.

    public class HomeController : Controller
    {
     public HomeController()
     {
     }
     public IActionResult Index()
     {
        var services = this.HttpContext.RequestServices;
        var log = (ILog)services.GetService(typeof(ILog));            
        log.info("Index method executing");    
        return View();
     }
    }
<hr/>


