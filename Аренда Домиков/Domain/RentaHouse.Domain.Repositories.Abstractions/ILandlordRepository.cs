using System.Threading;
using System.Threading.Tasks;
using RentaHouse.Domain.Repositories.Abstractions.Base;
using RentaHouse.ValueObjects;

namespace RentaHouse.Domain.Repositories.Abstractions;

public interface ILandlordRepository : IRepository<Landlord, LandlordId>
{
    // Так как Email арендодателя должен быть уникальным
    Task<Landlord?> GetLandlordByEmailAsync(Email email, CancellationToken cancellationToken);
}
