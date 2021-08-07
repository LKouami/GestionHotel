using System;
using System.Collections.Generic;
using System.Text;
using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;

namespace GestionHotel.Domain.Commands.TypeEspace
{
    public class CreateTypeEspaceCommand : CreateCommandBase<TypeEspaceDto>
    {
        public CreateTypeEspaceCommand() : base()
        {

        }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("nom")]
        public string Nom { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
