using FirstMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
namespace AspFirstMVCCore.Models
{
    //public class SampleDbContext: DbContext
    //{
    //    public DbSet<Emp> Employees { get; set; }
    //    public DbSet<Book> Books { get; set; }

    //    public SampleDbContext()
    //    {
    //        var folder = Environment.SpecialFolder.LocalApplicationData;
    //        var path = Environment.GetFolderPath(folder);
    //    }

       
    //    protected override void OnConfiguring(DbContextOptionsBuilder options)
    //    {
    //        options.UseSqlServer(SqlHelper.GetConnectionString());
    //        // Including Logger for Information
    //        /**
    //        options
    //            .UseLoggerFactory(ConsoleLoggerFactory) // ConsoleLoggerFactory is a private property 
    //            .EnableSensitiveDataLogging(); // You should only enable this flag if you have the appropriate 
    //                                           // security measures in place based on the sensitivity of this data
    //                                           //.UseSqlServer(conString);
    //        */
    //    }
    //    private ILoggerFactory ConsoleLoggerFactory
    //    {
    //        get
    //        {
    //            // add package Microsoft.Extensions.Logging.Console
    //            var fac = LoggerFactory.Create(builder =>
    //            {
    //                builder
    //                .AddFilter((category, level) =>
    //                   category == DbLoggerCategory.Database.Command.Name
    //                   && level == LogLevel.Information)
    //                .AddConsole();
    //            });
    //            return fac;
    //        }
    //    }
    //}
}
