using MediatR;

namespace GestionHotel.Domain.Events.Espace
{
    public class EspaceDeletedEvent : INotification
    {
        public long EspaceId { get; }

        public EspaceDeletedEvent(long espaceId)
        {
            EspaceId = espaceId;
        }
    }
}