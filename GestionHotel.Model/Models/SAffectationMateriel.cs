using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class SAffectationMateriel
    {
        public int Id { get; set; }
        public int MaterielId { get; set; }
        public int EspaceId { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual SEspace Espace { get; set; }
        public virtual SMateriel Materiel { get; set; }
    }
}
