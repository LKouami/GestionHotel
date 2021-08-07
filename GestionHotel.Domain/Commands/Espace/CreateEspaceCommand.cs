using System;
using System.Collections.Generic;
using System.Text;
using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;

namespace GestionHotel.Domain.Commands.Espace
{
    public class CreateEspaceCommand : CreateCommandBase<EspaceDto>
    {
        public CreateEspaceCommand() : base()
        {

        }
         [JsonProperty("id")]
        public int Id { get; set; }

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
    }
}
