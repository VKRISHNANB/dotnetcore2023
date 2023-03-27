using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;
namespace FirstMVC
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options)
        {
           
        }
        public virtual DbSet<Customer> Customer { get; set; }

        /* Console Logger
            private readonly IConfiguration _configuration;
            public SampleContext(DbContextOptions<SampleContext> options, IConfiguration config) : base(options)
            {
                _configuration = config;
            }
          protected override void OnConfiguring(DbContextOptionsBuilder options)
          {
              //string conString = _configuration.GetConnectionString("DefaultConnection");
              //options.UseSqlServer(conString);
              // Including Logger for Information
              options
                  .UseLoggerFactory(ConsoleLoggerFactory) // ConsoleLoggerFactory is a private property 
                  .EnableSensitiveDataLogging(); // You should only enable this flag if you have the appropriate 
                                                // security measures in place based on the sensitivity of this data
                  //.UseSqlServer(conString);
          }
          private ILoggerFactory ConsoleLoggerFactory
          {
              get
              {
                  // add package Microsoft.Extensions.Logging.Console
                  var fac = LoggerFactory.Create(builder =>
                  {
                      builder
                      .AddFilter((category, level) =>
                         category == DbLoggerCategory.Database.Command.Name
                         && level == LogLevel.Information)
                      .AddConsole();
                  });
                  return fac;
              }
          }*/
    }
}