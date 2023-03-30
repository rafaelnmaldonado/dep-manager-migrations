using dep_manager_singleton.Entities;
using Microsoft.EntityFrameworkCore;

namespace dep_manager_singleton.Persistence
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

                e.Property(emp => emp.Name)
                    .IsRequired(false)
                    .HasColumnType("VARCHAR(255)");

                e.Property(emp => emp.Picture)
                    .IsRequired(false)
                    .HasColumnType("VARCHAR(255)");

                e.Property(emp => emp.Rg)
                    .IsRequired(false)
                    .HasColumnType("VARCHAR(9)");

                e.Property(emp => emp.IdDepartment)
                    .IsRequired(false);

            });
        }
    }
}
