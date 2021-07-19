using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class STypeEspace
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
