using System;
using System.Collections.Generic;
using System.Text;
using GestionHotel.Domain.Commands.Common;
using GestionHotel.Model.Dtos;
using Newtonsoft.Json;

namespace GestionHotel.Domain.Commands.OrganismePayeur
{
    public class CreateOrganismePayeurCommand : CreateCommandBase<OrganismePayeurDto>
    {
        public CreateOrganismePayeurCommand() : base()
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
