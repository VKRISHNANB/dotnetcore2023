using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace TownplanningEfApp.ModelA {
    public class TownPlanningContextA : DbContext {
        private readonly String constr = 
        @"server=VENKATHPDESKTOP\SQLEXPRESS;database=TownPlanningModelADB;integrated security=true";
        public TownPlanningContextA() 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {         
            options
                /** 
                 *  Including Logger for Information
                 *  ConsoleLoggerFactory is a private property 
                 */
                //.UseLoggerFactory(ConsoleLoggerFactory)
                /**
                    You should only enable this flag if you have the appropriate 
                    security measures in place based on the sensitivity of this data
                */
                //.EnableSensitiveDataLogging()
                .UseSqlServer(constr);
        }
        public ILoggerFactory ConsoleLoggerFactory 
        {
            get {
                /**  add package Microsoft.Extensions.Logging.Console **/
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
        public TownPlanningContextA (DbContextOptions<TownPlanningContextA> options) : base (options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /**
             * A Person can have only one AadhaarCard.
             * To prevent 2 different AadhaarCards having the same PersonID
             * we will have to make the PersonId column in AadhaarCard table as Unique
             * In EFCore you cannot create Indexes using data annotations.
             * But you can do it using the Fluent API
             * */
            builder.Entity<AadhaarCard>()
                .HasIndex(u => u.PersonId)
                .IsUnique();           
        }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<AadhaarCard> AadhaarCards { get; set; }
        
    }
}