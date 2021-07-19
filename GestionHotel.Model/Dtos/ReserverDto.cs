using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Dtos
{
    public class ReserverDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("nbPersonne")]
        public int? NbPersonne { get; set; }
        [JsonProperty("dateArriveePrevue")]
        public DateTime? DateArriveePrevue { get; set; }
        [JsonProperty("dateArrivee")]
        public DateTime? DateArrivee { get; set; }
        [JsonProperty("dateDepartPrevue")]
        public DateTime? DateDepartPrevue { get; set; }
        [JsonProperty("dateDepart")]
        public DateTime? DateDepart { get; set; }
        [JsonProperty("modalite")]
        public string Modalite { get; set; }
        [JsonProperty("origineReservation")]
        public string OrigineReservation { get; set; }
        [JsonProperty("reduction")]
        public int? Reduction { get; set; }
        [JsonProperty("observation")]
        public string Observation { get; set; }
        [JsonProperty("clientId")]
        public int ClientId { get; set; }
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
