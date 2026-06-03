using System;

namespace RentaHouse.Domain.Exceptions
{
    /// <summary>
    /// Исключение, выбрасываемое если объект или значение доменной сущности равно null.
    /// </summary>
    public class ArgumentNullValueException(string paramName)
        : ArgumentNullException(paramName, $"The domain argument \"{paramName}\" cannot be null.");
}