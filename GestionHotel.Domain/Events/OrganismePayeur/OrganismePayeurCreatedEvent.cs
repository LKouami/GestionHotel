using MediatR;
using System;

namespace GestionHotel.Domain.Events.OrganismePayeur
{
    public class OrganismePayeurCreatedEvent : INotification
    {
        public Int64 OrganismePayeurId { get; }

        public OrganismePayeurCreatedEvent(Int64 organismePayeurId)
        {
            OrganismePayeurId = organismePayeurId;
        }
    }
}