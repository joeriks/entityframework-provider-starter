using EntityFramework.ProviderStarter;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Storage;

// ReSharper disable once CheckNamespace

namespace Microsoft.Framework.DependencyInjection
{
    public static class EntityServicesBuilderExtensions
    {
        public static EntityServicesBuilder AddProvider(this EntityServicesBuilder builder)
        {
            builder.ServiceCollection
                .AddSingleton<DataStoreSource, ProviderDataStoreSource>()
                .AddScoped<ProviderConnection>()
                .AddScoped<ProviderDatabase>()
                .AddScoped<ProviderDataStoreCreator>()
                .AddScoped<ProviderDataStore>()
                .AddScoped<ProviderValueGeneratorCache>();
            return builder;
        }
    }
}