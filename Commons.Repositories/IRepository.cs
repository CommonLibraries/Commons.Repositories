using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Repositories
{
    public interface IRepository<TEntity, TKey>
    {
        Task<TEntity> GetAsync(TKey id, CancellationToken cancellationToken = default);
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<TEntity>UpdateAsync(TEntity entity, CancellationToken cancellationToken= default);
        Task<TEntity> DeleteAsync(TKey id, CancellationToken cancellationToken = default);
    }
}
