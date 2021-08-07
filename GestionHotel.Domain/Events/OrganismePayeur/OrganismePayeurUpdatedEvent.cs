using MediatR;

namespace GestionHotel.Domain.Events.OrganismePayeur
{
    public class OrganismePayeurUpdatedEvent : INotification
    {
        public long OrganismePayeurId { get; }

        public OrganismePayeurUpdatedEvent(long organismePayeurId)
        {
            OrganismePayeurId = organismePayeurId;
        }
    }
}