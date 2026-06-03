using RentaHouse.ValueObjects.Base;
using RentaHouse.ValueObjects.Exceptions;

namespace RentaHouse.ValueObjects.Validators;

public class BookingStatusValidator : IValidator<string>
{
    private static readonly HashSet<string> ValidStatuses = ["Ожидание", "Подтверждено", "Отменено", "Завершено"];

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullOrWhiteSpaceException(nameof(value));

        if (!ValidStatuses.Contains(value))
            throw new ArgumentException($"Invalid booking status: {value}", nameof(value));
    }
}