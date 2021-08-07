using System;
using System.Linq;
using Newtonsoft.Json;

namespace GestionHotel.Model.Dtos
{
    public class OrganismePayeurDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nom")]
        public string Nom { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("tel")]
        public string Tel { get; set; }

        [JsonProperty("adresse")]
        public string Adresse { get; set; }

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