using System;

namespace RentaHouse.Domain.Exceptions
{
    /// <summary>
    /// Исключение, выбрасываемое если бронирование не принадлежит указанному арендатору.
    /// </summary>
    public class BookingNotBelongTenantException(Booking booking, Tenant tenant)
        : InvalidOperationException($"The booking with ID {booking.Id} does not belong to the tenant {tenant.Name} (tenant ID = {tenant.Id}).")
    {
        public Booking Booking => booking;
        public Tenant Tenant => tenant;
    }
}