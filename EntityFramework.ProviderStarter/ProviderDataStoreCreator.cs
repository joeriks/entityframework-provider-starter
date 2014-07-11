using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Storage;

namespace EntityFramework.ProviderStarter
{
    public class ProviderDataStoreCreator : DataStoreCreator
    {
        /// <summary>
        ///     Ensure the all storage used to store this model is deleted
        /// </summary>
        /// <param name="model"></param>
        /// <returns>True if the storage was changed, false is nothing was changed</returns>
        public override bool EnsureDeleted(IModel model)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> EnsureDeletedAsync(IModel model,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Ensure the all storage necessary to store this model is ready
        /// </summary>
        /// <param name="model"></param>
        /// <returns>True if the storage was changed, false is nothing was changed</returns>
        public override bool EnsureCreated(IModel model)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> EnsureCreatedAsync(IModel model,
            CancellationToken cancellationToken = new CancellationToken())
        {
            throw new NotImplementedException();
        }
    }
}