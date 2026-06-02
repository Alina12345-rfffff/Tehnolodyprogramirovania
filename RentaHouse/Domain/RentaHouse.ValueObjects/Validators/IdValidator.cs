using FluentValidation;

namespace RentaHouse.Domain.ValueObjects.Validators;

public class IdValidator : AbstractValidator<int>
{
    public IdValidator()
    {
        RuleFor(id => id).GreaterThan(0).WithMessage("Идентификатор должен быть больше 0.");
    }
}
