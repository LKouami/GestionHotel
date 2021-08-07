using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Dtos
{
    public class EtatEspaceDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("libelle")]
         public string Libelle { get; set; }
        [JsonProperty("valeur")]
        public int Valeur { get; set; }
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
