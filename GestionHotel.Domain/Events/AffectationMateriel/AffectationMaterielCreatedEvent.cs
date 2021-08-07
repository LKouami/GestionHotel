using MediatR;
using System;

namespace GestionHotel.Domain.Events.AffectationMateriel
{
    public class AffectationMaterielCreatedEvent : INotification
    {
        public Int64 AffectationMaterielId { get; }

        public AffectationMaterielCreatedEvent(Int64 affectationMaterielId)
        {
            AffectationMaterielId = affectationMaterielId;
        }
    }
}