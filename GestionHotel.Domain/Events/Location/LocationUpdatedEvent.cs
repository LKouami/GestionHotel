using MediatR;

namespace GestionHotel.Domain.Events.Location
{
    public class LocationUpdatedEvent : INotification
    {
        public long LocationId { get; }

        public LocationUpdatedEvent(long locationId)
        {
            LocationId = locationId;
        }
    }
}