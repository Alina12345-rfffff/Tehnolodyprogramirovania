using System;

namespace RentaHouse.Domain.Exceptions
{
    /// <summary>
    /// Исключение, выбрасываемое при попытке установить недопустимый статус бронирования.
    /// </summary>
    public class InvalidBookingStatusException(Booking booking, string invalidStatus)
        : ArgumentException($"The booking status \"{invalidStatus}\" is not correct for booking ID = {booking.Id}.")
    {
        public Booking Booking => booking;
        public string InvalidStatus => invalidStatus;
    }
}