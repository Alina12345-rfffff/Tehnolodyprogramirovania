using RentaHouse.ValueObjects.Exceptions;

namespace RentaHouse.ValueObjects.Base;

public abstract class ValueObject<T>
{
    public T Value { get; }

    protected ValueObject(IValidator<T> validator, T value)
    {
        if (validator is null)
            throw new ValidatorNullException(nameof(validator));

        validator.Validate(value);
        Value = value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType()) return false;
        return EqualityComparer<T>.Default.Equals(Value, ((ValueObject<T>)obj).Value);
    }

    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public override string? ToString() => Value?.ToString();
}
