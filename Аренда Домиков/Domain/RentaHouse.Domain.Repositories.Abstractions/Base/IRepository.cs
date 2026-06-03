using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RentaHouse.Domain.Base;

namespace RentaHouse.Domain.Repositories.Abstractions.Base;

public interface IRepository<TEntity, in TId>
     where TEntity : Entity<TId>
     where TId : notnull, IEquatable<TId>
{
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken, bool asNoTracking = false);
    Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken);
    Task<TEntity?> AddAsync(TEntity entity, CancellationToken cancellationToken);
    Task<bool> UpdateAsync(TEntity entity, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(TEntity entity, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(TId id, CancellationToken cancellationToken);
}
