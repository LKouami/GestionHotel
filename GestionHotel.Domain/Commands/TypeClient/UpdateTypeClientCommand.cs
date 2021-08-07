using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.TypeClient
{
    public class UpdateTypeClientCommand : UpdateCommandBase<TypeClientDto>
    {
        public UpdateTypeClientCommand()
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
