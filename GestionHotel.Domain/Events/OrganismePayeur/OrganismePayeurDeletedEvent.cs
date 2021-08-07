using MediatR;

namespace GestionHotel.Domain.Events.OrganismePayeur
{
    public class OrganismePayeurDeletedEvent : INotification
    {
        public long OrganismePayeurId { get; }

        public OrganismePayeurDeletedEvent(long organismePayeurId)
        {
            OrganismePayeurId = organismePayeurId;
        }
    }
}