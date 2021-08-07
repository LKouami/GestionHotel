using System;
using System.Collections.Generic;
using System.Text;
using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;

namespace GestionHotel.Domain.Commands.AffectationMateriel
{
    public class CreateAffectationMaterielCommand : CreateCommandBase<AffectationMaterielDto>
    {
        public CreateAffectationMaterielCommand() : base()
        {

        }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("materielId")]
        public int MaterielId { get; set; }
        [JsonProperty("espaceId")]
        public int EspaceId { get; set; }

        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
