using System;
using System.Collections.Generic;
using System.Text;
using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;

namespace GestionHotel.Domain.Commands.Materiel
{
    public class CreateMaterielCommand : CreateCommandBase<MaterielDto>
    {
        public CreateMaterielCommand() : base()
        {

        }
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nom")]
        public string Nom { get; set; }

        [JsonProperty("quantite")]
        public int? Quantite { get; set; }

        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
