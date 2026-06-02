
using RentaHouse.Domain.ValueObjects.Validators;
using АрендаДомика.ValueObjects.Base;

namespace RentaHouse.Domain.ValueObjects;

/// <summary>
/// Represents the unique identifier for a tenant in RentaHouse system.
/// </summary>
public class TenantId(int id) : ValueObject<int>(new IdValidator(), id);
