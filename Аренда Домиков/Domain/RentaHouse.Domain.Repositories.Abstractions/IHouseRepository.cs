namespace АрендаДомика.Domain;

public interface IHouseRepository
{
    // Сценарий: Просмотр конкретного дома по ID
    Task<House?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    // Сценарий: Просмотр всех доступных домов списком
    Task<IEnumerable<House>> GetAllAsync(CancellationToken cancellationToken = default);

    // Сценарий: Выложить новый дом (сохранение в базу данных)
    Task AddAsync(House house, CancellationToken cancellationToken = default);

    // Сценарий: Редактирование описания домов (обновление данных)
    Task UpdateAsync(House house, CancellationToken cancellationToken = default);

    // Сценарий: Удалить дом
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}