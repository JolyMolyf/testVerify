using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace testProjEmpl.Models
{

    public class DataBaseContext : DbContext
    {


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        
        public DbSet<EmployementHistory> employementHistory { get; set; }


        public DataBaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


      

            modelBuilder.Entity<Employee>(e =>
            {
                e.HasKey(k => k.idEmp).HasName("Employee_Pk");
                e.Property(p => p.name).HasMaxLength(50).IsRequired();
                e.Property(p => p.payment).HasMaxLength(50).IsRequired();
              

            });
            modelBuilder.Entity<Position>(e =>
            {

                e.HasKey(k => k.idPosiotion).HasName("Position_Pk");
                e.Property(p => p.name).HasMaxLength(50).IsRequired(); 

            });

            modelBuilder.Entity<EmployementHistory>().HasKey(k => new { k.Employee_id, k.position_id });
            modelBuilder.Entity<EmployementHistory>().HasOne(p => p.position).WithMany(b => b.employemntHistory).HasForeignKey(f => f.position_id);
            modelBuilder.Entity<EmployementHistory>().HasOne(p => p.employee).WithMany(b => b.employemntHistory).HasForeignKey(d => d.Employee_id);

        }


    }
}

  



