using АрендаДомика.ValueObjects;
using АрендаДомика.ValueObjects.Exceptions;

namespace АрендаДомика.Domain;

public class House
{
    public Guid Id { get; private set; }
    public HouseTitle Title { get; private set; }
    public Price PricePerNight { get; private set; }
    public string Description { get; private set; }
    public string Address { get; private set; }
    public Guid LandlordId { get; private set; }

    public House(Guid id, HouseTitle title, Price pricePerNight, string description, string address, Guid landlordId)
    {
        if (string.IsNullOrWhiteSpace(address))
            throw new DomainException("Адрес домика должен быть указан.");

        Id = id;
        Title = title;
        PricePerNight = pricePerNight;
        Description = description;
        Address = address;
        LandlordId = landlordId;
    }
}