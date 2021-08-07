using MediatR;

namespace GestionHotel.Domain.Events.Pack
{
    public class PackUpdatedEvent : INotification
    {
        public long PackId { get; }

        public PackUpdatedEvent(long packId)
        {
            PackId = packId;
        }
    }
}