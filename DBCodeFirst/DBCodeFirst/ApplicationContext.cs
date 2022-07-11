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

        public DbSet<Client> Clients { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    ClientId = 1,
                    FirtsName = "John",
                    Lastname = "Smith",
                    Email = "dhjkfk@sdk.co",
                    Telephone = 0958762012
                },

                new Client
                {
                    ClientId = 2,
                    FirtsName = "Nastya",
                    Lastname = "Hlusenko",
                    Email = "aaak@sdk.co",
                    Telephone = 0958768012
                },

                new Client
                {
                    ClientId = 3,
                    FirtsName = "Lena",
                    Lastname = "Lohvinova",
                    Email = "lllk@sdk.co",
                    Telephone = 0508768012
                },

                new Client
                {
                    ClientId = 4,
                    FirtsName = "Nastya",
                    Lastname = "Zemlyanskaya",
                    Email = "nnnk@sdk.co",
                    Telephone = 0508766511
                },

                new Client
                {
                    ClientId = 5,
                    FirtsName = "Alena",
                    Lastname = "Ss",
                    Email = "ssss@sdk.co",
                    Telephone = 0508876511
                }
                );

            modelBuilder.Entity<Project>().HasData(

                new Project
                {
                    ProjectId = 1,
                    Name = "A",
                    Budget = 200,
                    StartedDate = DateTime.Now,
                    ClientId = 1
                },

                new Project
                {
                    ProjectId = 2,
                    Name = "Б",
                    Budget = 200,
                    StartedDate = DateTime.Now,
                    ClientId = 2
                },

                new Project
                {
                    ProjectId = 3,
                    Name = "В",
                    Budget = 200,
                    StartedDate = DateTime.Now,
                    ClientId = 3
                },

                new Project
                {
                    ProjectId = 4,
                    Name = "Г",
                    Budget = 200,
                    StartedDate = DateTime.Now,
                    ClientId = 4
                },

                new Project
                {
                    ProjectId = 5,
                    Name = "Д",
                    Budget = 200,
                    StartedDate = DateTime.Now,
                    ClientId = 5
                  }
            );
        }
    }
}
