using System;
using System.Collections.Generic;
using System.Text;
using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;

namespace GestionHotel.Domain.Commands.EtatEspace
{
    public class CreateEtatEspaceCommand : CreateCommandBase<EtatEspaceDto>
    {
        public CreateEtatEspaceCommand() : base()
        {

        }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("libelle")]
         public string Libelle { get; set; }
        [JsonProperty("valeur")]
        public int Valeur { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
