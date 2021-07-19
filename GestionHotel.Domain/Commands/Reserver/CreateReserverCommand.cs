using Newtonsoft.Json;
using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Commands.Reserver
{
   public class CreateReserverCommand : CreateCommandBase<ReserverDto>
    {
        public CreateReserverCommand() : base()
        {

        }
       [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("nbPersonne")]
        public int? NbPersonne { get; set; }
        [JsonProperty("dateArriveePrevue")]
        public DateTime? DateArriveePrevue { get; set; }
        [JsonProperty("dateArrivee")]
        public DateTime? DateArrivee { get; set; }
        [JsonProperty("dateDepartPrevue")]
        public DateTime? DateDepartPrevue { get; set; }
        [JsonProperty("dateDepart")]
        public DateTime? DateDepart { get; set; }
        [JsonProperty("modalite")]
        public string Modalite { get; set; }
        [JsonProperty("origineReservation")]
        public string OrigineReservation { get; set; }
        [JsonProperty("reduction")]
        public int? Reduction { get; set; }
        [JsonProperty("observation")]
        public string Observation { get; set; }
        [JsonProperty("clientId")]
        public int ClientId { get; set; }
        [JsonProperty("status")]
        public byte Status { get; set; }
    }
}
