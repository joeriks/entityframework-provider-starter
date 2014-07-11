using EntityFramework.ProviderStarter;
using Microsoft.Data.Entity.Infrastructure;

// ReSharper disable once CheckNamespace

namespace Microsoft.Data.Entity
{
    public static class ProviderDbContextOptionsExtensions
    {
        public static DbContextOptions UseProvider(this DbContextOptions options, string connectionString)
        {
            ((IDbContextOptionsExtensions) options).AddOrUpdateExtension<ProviderDbContextOptionsExtension>(
                e => { e.ConnectionString = connectionString; });

            return options;
        }
    }
}