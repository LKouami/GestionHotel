using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.Materiel
{
    public class GetMaterielQuery : GetOneQuery<long, MaterielDto>
    {
        public GetMaterielQuery(long Id) : base(Id)
        {

        }
    }
}
