using АрендаДомика.ValueObjects.Exceptions;
using АрендаДомика.ValueObjects.Base;

namespace АрендаДомика.ValueObjects.Validators;

public class HouseTitleValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ValidatorNullException(nameof(value));

        if (value.Length < 3 || value.Length > 100)
            throw new DomainException("Название дома должно быть от 3 до 100 символов.");
    }
}