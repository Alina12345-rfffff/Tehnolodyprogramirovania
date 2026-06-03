
namespace RentaHouse.Domain.ValueObjects;

/// <summary>
/// Represents a validated email address.
/// </summary>
public class Email(string email) : ValueObject<string>(new EmailValidator(), email);
