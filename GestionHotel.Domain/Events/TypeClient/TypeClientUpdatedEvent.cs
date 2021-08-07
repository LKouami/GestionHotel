using MediatR;

namespace GestionHotel.Domain.Events.TypeClient
{
    public class TypeClientUpdatedEvent : INotification
    {
        public long TypeClientId { get; }

        public TypeClientUpdatedEvent(long typeClientId)
        {
            TypeClientId = typeClientId;
        }
    }
}