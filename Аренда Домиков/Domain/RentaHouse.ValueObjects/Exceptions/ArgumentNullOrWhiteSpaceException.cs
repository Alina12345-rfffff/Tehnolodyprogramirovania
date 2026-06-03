namespace RentaHouse.ValueObjects.Exceptions;

/// <summary>
/// Исключение, выбрасываемое если строка пустая, равна null или состоит только из пробелов.
/// </summary>
public class ArgumentNullOrWhiteSpaceException(string paramName)
    : FormatException($"The \"{paramName}\" cannot be null or empty.")
{
    public string ParamName => paramName;
}
