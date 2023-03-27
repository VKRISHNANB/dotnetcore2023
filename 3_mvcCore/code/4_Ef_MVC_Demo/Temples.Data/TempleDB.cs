using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace Temples.Data
{
    public class TempleDB : DbContext
    {
        private readonly String constr =
              @"server=VENKATHPDESKTOP\SQLEXPRESS;database=TNFestivalDB;integrated security=true";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
              => options.UseSqlServer(constr);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TempleKadavulDetails>(entity =>
            {
                entity.HasKey(e => new { e.TempleId, e.KadavulId});

                //entity.HasOne(d => d.Religion)
                //    .WithMany(p => p.Festivals)
                //    .HasForeignKey(d => d.ReligionId);
            });
        }
        public DbSet<Temple> Temples { get; set; }
        public DbSet<Kadavul> Kadavuls { get; set; }
        public DbSet<Sannidhi> Sannidhis { get; set; }
        public DbSet<TempleKadavulDetails> TempleSannidhiDetails { get; set; }
    }

    public class Sannidhi
    {
        public int SannidhiId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Location { get; set; }
        public int KadavulId { get; set; }
    }

    public class Kadavul
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<TempleKadavulDetails> Temples { get; set; } = new List<TempleKadavulDetails>();
        public Sannidhi Sannidhi { get; set; }

    }

    public class Temple
    {
        public int TempleId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Location { get; set; }
        public List<TempleKadavulDetails> Sannidhis { get; set; } = new List<TempleKadavulDetails>();
    }
    public class TempleKadavulDetails
    {
        public int TempleId { get; set; }
        public int KadavulId { get; set; }
        public String Type { get; set; }
    }
}
