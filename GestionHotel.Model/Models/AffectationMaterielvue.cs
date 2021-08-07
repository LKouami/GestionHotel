using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class AffectationMaterielvue
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
        public string MaNom { get; set; }
        public int? MaQuantite { get; set; }
        public string EsNumero { get; set; }
        public string EsNom { get; set; }
        public string EsSituation { get; set; }
        public int? EsPrix { get; set; }
        public string EsDescription { get; set; }
    }
}
