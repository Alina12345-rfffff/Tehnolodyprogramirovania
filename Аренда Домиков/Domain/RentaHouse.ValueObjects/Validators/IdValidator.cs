using RentaHouse.ValueObjects.Base;
using RentaHouse.ValueObjects.Exceptions;

namespace RentaHouse.ValueObjects.Validators;

public class IdValidator : IValidator<int>
{
    public void Validate(int value)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(nameof(value), "Идентификатор должен быть больше нуля.");
    }
}
