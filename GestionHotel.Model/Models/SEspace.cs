using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class SEspace
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Nom { get; set; }
        public string Situation { get; set; }
        public int? Prix { get; set; }
        public string Description { get; set; }
        public int TypeEspaceId { get; set; }
        public int EtatEspaceId { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
