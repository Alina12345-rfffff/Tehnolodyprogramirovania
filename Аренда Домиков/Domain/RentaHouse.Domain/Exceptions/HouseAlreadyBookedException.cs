using System;

namespace RentaHouse.Domain.Exceptions;

public class HouseAlreadyBookedException(int houseId, DateTime date)
    : FormatException($"The house with ID {houseId} is already booked for {date.ToShortDateString()}.")
{
    public int HouseId => houseId;
    public DateTime Date => date;
}
