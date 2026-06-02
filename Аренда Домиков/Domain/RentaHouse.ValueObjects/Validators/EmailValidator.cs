using System.Text.RegularExpressions;
using RentaHouse.ValueObjects.Base;
using RentaHouse.ValueObjects.Exceptions;

namespace RentaHouse.ValueObjects.Validators;

public class EmailValidator : IValidator<string>
{
    private static readonly Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullOrWhiteSpaceException(nameof(value));

        if (!EmailRegex.IsMatch(value))
            throw new FormatException("Неверный формат адреса электронной почты.");
    }
}
