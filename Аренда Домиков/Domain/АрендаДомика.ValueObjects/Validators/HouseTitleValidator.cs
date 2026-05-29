using АрендаДомика.ValueObjects.Base;

namespace АрендаДомика.ValueObjects.Validators;

public class HouseTitleValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Название домика не может быть пустым.");

        if (value.Length > 100)
            throw new ArgumentException("Название домика не должно превышать 100 символов.");
    }
}