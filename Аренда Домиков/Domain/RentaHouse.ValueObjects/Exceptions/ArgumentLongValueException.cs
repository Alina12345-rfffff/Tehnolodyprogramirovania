namespace RentaHouse.ValueObjects.Exceptions;

/// <summary>
/// Исключение, выбрасываемое если длина строки превышает максимально допустимое значение.
/// </summary>
public class ArgumentLongValueException(string paramName, string value, int maxLength)
    : FormatException($"The \"{paramName}\" length {value.Length} greater than maximum allowed length {maxLength}")
{
    public string Value => value;
    public int MaxLength => maxLength;
}
