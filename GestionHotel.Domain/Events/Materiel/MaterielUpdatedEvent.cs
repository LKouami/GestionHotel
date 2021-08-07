using MediatR;

namespace GestionHotel.Domain.Events.Materiel
{
    public class MaterielUpdatedEvent : INotification
    {
        public long MaterielId { get; }

        public MaterielUpdatedEvent(long materielId)
        {
            MaterielId = materielId;
        }
    }
}