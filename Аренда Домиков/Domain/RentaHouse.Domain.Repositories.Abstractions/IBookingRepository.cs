using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RentaHouse.Domain.Repositories.Abstractions.Base;
using RentaHouse.ValueObjects;

namespace RentaHouse.Domain.Repositories.Abstractions;

public interface IBookingRepository : IRepository<Booking, BookingId>
{
    // Получить все бронирования конкретного жильца
    Task<IEnumerable<Booking>> GetBookingsByTenantIdAsync(TenantId tenantId, CancellationToken cancellationToken);

    // Проверить, занят ли дом на конкретную дату 
    Task<bool> IsHouseBookedForDateAsync(HouseId houseId, DateTime date, CancellationToken cancellationToken);
}
