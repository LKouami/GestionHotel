using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.AffectationMaterielvue
{
    public class GetAffectationMaterielvueQuery : GetOneQuery<long, AffectationMaterielvueDto>
    {
        public GetAffectationMaterielvueQuery(long Id) : base(Id)
        {

        }
    }
}
