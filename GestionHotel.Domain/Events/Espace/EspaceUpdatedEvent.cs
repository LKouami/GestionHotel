using MediatR;

namespace GestionHotel.Domain.Events.Espace
{
    public class EspaceUpdatedEvent : INotification
    {
        public long EspaceId { get; }

        public EspaceUpdatedEvent(long espaceId)
        {
            EspaceId = espaceId;
        }
    }
}