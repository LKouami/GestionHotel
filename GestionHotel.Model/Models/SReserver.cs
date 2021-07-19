using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class SReserver
    {
        public int Id { get; set; }
        public int? NbPersonne { get; set; }
        public DateTime? DateArriveePrevue { get; set; }
        public DateTime? DateArrivee { get; set; }
        public DateTime? DateDepartPrevue { get; set; }
        public DateTime? DateDepart { get; set; }
        public string Modalite { get; set; }
        public string OrigineReservation { get; set; }
        public int? Reduction { get; set; }
        public string Observation { get; set; }
        public int ClientId { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? PromotionId { get; set; }
        public byte? EtatReservation { get; set; }
        public int? EspaceId { get; set; }
    }
}
