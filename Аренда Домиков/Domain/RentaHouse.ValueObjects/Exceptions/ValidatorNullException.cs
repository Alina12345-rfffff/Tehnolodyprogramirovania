namespace RentaHouse.ValueObjects.Exceptions;

/// <summary>
/// Исключение, выбрасываемое если строка пустая, равна null или состоит только из пробелов.
/// </summary>
public class ArgumentNullOrWhiteSpaceException(string paramName)
    : FormatException($"The \"{paramName}\" cannot be null or empty.")
{
    public string ParamName => paramName;
}

/// <summary>
/// Исключение, выбрасываемое если длина строки превышает максимально допустимое значение.
/// </summary>
public class ArgumentLongValueException(string paramName, string value, int maxLength)
    : FormatException($"The \"{paramName}\" length {value} greater than maximum allowed length {maxLength}")
{
    public string Value => value;
    public int MaxLength => maxLength;
}

/// <summary>
/// Исключение, выбрасываемое если длина строки меньше минимально допустимого значения.
/// </summary>
public class ArgumentShortValueException(string paramName, string value, int minLength)
    : FormatException($"The \"{paramName}\" length {value} less than minimum required length {minLength}")
{
    public string Value => value;
    public int MinLength => minLength;
}
