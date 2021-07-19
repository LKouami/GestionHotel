using Newtonsoft.Json;
using System;

namespace GestionHotel.Model.Dtos
{
    public class RoleDto
    {
        [JsonProperty("id")]
        public byte Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}