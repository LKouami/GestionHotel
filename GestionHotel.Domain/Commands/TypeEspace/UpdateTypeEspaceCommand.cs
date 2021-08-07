using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.TypeEspace
{
    public class UpdateTypeEspaceCommand : UpdateCommandBase<TypeEspaceDto>
    {
        public UpdateTypeEspaceCommand()
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
