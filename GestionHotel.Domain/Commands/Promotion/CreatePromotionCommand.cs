using Newtonsoft.Json;
using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.Promotion
{
   public class CreatePromotionCommand : CreateCommandBase<PromotionDto>
    {
        public CreatePromotionCommand() : base()
        {

        }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("libelle")]
        public string Libelle { get; set; }
        [JsonProperty("taux")]
        public int Taux { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
