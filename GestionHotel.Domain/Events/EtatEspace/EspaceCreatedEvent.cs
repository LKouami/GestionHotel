using MediatR;
using System;

namespace GestionHotel.Domain.Events.EtatEspace
{
    public class EtatEspaceCreatedEvent : INotification
    {
        public Int64 EtatEspaceId { get; }

        public EtatEspaceCreatedEvent(Int64 etatEspaceId)
        {
            EtatEspaceId = etatEspaceId;
        }
    }
}