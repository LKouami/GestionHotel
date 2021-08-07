using MediatR;

namespace GestionHotel.Domain.Events.TypeEspace
{
    public class TypeEspaceUpdatedEvent : INotification
    {
        public long TypeEspaceId { get; }

        public TypeEspaceUpdatedEvent(long typeEspaceId)
        {
            TypeEspaceId = typeEspaceId;
        }
    }
}