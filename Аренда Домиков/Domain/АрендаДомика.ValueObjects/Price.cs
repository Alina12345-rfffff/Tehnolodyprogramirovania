using АрендаДомика.ValueObjects.Base;

namespace АрендаДомика.ValueObjects;

public class Price : ValueObject<decimal>
{
    public Price(IValidator<decimal> validator, decimal value)
        : base(validator, value)
    {
    }
}