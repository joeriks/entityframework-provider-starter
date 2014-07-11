using System;
using Microsoft.Data.Entity.Identity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Utilities;

namespace EntityFramework.ProviderStarter
{
    public class ProviderValueGeneratorCache : ValueGeneratorCache
    {
        private readonly ThreadSafeDictionaryCache<IProperty, IValueGenerator> _cachedValueGenerators
            = new ThreadSafeDictionaryCache<IProperty, IValueGenerator>();

        public override IValueGenerator GetGenerator(IProperty property)
        {
            return _cachedValueGenerators.GetOrAdd(property, p => GeneratorFactory(p));
        }

        private IValueGenerator GeneratorFactory(IProperty property)
        {
            throw new NotImplementedException();
        }
    }
}