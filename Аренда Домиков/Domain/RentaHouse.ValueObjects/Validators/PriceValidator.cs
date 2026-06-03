using RentaHouse.ValueObjects.Base;

namespace RentaHouse.ValueObjects.Validators;

public class PriceValidator : IValidator<decimal>
{
    public void Validate(decimal value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value), "Цена не может быть отрицательной.");
    }
}