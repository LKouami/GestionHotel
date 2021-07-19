using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class ARoleClaim
    {
        public byte RoleId { get; set; }
        public byte ClaimId { get; set; }
        public string ClaimValue { get; set; }
    }
}
