using АрендаДомика.ValueObjects.Base;
using АрендаДомика.ValueObjects.Validators;

namespace АрендаДомика.ValueObjects;

public class HouseTitle : ValueObject<string>
{
    private static readonly HouseTitleValidator Validator = new();

    protected HouseTitle(string value) : base(Validator, value)
    {
    }

    public static HouseTitle Create(string value)
    {
        return new HouseTitle(value.Trim());
    }
}