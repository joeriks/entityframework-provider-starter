using System;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Storage;

namespace EntityFramework.ProviderStarter
{
    public class ProviderDataStoreSource : DataStoreSource<
        ProviderDataStore,
        ProviderDbContextOptionsExtension,
        ProviderDataStoreCreator,
        ProviderConnection,
        ProviderValueGeneratorCache,
        ProviderDatabase>
    {
        public override string Name
        {
            get { return "Provider"; }
        }

        public override bool IsAvailable(DbContextConfiguration configuration)
        {
            throw new NotImplementedException("Return true when the storage is available for read/write");
        }
    }
}