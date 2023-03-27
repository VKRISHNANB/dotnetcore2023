using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace Festivals.Library
{
    public class FestivalsDB : DbContext
    {       
        private readonly String constr = 
            @"server=VENKATHPDESKTOP\SQLEXPRESS;database=TNFestivalDB;integrated security=true";
        public FestivalsDB()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(constr);
            // Including Logger for Information
            options
                .UseLoggerFactory(ConsoleLoggerFactory) // ConsoleLoggerFactory is a private property 
                .EnableSensitiveDataLogging() // You should only enable this flag if you have the appropriate 
                                              // security measures in place based on the sensitivity of this data
                .UseSqlServer(constr);
        }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<FoodDish> Sweets { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public ILoggerFactory ConsoleLoggerFactory 
        {
            get {
                // add package Microsoft.Extensions.Logging.Console
                var fac =LoggerFactory.Create(builder =>
                {
                    builder
                    .AddFilter( (category, level) =>
                        category == DbLoggerCategory.Database.Command.Name
                        && level == LogLevel.Information)
                    .AddConsole();
                });
                return fac;
            }
        }
        //public DbSet<FestivalDishDetails> FestivalDishDetails { get; set; }
        //public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Festival>(entity =>
            {
                entity.HasKey(e => e.FestivalId);

                entity.HasIndex(e => e.ReligionId);

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.Festivals)
                    .HasForeignKey(d => d.ReligionId);
            });

        }
    }
  
    public class FestivalsDBContextNonTracking : DbContext
    {
        private readonly String constr =
            @"server=VENKATHPDESKTOP\SQLEXPRESS;database=TNFestivalDB;integrated security=true";
        public FestivalsDBContextNonTracking()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // options.UseSqlServer(constr);
            // Including Logger
            options
                .UseLoggerFactory(ConsoleLoggerFactory) // ConsoleLoggerFactory is a private property 
                .EnableSensitiveDataLogging()
                .UseSqlServer(constr);
        }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<FoodDish> Sweets { get; set; }
        public DbSet<Religion> Religions { get; set; }
        private ILoggerFactory ConsoleLoggerFactory
        {
            get
            {
                // add package Microsoft.Extensions.Logging.Console
                // for the extension Method AddConsole()
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
        }
    }
}
