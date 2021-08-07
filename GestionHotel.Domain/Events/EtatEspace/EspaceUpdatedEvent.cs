using MediatR;

namespace GestionHotel.Domain.Events.EtatEspace
{
    public class EtatEspaceUpdatedEvent : INotification
    {
        public long EtatEspaceId { get; }

        public EtatEspaceUpdatedEvent(long etatEspaceId)
        {
            EtatEspaceId = etatEspaceId;
        }
    }
}