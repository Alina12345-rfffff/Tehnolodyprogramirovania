using АрендаДомика.ValueObjects.Exceptions;
using АрендаДомика.ValueObjects.Base;

namespace АрендаДомика.ValueObjects.Validators;

public class EmailValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ValidatorNullException(nameof(value));

        if (!value.Contains("@") || !value.Contains("."))
            throw new DomainException("Неверный формат Email адреса.");
    }
}