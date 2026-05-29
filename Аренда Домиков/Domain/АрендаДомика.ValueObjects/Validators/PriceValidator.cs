using АрендаДомика.ValueObjects.Base;
using АрендаДомика.ValueObjects.Exceptions;

namespace АрендаДомика.ValueObjects.Validators;

public class PriceValidator : IValidator<decimal>
{
    public void Validate(decimal value)
    {
        if (value <= 0)
            throw new DomainException("Цена аренды должна быть больше нуля.");
    }
}