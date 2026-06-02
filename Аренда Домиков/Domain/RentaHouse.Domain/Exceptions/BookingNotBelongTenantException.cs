using System;

namespace RentaHouse.Domain.Exceptions;

public class BookingNotBelongTenantException(int bookingId, int tenantId)
    : FormatException($"The booking with ID {bookingId} does not belong to tenant with ID {tenantId}.")
{
    public int BookingId => bookingId;
    public int TenantId => tenantId;
}
