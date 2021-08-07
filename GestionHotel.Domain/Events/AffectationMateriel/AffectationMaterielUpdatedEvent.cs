using MediatR;

namespace GestionHotel.Domain.Events.AffectationMateriel
{
    public class AffectationMaterielUpdatedEvent : INotification
    {
        public long AffectationMaterielId { get; }

        public AffectationMaterielUpdatedEvent(long affectationMaterielId)
        {
            AffectationMaterielId = affectationMaterielId;
        }
    }
}