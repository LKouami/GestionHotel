using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class AUserClaim
    {
        public int UserId { get; set; }
        public byte ClaimId { get; set; }
        public string ClaimValue { get; set; }
    }
}
