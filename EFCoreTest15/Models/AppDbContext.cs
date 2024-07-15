using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTest15.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students   { get; set; }
        public DbSet<Address> Addresses { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().HasData(new List<Student>()
        //    {
        //         new Student(){ Id = 1, FirstName = "Ashik", LastName = "Rahman",
        //        EmailAddress = "ashik@gmail.com"},
        //         new Student(){ Id = 2, FirstName = "Ripon", LastName = "Mia",
        //        EmailAddress = "ripon@gmail.com" }
        //    });

        //    modelBuilder.Entity<Address>().HasData(new List<Address>()
        //    {
        //        new Address(){ Id = 1,AddressLine1="sdsdd",AddressLine2="dcnhc",City="dfd",State="dvds",Country="Usa",ZipCode="12335"},
        //         new Address(){ Id = 2,AddressLine1="fsdfd",AddressLine2="ffffa",City="asfdsd",State="fsddg",Country="AUS",ZipCode="15548"}
        //    });
        //}
    }
}
