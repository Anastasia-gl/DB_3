using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Newtonsoft.Json;
namespace DBCodeFirst
{
    public sealed class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var dir = File.ReadAllText("link.json");
            var connectionString = JsonConvert.DeserializeObject(dir);
            var result = Convert.ToString(connectionString);
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(result)
                .Options;

            return new ApplicationContext(options);
        }
    }
}