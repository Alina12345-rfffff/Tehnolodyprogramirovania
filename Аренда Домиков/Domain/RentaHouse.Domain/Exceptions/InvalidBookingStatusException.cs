using System;

namespace RentaHouse.Domain.Exceptions;

public class InvalidBookingStatusException(string currentStatus, string targetStatus)
    : FormatException($"Cannot change booking status from \"{currentStatus}\" to \"{targetStatus}\".")
{
    public string CurrentStatus => currentStatus;
    public string TargetStatus => targetStatus;
}
