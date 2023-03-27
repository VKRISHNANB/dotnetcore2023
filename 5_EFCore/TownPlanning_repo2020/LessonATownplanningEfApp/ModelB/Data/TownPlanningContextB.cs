using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Text;

namespace TownplanningEfApp.ModelB {
    public class TownPlanningContextB : DbContext {
        private readonly String constr = 
        @"server=VENKATHPDESKTOP\SQLEXPRESS;database=TownPlanningModelBDB;integrated security=true";
        public TownPlanningContextB() 
        {

            /*** 
            * QueryTrackingBehavior.NoTracking
            * No Tracking Queries : will not Track all the Entities created by this Context
            **/
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            /**
             * The EnsureDeleted method will drop the database if it exists.
             * **/
             //this.Database.EnsureDeleted();

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
        public TownPlanningContextB (DbContextOptions<TownPlanningContextB> options) : base (options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AssetDetails>(entity =>
            {
                /** Compound key **/
                entity.HasKey(e => new {e.AssetID,e.PersonId});
                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Assets)
                    /** disable cascade DELETE to avoid circular operation **/
                    .HasForeignKey(d => d.AssetID)
                        .OnDelete(DeleteBehavior.NoAction)
                    .HasForeignKey(d=>d.PersonId)
                        .OnDelete(DeleteBehavior.NoAction);                        
            });
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
            /**
           * A Person can have only one Role.
           * To prevent 2 different Roles having the same PersonID
           * we will have to make the PersonId column in 
           * VillageAdministrationRole table as Unique
           * */
            builder.Entity<VillageAdministrationRole>()
                .HasIndex(u => u.PersonId)
                .IsUnique();
        }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<AadhaarCard> AadhaarCards { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<VillageAdministrationRole> Roles { get; set; }        
    }
}