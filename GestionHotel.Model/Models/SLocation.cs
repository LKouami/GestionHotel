using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class SLocation
    {
        public int Id { get; set; }
        public int? NbPersonne { get; set; }
        public DateTime? DateArriveePrevue { get; set; }
        public DateTime? DateArrivee { get; set; }
        public DateTime? DateDepartPrevue { get; set; }
        public DateTime? DateDepart { get; set; }
        public string Modalite { get; set; }
        public string OrigineLocation { get; set; }
        public int? Reduction { get; set; }
        public int? PrixApayer { get; set; }
        public string Observation { get; set; }
        public int? OrganismePayeurId { get; set; }
        public int? ClientId { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? PackId { get; set; }
        public byte? EtatLocation { get; set; }
        public int? EspaceId { get; set; }

        public virtual SClient Client { get; set; }
        public virtual SEspace Espace { get; set; }
        public virtual SOrganismePayeur OrganismePayeur { get; set; }
        public virtual SPack Pack { get; set; }
    }
}
