using System;

namespace RentaHouse.Domain.Exceptions
{
    /// <summary>
    /// Исключение, выбрасываемое при попытке стороннего арендатора отредактировать чужое бронирование.
    /// </summary>
    public class AnotherTenantEditBookingException(int bookingId)
        : InvalidOperationException($"Another tenant is trying to edit the booking with ID {bookingId}.")
    {
        public int BookingId => bookingId;
    }
}