using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class SClient
    {
        public SClient()
        {
            SLocation = new HashSet<SLocation>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Nationalite { get; set; }
        public string Email { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string DomicileHabituel { get; set; }
        public string Tel { get; set; }
        public int TypeClientId { get; set; }
        public int? OrganismeId { get; set; }
        public byte Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual SOrganismePayeur Organisme { get; set; }
        public virtual STypeClient TypeClient { get; set; }
        public virtual ICollection<SLocation> SLocation { get; set; }
    }
}
