using MediatR;

namespace GestionHotel.Domain.Events.Client
{
    public class ClientUpdatedEvent : INotification
    {
        public long ClientId { get; }

        public ClientUpdatedEvent(long clientId)
        {
            ClientId = clientId;
        }
    }
}