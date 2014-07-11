using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.ChangeTracking;
using Microsoft.Data.Entity.Storage;
using Remotion.Linq;

namespace EntityFramework.ProviderStarter
{
    public class ProviderDataStore : DataStore
    {
        public override async Task<int> SaveChangesAsync(IReadOnlyList<StateEntry> stateEntries,
            CancellationToken cancellationToken = new CancellationToken())
        {
            int saved = 0;
            foreach (StateEntry stateEntry in stateEntries)
            {
                if (!stateEntry.EntityState.IsDirty())
                {
                    continue;
                }
                if (! (await Save(stateEntry)))
                {
                    throw new Exception("Could not save entity");
                }
                saved++;
            }
            return saved;
        }

        private Task<bool> Save(StateEntry stateEntry)
        {
            throw new NotImplementedException("Save the entity not implemented");
        }

        public override IEnumerable<TResult> Query<TResult>(QueryModel queryModel, StateManager stateManager)
        {
            throw new NotImplementedException("Query for entities using the queryModel");
        }

        public override IAsyncEnumerable<TResult> AsyncQuery<TResult>(QueryModel queryModel, StateManager stateManager)
        {
            throw new NotImplementedException();
        }
    }
}