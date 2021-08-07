using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.AffectationMateriel
{
    public class GetAffectationMaterielQuery : GetOneQuery<long, AffectationMaterielDto>
    {
        public GetAffectationMaterielQuery(long Id) : base(Id)
        {

        }
    }
}
