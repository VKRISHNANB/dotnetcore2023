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
                // ConsoleLoggerFactory is a private property 
                .UseLoggerFactory(ConsoleLoggerFactory) 
                .EnableSensitiveDataLogging() 
                // You should only enable this flag if you have the appropriate 
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
    public class Festival
    {
        public int FestivalId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Location { get; set; }
        public int NoOfDays { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        /**
        * Many to Many Relationship
        * For every Festival there can be many Fooditems
        * And also a FoodItem can be made for many Festivals
        * So in the festival class add list of "FoodDish" as navigation property
        */
        public List<FoodDish> Sweets { get; } = new List<FoodDish>();
       /**
        * Many to 1 Relationship
        * For every Festival there is only one Religion
        * But for every Religion there are many Festivals
        * So in the festival class add "ReligionId" as foreign Key
        * and an instance of "Religion" as navigation property
        */
        // Navigation Property
        public Religion Religion { get; set; }
        // Foreign Key
        public int ReligionId { get; set; }

    }
    public class Religion
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        /**
         * 1 to Many Relationship
         * For every Religion there are many Festivals
         * But for every Festival there is only one Religion
         * So in the Religion class add a list of "Festival" as navigation property
         */
        public List<Festival> Festivals { get; }// = new List<Festival>();
    }
    public class FoodDish
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int CookingTime { get; set; }
        public String CookingMethod { get; set; }
        public String DishType { get; set; }
        public List<Festival> Festivals { get; } = new List<Festival>();
        //public Recipe Recipe { get; set; }
    }
    public class FestivalDishDetails
    {
        public int FestivalId { get; set; }
        public int DishId { get; set; }
    }
    //public class Recipe
    //{
    //    public int RecipeId { get; set; }
    //    public int FoodId { get; set; }
    //    public String Description { get; set; }
    //    public FoodDish FoodItem { get; set; }
    //}
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
