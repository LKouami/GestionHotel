using MediatR;
using System;

namespace GestionHotel.Domain.Events.Client
{
    public class ClientCreatedEvent : INotification
    {
        public Int64 ClientId { get; }

        public ClientCreatedEvent(Int64 clientId)
        {
            ClientId = clientId;
        }
    }
}