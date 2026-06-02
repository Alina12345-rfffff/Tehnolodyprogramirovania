using System.Threading;
using System.Threading.Tasks;
using RentaHouse.Domain.Repositories.Abstractions.Base;
using RentaHouse.ValueObjects;

namespace RentaHouse.Domain.Repositories.Abstractions;

public interface ITenantRepository : IRepository<Tenant, TenantId>
{
    // Так как Email арендатора должен быть уникальным
    Task<Tenant?> GetTenantByEmailAsync(Email email, CancellationToken cancellationToken);
}
