using HospitalAppCore.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppDAL
{
    public class HospitalDbContext: DbContext
    {
        public HospitalDbContext() { }

        public HospitalDbContext(DbContextOptionsBuilder<HospitalDbContext> options) : base() { }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Suburb> Suburbs { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PHIWE; Database=HospitalApp; Trusted_Connection=True; MultipleActiveResultSets=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Doctor>().HasData(new List<Doctor>()
            {
                new Doctor() { DoctorID = 1, FirstName = "John", LastName = "Smith", MobileNumber = "0724588841"},
                new Doctor() { DoctorID = 2, FirstName = "Miraim", LastName = "Nkosi", MobileNumber = "0715689551"}
            });

            modelBuilder.Entity<Province>().HasData(new List<Province>()
            {
                new Province() { ProvinceID = 1, ProvinceName = "Eastern Cape"}
            });

            modelBuilder.Entity<City>().HasData(new List<City>()
            {
                new City() { CityID = 1, CityName = "Port Elizabeth", ProvinceID = 1}
            });

            modelBuilder.Entity<Suburb>().HasData(new List<Suburb>()
            {
                new Suburb() { SuburbID = 1, SuburbName = "Adcock Vale", CityID = 1},
                new Suburb() { SuburbID = 2, SuburbName = "Algoapark", CityID = 1},
                new Suburb() { SuburbID = 3, SuburbName = "Humewood", CityID = 1},
                new Suburb() { SuburbID = 4, SuburbName = "Summerstrand", CityID = 1}
            });

            
            modelBuilder.Entity<Patient>().HasData(new List<Patient>
            {
                new Patient() { PatientID = 1, FullNames = "Charmaine Meintjies", Gender = "Female", DOB = DateTime.Now, MobileNumber = "0832458796", EmailAddress = "charmaine@gmail.com" }
            });

            modelBuilder.Entity<Address>().HasData(new List<Address>
            {
                new Address() { AddressID = 1, AddressLine1 = "Admirality Way", AddressLine2 = "", PatientID = 1, SuburbID = 4}
            });
        }
    }
}
