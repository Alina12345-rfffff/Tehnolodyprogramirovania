namespace RentaHouse.ValueObjects.Exceptions;

/// <summary>
/// Исключение, выбрасываемое если длина строки меньше минимально допустимого значения.
/// </summary>
public class ArgumentShortValueException(string paramName, string value, int minLength)
    : FormatException($"The \"{paramName}\" length {value.Length} less than minimum required length {minLength}")
{
    public string Value => value;
    public int MinLength => minLength;
}
