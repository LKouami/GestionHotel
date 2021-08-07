using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.Locationvue
{
    public class GetLocationvueQuery : GetOneQuery<long, LocationvueDto>
    {
        public GetLocationvueQuery(long Id) : base(Id)
        {

        }
    }
}
