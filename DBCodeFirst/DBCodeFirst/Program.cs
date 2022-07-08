using DBCodeFirst;

namespace ConsoleEFCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                context.Database.EnsureCreated();
                context.SaveChanges();             
            }
        }
    }
}