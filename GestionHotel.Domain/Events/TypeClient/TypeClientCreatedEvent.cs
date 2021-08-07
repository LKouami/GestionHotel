using MediatR;
using System;

namespace GestionHotel.Domain.Events.TypeClient
{
    public class TypeClientCreatedEvent : INotification
    {
        public Int64 TypeClientId { get; }

        public TypeClientCreatedEvent(Int64 typeClientId)
        {
            TypeClientId = typeClientId;
        }
    }
}