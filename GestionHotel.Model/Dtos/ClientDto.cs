using System;
using System.Linq;
using Newtonsoft.Json;

namespace GestionHotel.Model.Dtos
{
    public class ClientDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nom")]
        public string Nom { get; set; }

        [JsonProperty("prenom")]
        public string Prenom { get; set; }

        [JsonProperty("nationalite")]
        public string Nationalite { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("dateNaissance")]
        public DateTime? DateNaissance { get; set; }

        [JsonProperty("domicileHabituel")]
        public string DomicileHabituel { get; set; }

        [JsonProperty("tel")]
        public string Tel { get; set; }

        [JsonProperty("typeClientId")]
        public int TypeClientId { get; set; }

        [JsonProperty("organismeId")]
        public int? OrganismeId { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }

        [JsonProperty("createdBy")]
        public int CreatedBy { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public int ModifiedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public DateTime ModifiedAt { get; set; }

        [JsonProperty("deletedBy")]
        public int? DeletedBy { get; set; }

        [JsonProperty("deletedAt")]
        public DateTime? DeletedAt { get; set; }

    }
       
}