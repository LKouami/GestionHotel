using MediatR;
using System;

namespace GestionHotel.Domain.Events.Pack
{
    public class PackCreatedEvent : INotification
    {
        public Int64 PackId { get; }

        public PackCreatedEvent(Int64 packId)
        {
            PackId = packId;
        }
    }
}