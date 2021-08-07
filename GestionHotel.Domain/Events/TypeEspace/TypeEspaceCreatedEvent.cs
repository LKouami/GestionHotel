using MediatR;
using System;

namespace GestionHotel.Domain.Events.TypeEspace
{
    public class TypeEspaceCreatedEvent : INotification
    {
        public Int64 TypeEspaceId { get; }

        public TypeEspaceCreatedEvent(Int64 typeEspaceId)
        {
            TypeEspaceId = typeEspaceId;
        }
    }
}