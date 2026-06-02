using RentaHouse.Domain.ValueObjects.Base;
using RentaHouse.Domain.ValueObjects.Validators;

namespace RentaHouse.Domain.ValueObjects;

/// <summary>
/// Represents the rental price of a house.
/// </summary>
public class Price(decimal price) : ValueObject<decimal>(new PriceValidator(), price);
