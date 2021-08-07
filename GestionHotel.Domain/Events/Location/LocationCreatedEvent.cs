using MediatR;
using System;

namespace GestionHotel.Domain.Events.Location
{
    public class LocationCreatedEvent : INotification
    {
        public Int64 LocationId { get; }

        public LocationCreatedEvent(Int64 locationId)
        {
            LocationId = locationId;
        }
    }
}