using System.Text.RegularExpressions;
using АрендаДомика.ValueObjects.Base;

namespace АрендаДомика.ValueObjects.Validators;

public class EmailValidator : IValidator<string>
{
    private static readonly Regex EmailRegex = new(
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase
    );

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Email не может быть пустым.");

        if (!EmailRegex.IsMatch(value))
            throw new ArgumentException("Некорректный формат Email адреса.");
    }
}
