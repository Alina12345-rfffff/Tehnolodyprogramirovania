using FluentValidation;

namespace RentaHouse.Domain.ValueObjects.Validators;

public class PriceValidator : AbstractValidator<decimal>
{
    public PriceValidator()
    {
        RuleFor(price => price)
            .GreaterThanOrEqualTo(0).WithMessage("Цена не может быть отрицательной.");
    }
}
