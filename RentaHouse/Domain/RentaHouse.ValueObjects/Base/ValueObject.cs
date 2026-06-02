
using FluentValidation;
using АрендаДомика.ValueObjects.Base;

namespace RentaHouse.Domain.ValueObjects.Base;

public abstract class ValueObject<T>
{
    public T Value { get; }

    protected ValueObject(IValidator<T> validator, T value)
    {
        // Автоматическая валидация при создании любого Value Object
        validator.ValidateAndThrow(value);
        Value = value;
    }

    // Переопределяем методы для корректного сравнения VO по значению, а не по ссылке
    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType()) return false;
        return EqualityComparer<T>.Default.Equals(Value, ((ValueObject<T>)obj).Value);
    }

    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    public override string? ToString() => Value?.ToString();
}