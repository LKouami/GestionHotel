using MediatR;

namespace GestionHotel.Domain.Events.Location
{
    public class LocationDeletedEvent : INotification
    {
        public long LocationId { get; }

        public LocationDeletedEvent(long locationId)
        {
            LocationId = locationId;
        }
    }
}