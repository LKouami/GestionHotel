using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.Pack
{
    public class UpdatePackCommand : UpdateCommandBase<PackDto>
    {
        public UpdatePackCommand()
        {

        }
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("libelle")]
        public string Libelle { get; set; }

        [JsonProperty("taux")]
        public int Taux { get; set; }

        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
