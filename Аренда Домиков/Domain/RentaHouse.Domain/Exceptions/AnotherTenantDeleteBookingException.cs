using System;

namespace RentaHouse.Domain.Exceptions
{
    /// <summary>
    /// Исключение, выбрасываемое при попытке стороннего арендатора удалить чужое бронирование.
    /// </summary>
    public class AnotherTenantDeleteBookingException(int bookingId)
        : InvalidOperationException($"Another tenant is trying to delete the booking with ID {bookingId}.")
    {
        public int BookingId => bookingId;
    }
}