using System.Text.RegularExpressions;
using RentaHouse.ValueObjects.Base;
using RentaHouse.ValueObjects.Exceptions;

namespace RentaHouse.ValueObjects.Validators;

public class PhoneValidator : IValidator<string>
{
    private static readonly Regex PhoneRegex = new(@"^\+?[1-9]\d{1,14}$", RegexOptions.Compiled);

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullOrWhiteSpaceException(nameof(value));

        if (!PhoneRegex.IsMatch(value))
            throw new FormatException("Неверный формат номера телефона.");
    }
}
