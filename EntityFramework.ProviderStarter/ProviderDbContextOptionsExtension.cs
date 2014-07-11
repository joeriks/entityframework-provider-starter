using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Framework.DependencyInjection;

namespace EntityFramework.ProviderStarter
{
    public class ProviderDbContextOptionsExtension : DbContextOptionsExtension
    {
        public string ConnectionString { get; internal set; }

        protected override void ApplyServices(EntityServicesBuilder builder)
        {
            builder.AddProvider();
        }
    }
}