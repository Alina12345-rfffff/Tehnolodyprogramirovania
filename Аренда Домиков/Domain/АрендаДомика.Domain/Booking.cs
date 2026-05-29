using АрендаДомика.ValueObjects;

namespace АрендаДомика.Domain;

public enum BookingStatus
{
    Pending,
    Confirmed,
    Rejected
}

public class Booking
{
    public Guid Id { get; private set; }
    public Guid HouseId { get; private set; }
    public Price TotalPrice { get; private set; }
    public BookingStatus Status { get; private set; }

    public Booking(Guid id, Guid houseId, Price totalPrice)
    {
        Id = id;
        HouseId = houseId;
        TotalPrice = totalPrice;
        Status = BookingStatus.Pending;
    }

    // Методы для сценария "Подтвердить/отклонить бронь"
    public void Confirm()
    {
        if (Status != BookingStatus.Pending)
            throw new InvalidOperationException("Можно подтвердить только бронь в ожидании.");

        Status = BookingStatus.Confirmed;
    }

    public void Reject()
    {
        if (Status != BookingStatus.Pending)
            throw new InvalidOperationException("Можно отклонить только бронь в ожидании.");

        Status = BookingStatus.Rejected;
    }
}