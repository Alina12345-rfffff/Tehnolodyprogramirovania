using System;

namespace RentaHouse.Domain.Exceptions;

public class AnotherTenantDeleteBookingException(int bookingId)
    : FormatException($"Another tenant is trying to delete the booking with ID {bookingId}.")
{
    public int BookingId => bookingId;
}
