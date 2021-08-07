using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.Location
{
    public class GetLocationQuery : GetOneQuery<long, LocationDto>
    {
        public GetLocationQuery(long Id) : base(Id)
        {

        }
    }
}
