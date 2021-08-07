using System;
using System.Collections.Generic;
using System.Text;
using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;

namespace GestionHotel.Domain.Commands.Pack
{
    public class CreatePackCommand : CreateCommandBase<PackDto>
    {
        public CreatePackCommand() : base()
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
