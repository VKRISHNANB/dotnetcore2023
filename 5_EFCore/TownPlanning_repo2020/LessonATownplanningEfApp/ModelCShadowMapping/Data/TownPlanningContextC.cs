using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Linq;

namespace TownplanningEfApp.ModelC {
    public class TownPlanningContextC : DbContext {
        private readonly String constr = 
        @"server=VENKATHPDESKTOP\SQLEXPRESS;database=TownPlanningModelCDB;integrated security=true";
        public TownPlanningContextC() 
        {
            /*** 
            * QueryTrackingBehavior.NoTracking
            * No Tracking Queries : will not Track all the Entities created by this Context
            **/
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
           
        }
        public TownPlanningContextC(bool ensureDeletedCreated)
        {
            /*** 
            * QueryTrackingBehavior.NoTracking
            * No Tracking Queries : will not Track all the Entities created by this Context
            **/
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

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
        public TownPlanningContextC (DbContextOptions<TownPlanningContextC> options) : base (options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);          
            /**
           * A Person can have only one Role.
           * To prevent 2 different Roles having the same PersonID
           * we will have to make the PersonId column in 
           * VillageAdministrationRole table as Unique
           * */
            builder.Entity<VillageAdministrationRole>()
                .HasIndex(u => u.PersonId)
                .IsUnique();
            /**
             * OnModelCreating() is the place to add Shadow Properties  
             */
            builder.Entity<VillageAdministrationRole>().Property<DateTime?>("DateOfJoining");
            builder.Entity<VillageAdministrationRole>().Property<int?>("PreviousInChargePersonId");
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                builder.Entity(entityType.Name).Property<DateTime>("Created");
                builder.Entity(entityType.Name).Property<DateTime>("LastModified");
            }
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            foreach (var entity in ChangeTracker.Entries()
                .Where(e=>e.State==EntityState.Added || e.State == EntityState.Modified))
            {
                entity.Property("LastModified").CurrentValue = DateTime.Now;
                if(entity.State == EntityState.Added)
                {
                    entity.Property("Created").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<VillageAdministrationRole> Roles { get; set; }        
    }
}