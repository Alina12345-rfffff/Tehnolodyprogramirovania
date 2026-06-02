using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RentaHouse.Domain.Repositories.Abstractions.Base;
using RentaHouse.ValueObjects;

namespace RentaHouse.Domain.Repositories.Abstractions;

public interface IHouseRepository : IRepository<House, HouseId>
{
    // Получить все дома, принадлежащие конкретному арендодателю
    Task<IEnumerable<House>> GetHousesByLandlordIdAsync(LandlordId landlordId, CancellationToken cancellationToken);
}
