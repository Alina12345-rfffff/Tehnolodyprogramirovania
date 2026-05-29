using АрендаДомика.ValueObjects.Base;

namespace АрендаДомика.ValueObjects.Validators;

public class PriceValidator : IValidator<decimal>
{
    public void Validate(decimal value)
    {
        if (value <= 0)
            throw new ArgumentException("Стоимость проживания должна быть больше нуля.");
    }
}