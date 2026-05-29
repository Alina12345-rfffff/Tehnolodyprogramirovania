namespace АрендаДомика.Domain.Repositories.Abstract;

public interface IBookingRepository
{
    // Найти бронь по ID
    Task<Booking?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    // Сценарий: Запрос на бронь
    Task AddAsync(Booking booking, CancellationToken cancellationToken = default);

    // Сценарий: Подтвердить/отклонить бронь
    Task UpdateAsync(Booking booking, CancellationToken cancellationToken = default);

    // Просмотр всех бронирований для конкретного домика
    Task<IEnumerable<Booking>> GetByHouseIdAsync(Guid houseId, CancellationToken cancellationToken = default);
}