using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class SOrganismePayeur
    {
        public SOrganismePayeur()
        {
            SClient = new HashSet<SClient>();
            SLocation = new HashSet<SLocation>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Adresse { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SClient> SClient { get; set; }
        public virtual ICollection<SLocation> SLocation { get; set; }
    }
}
