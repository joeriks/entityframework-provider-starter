using System;
using Microsoft.Data.Entity.Infrastructure;

namespace EntityFramework.ProviderStarter
{
    public class ProviderDatabase : Database
    {
        public ProviderDatabase(DbContextConfiguration configuration)
            : base(configuration)
        {
        }

        public void CreateStorage()
        {
            throw new NotImplementedException("Example of custom database action");
        }
    }
}