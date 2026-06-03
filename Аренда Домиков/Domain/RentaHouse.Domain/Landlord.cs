using System;
using RentaHouse.Domain.Base;
using RentaHouse.Domain.Exceptions;
using RentaHouse.ValueObjects;

namespace RentaHouse.Domain
{
    public class Landlord : Entity<LandlordId>
    {
        public LandlordName Name { get; private set; } = default!;
        public Email Email { get; private set; } = default!;
        public Phone Phone { get; private set; } = default!;

        protected Landlord() { }

        public Landlord(LandlordId id, LandlordName name, Email email, Phone phone) : base(id)
        {
            Name = name ?? throw new ArgumentNullValueException(nameof(name));
            Email = email ?? throw new ArgumentNullValueException(nameof(email));
            Phone = phone ?? throw new ArgumentNullValueException(nameof(phone));
        }

        public bool SetName(LandlordName newName)
        {
            if (newName == null) throw new ArgumentNullValueException(nameof(newName));
            if (Name == newName) return false;
            Name = newName;
            return true;
        }

        public bool SetEmail(Email newEmail)
        {
            if (newEmail == null) throw new ArgumentNullValueException(nameof(newEmail));
            if (Email == newEmail) return false;
            Email = newEmail;
            return true;
        }

        public bool SetPhone(Phone newPhone)
        {
            if (newPhone == null) throw new ArgumentNullValueException(nameof(newPhone));
            if (Phone == newPhone) return false;
            Phone = newPhone;
            return true;
        }
    }
}
