using System;

namespace RentaHouse.Domain.Exceptions;

public class AnotherTenantEditBookingException(int bookingId)
    : FormatException($"Another tenant is trying to edit the booking with ID {bookingId}.")
{
    public int BookingId => bookingId;
}
