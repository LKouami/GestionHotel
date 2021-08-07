using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Dtos
{
    public class AffectationMaterielDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("materielId")]
        public int MaterielId { get; set; }
        [JsonProperty("espaceId")]
        public int EspaceId { get; set; }
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
