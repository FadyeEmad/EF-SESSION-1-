using EF_SESSION_1_DEMO.configrations;
using EF_SESSION_1_DEMO.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SESSION_1_DEMO.context
{
    internal class companyDBContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =. ; database = company ; trusted_connection = true"); // ينفع تحطهم برضو username = ; password = ; 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<employee>(new employeeconfigration()); // لما بستخدم الطريقه الرابعه
         // modelBuilder.ApplyConfigurationsFromAssembly(); //  بتعمل apply لكل ال entity configrations  فالبروجيكت كله

            //fluent api
            //modelBuilder.Entity<employee>().HasKey(e=> e.EmpId); // مسكت ال entity و حددت ال pk
            //modelBuilder.Entity<employee>().Property(e => e.EmpId).UseIdentityColumn(1, 1);
            //modelBuilder.Entity<employee>().Property(e => e.Name).HasColumnType("varchar").HasMaxLength(50).HasDefaultValue("Fady");
            //modelBuilder.Entity<employee>().Property(e => e.Salary).HasColumnType("money");
            // better // 
            //modelBuilder.Entity<employee>(e =>
            //{
            //    e.HasKey(e => e.EmpId);
            //    e.Property(e => e.EmpId).UseIdentityColumn(1, 1);
            //    e.Property(e => e.Name).HasMaxLength(50).HasColumnType("varchar").HasDefaultValue("Fady");
            //    e.Property(E => E.Salary).HasColumnType("money");
            //});
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<employee> Employees { get; set; } // Create Entity
    }
}
#region migrations
// add-Migration "initialcreate"
// update-Database "initialcreate"
// remove-Migration


#endregion