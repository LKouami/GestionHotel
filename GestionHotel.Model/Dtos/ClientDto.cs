using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Dtos
{
    public class ClientDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }
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
