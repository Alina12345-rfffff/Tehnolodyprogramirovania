namespace RentaHouse.ValueObjects.Base;

/// <summary>
/// Defines a method that implements the validation of a value.
/// </summary>
/// <typeparam name="T">The type of value to validate.</typeparam>
public interface IValidator<in T>
{
    void Validate(T value);
}