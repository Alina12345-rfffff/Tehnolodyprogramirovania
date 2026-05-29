using АрендаДомика.Domain;

namespace АрендаДомика.Domain.Repositories.Abstractions;

public interface IHouseRepository
{
    Task<House?> GetByIdAsync(Guid id);
    Task<IEnumerable<House>> GetAllAsync();
    Task AddAsync(House house);
    Task UpdateAsync(House house);
    Task DeleteAsync(Guid id);
}