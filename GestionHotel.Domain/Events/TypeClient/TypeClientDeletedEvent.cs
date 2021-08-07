using MediatR;

namespace GestionHotel.Domain.Events.TypeClient
{
    public class TypeClientDeletedEvent : INotification
    {
        public long TypeClientId { get; }

        public TypeClientDeletedEvent(long typeClientId)
        {
            TypeClientId = typeClientId;
        }
    }
}