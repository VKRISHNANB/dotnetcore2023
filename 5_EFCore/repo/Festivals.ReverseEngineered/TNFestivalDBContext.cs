using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Festivals.ReverseEngineered
{
    public partial class TNFestivalDBContext : DbContext
    {
        public TNFestivalDBContext()
        {
        }

        public TNFestivalDBContext(DbContextOptions<TNFestivalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Festivals> Festivals { get; set; }
        public virtual DbSet<Kadavuls> Kadavuls { get; set; }
        public virtual DbSet<Religions> Religions { get; set; }
        public virtual DbSet<Sweets> Sweets { get; set; }
        public virtual DbSet<TempleSannidhis> TempleSannidhis { get; set; }
        public virtual DbSet<Temples> Temples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=VENKATHPDESKTOP\\SQLEXPRESS;database=TNFestivalDB;integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Festivals>(entity =>
            {
                entity.HasKey(e => e.FestivalId);

                entity.HasIndex(e => e.ReligionId);

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.Festivals)
                    .HasForeignKey(d => d.ReligionId);
            });

            modelBuilder.Entity<TempleSannidhis>(entity =>
            {
                entity.HasKey(e => e.SannidhiId);

                entity.HasIndex(e => e.TempleId);

                entity.HasOne(d => d.Temple)
                    .WithMany(p => p.TempleSannidhis)
                    .HasForeignKey(d => d.TempleId);
            });

            modelBuilder.Entity<Temples>(entity =>
            {
                entity.HasKey(e => e.TempleId);

                entity.HasIndex(e => e.MolavarId);

                entity.HasOne(d => d.Molavar)
                    .WithMany(p => p.Temples)
                    .HasForeignKey(d => d.MolavarId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
