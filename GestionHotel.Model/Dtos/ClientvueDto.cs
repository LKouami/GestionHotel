using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Dtos
{
    public class ClientvueDto
    {
        [JsonProperty("tcId")]
        public int TcId { get; set; }
        [JsonProperty("tcNom")]
        public string TcNom { get; set; }
        [JsonProperty("tcStatus")]
        public byte TcStatus { get; set; }

        [JsonProperty("orId")]
        public string OrId { get; set; }

        [JsonProperty("orNom")]
        public string OrNom { get; set; }

        [JsonProperty("orEmail")]
        public string OrEmail { get; set; }

        [JsonProperty("orTel")]
        public string OrTel { get; set; }

        [JsonProperty("orAdresse")]
        public string OrAdresse { get; set; }

        [JsonProperty("orStatus")]
        public byte OrStatus { get; set; }

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
        public DateTime DateNaissance { get; set; }
        [JsonProperty("domicileHabituel")]
        public string DomicileHabituel { get; set; }
        [JsonProperty("tel")]
        public string Tel { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
