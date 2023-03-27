using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace TownplanningEfApp.Models {
    public class TownPlanningContext : DbContext {
        private readonly String constr = 
        @"server=VENKATHPDESKTOP\SQLEXPRESS;database=TownPlanningEFappBDB;integrated security=true";
        public TownPlanningContext() 
        {
            /*** 
            * QueryTrackingBehavior.NoTracking
            * No Tracking Queries : will not Track all the Entities created by this Context
            **/
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            /**
                options.UseSqlServer(constr);
                Including Logger for Information
            **/
            options
            /** ConsoleLoggerFactory is a private property **/
                 .UseLoggerFactory(ConsoleLoggerFactory)
                 .EnableSensitiveDataLogging()
            /**
                You should only enable this flag if you have the appropriate 
                security measures in place based on the sensitivity of this data
            **/
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
        public TownPlanningContext (DbContextOptions<TownPlanningContext> options) : base (options) { }
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
            /** Adding IsRequired Constrain to VillageAdministrationRole
                if Foreign Key is not given
             **/
            //builder.Entity<Person>()
            //    .HasOne(r => r.Role)
            //    .WithOne(i => i.InChargePerson).IsRequired();
            #region Shadow_Property
            /**
               Mapping Shadow property, nullable foreign key
            **/
            //builder.Entity<Person>()
            //   .HasOne(r => r.Role)
            //   .WithOne(i => i.InChargePerson).HasForeignKey<VillageAdministrationRole>("PersonId");
            /** 
             * In case of Bi-Directional navigation property 
             * Mapping has to be done for both directions
             * Person to Card and
             * Card to Person
             **/
            builder.Entity<Person>()
               .HasOne(p => p.Aadhaar)
               .WithOne(i => i.Owner)
               .HasForeignKey<AadhaarCard>(a=>a.PersonId);
           
            #endregion Shadow_Property
        }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<AadhaarCard> AadhaarCards { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<VillageAdministrationRole> Roles { get; set; }
        
    }
}