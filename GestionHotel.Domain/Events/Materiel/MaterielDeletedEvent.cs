using MediatR;

namespace GestionHotel.Domain.Events.Materiel
{
    public class MaterielDeletedEvent : INotification
    {
        public long MaterielId { get; }

        public MaterielDeletedEvent(long materielId)
        {
            MaterielId = materielId;
        }
    }
}