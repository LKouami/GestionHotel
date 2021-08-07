using MediatR;
using System;

namespace GestionHotel.Domain.Events.Espace
{
    public class EspaceCreatedEvent : INotification
    {
        public Int64 EspaceId { get; }

        public EspaceCreatedEvent(Int64 espaceId)
        {
            EspaceId = espaceId;
        }
    }
}