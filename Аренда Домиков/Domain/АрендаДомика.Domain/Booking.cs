using АрендаДомика.ValueObjects.Exceptions;

namespace АрендаДомика.Domain;

public class Booking
{
    public Guid Id { get; private set; }
    public Guid TenantId { get; private set; }
    public Guid HouseId { get; private set; }
    public DateTime BookingDate { get; private set; }
    public string Status { get; private set; } // Ожидает / Подтверждена / Отклонена

    public Booking(Guid id, Guid tenantId, Guid houseId, DateTime bookingDate)
    {
        if (bookingDate.Date < DateTime.UtcNow.Date)
            throw new DomainException("Нельзя забронировать домик на прошедшую дату.");

        Id = id;
        TenantId = tenantId;
        HouseId = houseId;
        BookingDate = bookingDate.Date;
        Status = "Ожидает";
    }

    public void Confirm() => Status = "Подтверждена";
    public void Reject() => Status = "Отклонена";
}