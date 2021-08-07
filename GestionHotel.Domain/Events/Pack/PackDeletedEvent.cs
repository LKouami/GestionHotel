using MediatR;

namespace GestionHotel.Domain.Events.Pack
{
    public class PackDeletedEvent : INotification
    {
        public long PackId { get; }

        public PackDeletedEvent(long packId)
        {
            PackId = packId;
        }
    }
}