using System;
using System.Linq;
using Newtonsoft.Json;

namespace GestionHotel.Model.Dtos
{
    public class LocationDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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

        [JsonProperty("origineLocation")]
        public string OrigineLocation { get; set; }

        [JsonProperty("reduction")]
        public int? Reduction { get; set; }

        [JsonProperty("prixAPayer")]
        public int? PrixApayer { get; set; }

        [JsonProperty("observation")]
        public string Observation { get; set; }

        [JsonProperty("organismePayeurId")]
        public int OrganismePayeurId { get; set; }

        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("status")]
        public byte Status { get; set; }

        [JsonProperty("createdBy")]
        public int CreatedBy { get; set; }

        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public int ModifiedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public DateTime ModifiedAt { get; set; }

        [JsonProperty("deletedBy")]
        public int? DeletedBy { get; set; }

        [JsonProperty("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        [JsonProperty("packId")]
        public int? PackId { get; set; }

        [JsonProperty("etatLocation")]
        public byte? EtatLocation { get; set; }

        [JsonProperty("espaceId")]
        public int? EspaceId { get; set; }

        
    }
}