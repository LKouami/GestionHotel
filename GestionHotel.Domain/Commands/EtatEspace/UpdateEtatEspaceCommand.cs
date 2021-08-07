using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.EtatEspace
{
    public class UpdateEtatEspaceCommand : UpdateCommandBase<EtatEspaceDto>
    {
        public UpdateEtatEspaceCommand()
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
