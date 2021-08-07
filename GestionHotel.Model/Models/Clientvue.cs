using System;
using System.Collections.Generic;

namespace GestionHotel.Model.Models
{
    public partial class Clientvue
    {
        public string OrNom { get; set; }
        public string OrEmail { get; set; }
        public string OrTel { get; set; }
        public string OrAdresse { get; set; }
        public byte? OrStatus { get; set; }
        public string TcNom { get; set; }
        public byte TcStatus { get; set; }
        public int? OrId { get; set; }
        public int TcId { get; set; }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Nationalite { get; set; }
        public string Email { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string DomicileHabituel { get; set; }
        public string Tel { get; set; }
        public byte Status { get; set; }
    }
}
