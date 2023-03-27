using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Linq;

namespace LessonATownplanningEfApp.ModelDOwnedType{
    /**
     * https://docs.microsoft.com/en-us/ef/core/modeling/owned-entities
     * */

    public class TownPlanningContextD : DbContext {
        private readonly String constr = 
        @"server=VENKATHPDESKTOP\SQLEXPRESS;database=TownPlanningModelDdb;integrated security=true";
        public TownPlanningContextD() 
        {
        }
        public TownPlanningContextD(bool ensureDeletedCreated)
        {
            /**
             * The EnsureDeleted method will drop the database if it exists.
             * **/
            this.Database.EnsureDeleted();

           /**
            * EnsureCreated and Migrations don't work well together.
            * If you're using Migrations, don't use EnsureCreated to initialize the schema.
            * **/
            StringBuilder output = new StringBuilder();
            output.Append("EnsureCreated: ");
            output.Append(this.Database.EnsureCreated());
            Console.WriteLine(output);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {           
            options
                /**
                 * Including Logger for Information
                 * ConsoleLoggerFactory is a private property 
                 * **/
                //.UseLoggerFactory(ConsoleLoggerFactory)
                /**
                 * You should only enable this flag if you have the appropriate 
                 * security measures in place based on the sensitivity of this data
                 * **/
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
        public TownPlanningContextD (DbContextOptions<TownPlanningContextD> options) : base (options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if(!entityType.IsOwned())
                {
                    builder.Entity(entityType.Name).Property<DateTime>("Created");
                    builder.Entity(entityType.Name).Property<DateTime>("LastModified");
                }
            }
            /** Owned Type  */
            //builder.Entity<PersonD>().OwnsOne(p => p.Address);
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            foreach (var entity in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
            { 
                if(!entity.Metadata.IsOwned())
                {
                    entity.Property("LastModified").CurrentValue = DateTime.Now;
                    if (entity.State == EntityState.Added)
                    {
                        entity.Property("Created").CurrentValue = DateTime.Now;
                    }
                }
            }
            return base.SaveChanges();
        }
        public DbSet<VillageD> Villages { get; set; }
        public DbSet<PersonD> People { get; set; }
    }
}