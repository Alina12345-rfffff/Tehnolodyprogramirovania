using АрендаДомика.ValueObjects.Base;
using АрендаДомика.ValueObjects.Validators;

namespace АрендаДомика.ValueObjects;

public class Email : ValueObject<string>
{
    private static readonly EmailValidator Validator = new();

    protected Email(string value) : base(Validator, value)
    {
    }

    public static Email Create(string value)
    {
        var normalizedValue = value.Trim().ToLower();
        return new Email(normalizedValue);
    }
}