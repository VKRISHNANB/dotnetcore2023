using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace AspFirstMVCCore.Models
{
    public class HospitalDbContext:DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public HospitalDbContext(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //String conString = @"server=DESKTOP-LSEVB9U;database=HospitalDB;
            //    integrated security=true;Encrypt=false;";
            String conString = _configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(conString);
        }
        public DbSet<FirstMVC.Customer> Customer { get; set; }
    }
}
