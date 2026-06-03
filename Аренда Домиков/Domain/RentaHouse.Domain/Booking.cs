using System;
using RentaHouse.Domain.Base;
using RentaHouse.Domain.Exceptions;
using RentaHouse.ValueObjects;

namespace RentaHouse.Domain
{
    public class Booking : Entity<BookingId>
    {
        public Tenant Tenant { get; } = default!;
        public House House { get; } = default!;
        public DateTime BookingDate { get; }
        public BookingStatus Status { get; private set; } = default!;

        protected Booking() { }

        public Booking(BookingId id, Tenant tenant, House house, DateTime bookingDate, BookingStatus status) : base(id)
        {
            Tenant = tenant ?? throw new ArgumentNullValueException(nameof(tenant));
            House = house ?? throw new ArgumentNullValueException(nameof(house));
            BookingStatus = status ?? throw new ArgumentNullValueException(nameof(status));

            // Простая валидация даты (например, дата бронирования не может быть из глубокого прошлого)
            if (bookingDate == default) throw new ArgumentException("Invalid booking date.", nameof(bookingDate));
            BookingDate = bookingDate;
        }

        public bool SetStatus(BookingStatus newStatus)
        {
            if (newStatus == null) throw new ArgumentNullValueException(nameof(newStatus));
            if (Status == newStatus) return false;
            Status = newStatus;
            return true;
        }
    }
}