using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Dtos
{
    public class EspaceDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("numero")]
        public string Numero { get; set; }
        [JsonProperty("nom")]
        public string Nom { get; set; }
        [JsonProperty("situation")]
        public string Situation { get; set; }
        [JsonProperty("prix")]
        public int? Prix { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("typeEspaceId")]
        public int TypeEspaceId { get; set; }
        [JsonProperty("etatEspaceId")]
        public int EtatEspaceId { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }
        [JsonProperty("modifiedAt")]
        public DateTime ModifiedAt { get; set; }
        [JsonProperty("modifiedBy")]
        public int ModifiedBy { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("createdBy")]
        public int CreatedBy { get; set; }
    }
}
