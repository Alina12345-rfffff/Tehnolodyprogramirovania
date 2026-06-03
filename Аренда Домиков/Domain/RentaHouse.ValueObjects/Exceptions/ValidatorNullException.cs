namespace RentaHouse.ValueObjects.Exceptions;

/// <summary>
/// Исключение, выбрасываемое если переданный валидатор равен null.
/// </summary>
public class ValidatorNullException(string paramName)
    : FormatException($"The validator \"{paramName}\" cannot be null.")
{
    public string ParamName => paramName;
}
