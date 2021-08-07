using MediatR;

namespace GestionHotel.Domain.Events.Client
{
    public class ClientDeletedEvent : INotification
    {
        public long ClientId { get; }

        public ClientDeletedEvent(long clientId)
        {
            ClientId = clientId;
        }
    }
}