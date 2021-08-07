using MediatR;

namespace GestionHotel.Domain.Events.AffectationMateriel
{
    public class AffectationMaterielDeletedEvent : INotification
    {
        public long AffectationMaterielId { get; }

        public AffectationMaterielDeletedEvent(long affectationMaterielId)
        {
            AffectationMaterielId = affectationMaterielId;
        }
    }
}