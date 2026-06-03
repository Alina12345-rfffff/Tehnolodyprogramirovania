using System;
using RentaHouse.Domain.Base;
using RentaHouse.Domain.Exceptions;
using RentaHouse.ValueObjects;

namespace RentaHouse.Domain
{
    public class House : Entity<HouseId>
    {
        public Landlord Landlord { get; } = default!;
        public HouseTitle Title { get; private set; } = default!;
        public HouseDescription Description { get; private set; } = default!;
        public Address Address { get; private set; } = default!;
        public Price Price { get; private set; } = default!;

        protected House() { }

        public House(HouseId id, Landlord landlord, HouseTitle title, HouseDescription description, Address address, Price price) : base(id)
        {
            Landlord = landlord ?? throw new ArgumentNullValueException(nameof(landlord));
            Title = title ?? throw new ArgumentNullValueException(nameof(title));
            Description = description ?? throw new ArgumentNullValueException(nameof(description));
            Address = address ?? throw new ArgumentNullValueException(nameof(address));
            Price = price ?? throw new ArgumentNullValueException(nameof(price));
        }

        public bool SetTitle(HouseTitle newTitle)
        {
            if (newTitle == null) throw new ArgumentNullValueException(nameof(newTitle));
            if (Title == newTitle) return false;
            Title = newTitle;
            return true;
        }

        public bool SetDescription(HouseDescription newDescription)
        {
            if (newDescription == null) throw new ArgumentNullValueException(nameof(newDescription));
            if (Description == newDescription) return false;
            Description = newDescription;
            return true;
        }

        public bool SetAddress(Address newAddress)
        {
            if (newAddress == null) throw new ArgumentNullValueException(nameof(newAddress));
            if (Address == newAddress) return false;
            Address = newAddress;
            return true;
        }

        public bool SetPrice(Price newPrice)
        {
            if (newPrice == null) throw new ArgumentNullValueException(nameof(newPrice));
            if (Price == newPrice) return false;
            Price = newPrice;
            return true;
        }
    }
}
