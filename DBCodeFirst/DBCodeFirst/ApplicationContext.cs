using DBCodeFirst.Configs;
using DBCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DBCodeFirst
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        public DbSet<EmployeeProject> EmployeeProject { get; set; }

        public DbSet<Office> Office { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<Title> Title { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
        }
    }
}
