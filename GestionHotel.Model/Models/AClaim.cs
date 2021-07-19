using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class AClaim
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public byte ClaimType { get; set; }
        public string Description { get; set; }
    }
}
