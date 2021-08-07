using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.OrganismePayeur
{
    public class UpdateOrganismePayeurCommand : UpdateCommandBase<OrganismePayeurDto>
    {
        public UpdateOrganismePayeurCommand()
        {

        }
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nom")]
        public string Nom { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("tel")]
        public string Tel { get; set; }

        [JsonProperty("adresse")]
        public string Adresse { get; set; }

        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
