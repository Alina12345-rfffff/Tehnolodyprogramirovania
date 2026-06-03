using System;

namespace RentaHouse.Domain.Exceptions
{
    /// <summary>
    /// Исключение, выбрасываемое при попытке забронировать уже занятый дом.
    /// </summary>
    public class HouseAlreadyBookedException(House house, Booking booking)
        : InvalidOperationException($"The house \"{house.Title}\" (ID = {house.Id}) is already booked for these dates by booking ID = {booking.Id}.")
    {
        public House House => house;
        public Booking Booking => booking;
    }
}