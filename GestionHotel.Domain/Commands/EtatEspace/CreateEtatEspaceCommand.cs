using Newtonsoft.Json;
using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.EtatEspace
{
   public class CreateEtatEspaceCommand : CreateCommandBase<EtatEspaceDto>
    {
        public CreateEtatEspaceCommand() : base()
        {

        }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("libelle")]
        public string Libelle { get; set; }
        [JsonProperty("valeur")]
        public int? Valeur { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
