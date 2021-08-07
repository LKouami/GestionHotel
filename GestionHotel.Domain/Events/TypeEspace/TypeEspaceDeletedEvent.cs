using MediatR;

namespace GestionHotel.Domain.Events.TypeEspace
{
    public class TypeEspaceDeletedEvent : INotification
    {
        public long TypeEspaceId { get; }

        public TypeEspaceDeletedEvent(long typeEspaceId)
        {
            TypeEspaceId = typeEspaceId;
        }
    }
}