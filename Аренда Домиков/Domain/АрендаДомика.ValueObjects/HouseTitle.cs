using АрендаДомика.ValueObjects.Base;

namespace АрендаДомика.ValueObjects;

public class HouseTitle : ValueObject<string>
{
    public HouseTitle(IValidator<string> validator, string value)
        : base(validator, value)
    {
    }
}
