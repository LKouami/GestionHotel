using MediatR;

namespace GestionHotel.Domain.Events.EtatEspace
{
    public class EtatEspaceDeletedEvent : INotification
    {
        public long EtatEspaceId { get; }

        public EtatEspaceDeletedEvent(long etatEspaceId)
        {
            EtatEspaceId = etatEspaceId;
        }
    }
}