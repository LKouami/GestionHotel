using MediatR;
using System;

namespace GestionHotel.Domain.Events.Materiel
{
    public class MaterielCreatedEvent : INotification
    {
        public Int64 MaterielId { get; }

        public MaterielCreatedEvent(Int64 materielId)
        {
            MaterielId = materielId;
        }
    }
}