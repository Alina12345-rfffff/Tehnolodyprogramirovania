using АрендаДомика.ValueObjects.Base;

namespace АрендаДомика.ValueObjects;

public class Email : ValueObject<string>
{
    public Email(IValidator<string> validator, string value)
        : base(validator, value)
    {
    }
}