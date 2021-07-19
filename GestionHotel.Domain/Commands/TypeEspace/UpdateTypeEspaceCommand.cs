using Newtonsoft.Json;
using GestionHotel.Model;
using GestionHotel.Model.Dtos;
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
        public long Id { get; set; }
        [JsonProperty("nom")]
        public string Nom { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
