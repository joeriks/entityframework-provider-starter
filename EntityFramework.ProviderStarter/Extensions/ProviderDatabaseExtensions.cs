using System;
using EntityFramework.ProviderStarter;
using Microsoft.Data.Entity.Infrastructure;

// ReSharper disable once CheckNamespace

namespace Microsoft.Data.Entity
{
    public static class ProviderDatabaseExtensions
    {
        public static ProviderDatabase AsProviderDatabase(this Database database)
        {
            var specificDatabase = database as ProviderDatabase;
            if (specificDatabase == null)
            {
                throw new ArgumentOutOfRangeException("database", "ProviderDatabase is not in use");
            }
            return specificDatabase;
        }
    }
}