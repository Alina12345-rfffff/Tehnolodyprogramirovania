using АрендаДомика.ValueObjects;

namespace АрендаДомика.Domain;

public class House
{
    public Guid Id { get; private set; }
    public HouseTitle Title { get; private set; }
    public string Description { get; private set; }
    public Price PricePerNight { get; private set; }

    public House(Guid id, HouseTitle title, string description, Price pricePerNight)
    {
        Id = id;
        Title = title;
        Description = string.IsNullOrWhiteSpace(description)
            ? throw new ArgumentException("Описание не может быть пустым.")
            : description;
        PricePerNight = pricePerNight;
    }

    // Метод для сценария "Редактирование описания домов"
    public void UpdateDetails(HouseTitle newTitle, string newDescription)
    {
        if (string.IsNullOrWhiteSpace(newDescription))
            throw new ArgumentException("Новое описание не может быть пустым.");

        Title = newTitle ?? throw new ArgumentNullException(nameof(newTitle));
        Description = newDescription;
    }

    public void UpdatePrice(Price newPrice)
    {
        PricePerNight = newPrice ?? throw new ArgumentNullException(nameof(newPrice));
    }
}