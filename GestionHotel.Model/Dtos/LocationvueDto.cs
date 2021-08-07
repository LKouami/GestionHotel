using System;
using System.Linq;
using Newtonsoft.Json;

namespace GestionHotel.Model.Dtos
{
    public class LocationvueDto
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

        [JsonProperty("observation")]
        public string Observation { get; set; }

        [JsonProperty("prixAPayer")]
        public int? PrixApayer { get; set; }

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

        [JsonProperty("clNom")]
        public string ClNom { get; set; }

        [JsonProperty("clPrenom")]
        public string ClPrenom { get; set; }

        [JsonProperty("clNationalite")]
        public string ClNationalite { get; set; }

        [JsonProperty("clEmail")]
        public string ClEmail { get; set; }

        [JsonProperty("clDateNaissance")]
        public DateTime? ClDateNaissance { get; set; }

        [JsonProperty("clDomicileHabituel")]
        public string ClDomicileHabituel { get; set; }

        [JsonProperty("clTel")]
        public string ClTel { get; set; }

        [JsonProperty("paLibelle")]
        public string PaLibelle { get; set; }

        [JsonProperty("paTaux")]
        public int PaTaux { get; set; }

        [JsonProperty("esNumero")]
        public string EsNumero { get; set; }

        [JsonProperty("esNom")]
        public string EsNom { get; set; }

        [JsonProperty("esSituation")]
        public string EsSituation { get; set; }

        [JsonProperty("esPrix")]
        public int? EsPrix { get; set; }

        [JsonProperty("esDescription")]
        public string EsDescription { get; set; }

        [JsonProperty("orNom")]
        public string OrNom { get; set; }

        [JsonProperty("orEmail")]
        public string OrEmail { get; set; }

        [JsonProperty("orTel")]
        public string OrTel { get; set; }

        [JsonProperty("esId")]
        public int EsId { get; set; }

        [JsonProperty("orId")]
        public int OrId { get; set; }

        [JsonProperty("paId")]
        public int PaId { get; set; }

        [JsonProperty("clId")]
        public int ClId { get; set; }

        [JsonProperty("etatLocation")]
        public byte? EtatLocation { get; set; }

        [JsonProperty("orAdresse")]
        public string OrAdresse { get; set; }

    }
}