using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;
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
        public int Id { get; set; }
        [JsonProperty("typeClientId")]
        public int TypeClientId { get; set; }
        [JsonProperty("organismeId")]
        public int? OrganismeId { get; set; }
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
