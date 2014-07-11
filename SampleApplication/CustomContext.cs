using Microsoft.Data.Entity;

namespace SampleApplication
{
    public class CustomContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseProvider("Some connection string");
        }
    }
}