using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class Locationvue
    {
        public int Id { get; set; }
        public int? NbPersonne { get; set; }
        public DateTime? DateArrivee { get; set; }
        public DateTime? DateArriveePrevue { get; set; }
        public DateTime? DateDepart { get; set; }
        public DateTime? DateDepartPrevue { get; set; }
        public string Modalite { get; set; }
        public string OrigineLocation { get; set; }
        public int? Reduction { get; set; }
        public string Observation { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ClNom { get; set; }
        public string ClPrenom { get; set; }
        public string ClNationalite { get; set; }
        public string ClEmail { get; set; }
        public DateTime? ClDateNaissance { get; set; }
        public string ClDomicileHabituel { get; set; }
        public string ClTel { get; set; }
        public string PaLibelle { get; set; }
        public int PaTaux { get; set; }
        public string EsNumero { get; set; }
        public string EsNom { get; set; }
        public string EsSituation { get; set; }
        public int? EsPrix { get; set; }
        public string EsDescription { get; set; }
        public string OrNom { get; set; }
        public string OrEmail { get; set; }
        public string OrTel { get; set; }
        public int? PrixApayer { get; set; }
        public int? OrId { get; set; }
        public int EsId { get; set; }
        public int PaId { get; set; }
        public int ClId { get; set; }
        public byte? EtatLocation { get; set; }
        public string OrAdresse { get; set; }
    }
}
