using Newtonsoft.Json;
using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.Client
{
    public class UpdateClientCommand : UpdateCommandBase<ClientDto>
    {
        public UpdateClientCommand()
        {

        }
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
    }
}
