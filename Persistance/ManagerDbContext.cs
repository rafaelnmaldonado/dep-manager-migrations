using dep_manager_singleton.Entities;
using Microsoft.EntityFrameworkCore;

namespace dep_manager_singleton.Persistance
{
    public class ManagerDbContext : DbContext
    {
        public ManagerDbContext(DbContextOptions<ManagerDbContext> options) : base(options)
        {
            
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Department>(e =>
            {
                e.HasKey(dep => dep.Id);

                e.Property(dep => dep.Name)
                    .IsRequired(false)
                    .HasColumnType("VARCHAR(255)");

                e.Property(dep => dep.Acronym)
                    .IsRequired(false)
                    .HasColumnType("VARCHAR(7)");
            });

            builder.Entity<Employee>(e =>
            {
                e.HasKey(emp => emp.Id);
            });
        }

    }
}
