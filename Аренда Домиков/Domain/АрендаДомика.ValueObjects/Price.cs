using АрендаДомика.ValueObjects.Validators;

namespace АрендаДомика.ValueObjects;

public class Price : IEquatable<Price>
{
    private static readonly PriceValidator Validator = new();

    public decimal Amount { get; }
    public string Currency { get; }

    private Price(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Price Create(decimal amount, string currency = "RUB")
    {
        Validator.Validate(amount);
        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("Валюта должна быть указана.");

        return new Price(amount, currency.ToUpper().Trim());
    }


    public bool Equals(Price? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Amount == other.Amount && Currency == other.Currency;
    }

    public override bool Equals(object? obj) => Equals(obj as Price);

    public override int GetHashCode() => HashCode.Combine(Amount, Currency);

    public static bool operator ==(Price? left, Price? right) => Equals(left, right);
    public static bool operator !=(Price? left, Price? right) => !Equals(left, right);

    public override string ToString() => $"{Amount} {Currency}";
}