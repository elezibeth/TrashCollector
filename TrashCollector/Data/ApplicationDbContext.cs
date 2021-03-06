using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrashCollector.Data;
using TrashCollector.Models;
   

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PauseService> PauseServices { get; set; }
        public DbSet<TrashPickup> TrashPickups { get; set; }
        public DbSet<PauseServiceRequest> PauseServiceRequests{get; set;}
        public DbSet<PauseServiceThree> PauseServicesThree { get; set; }
        public DbSet<PauseServicesFour> PauseServicesFours { get; set; }

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                 new IdentityRole
                 {
                     Name = "Customer",
                     NormalizedName = "CUSTOMER"
                 },
                  new IdentityRole
                  {
                      Name = "Employee",
                      NormalizedName = "EMPLOYEE"
                  }
                );
        }
        
        

        public DbSet<TrashCollector.Models.Customer> Customer { get; set; }
    }
}
