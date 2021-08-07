using System;
using System.Linq;
using Newtonsoft.Json;

namespace GestionHotel.Model.Dtos
{
    public class AffectationMaterielvueDto
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

        [JsonProperty("maNom")]
        public string MaNom { get; set; }

        [JsonProperty("maQuantite")]
        public int? MaQuantite { get; set; }

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

       
    }
}