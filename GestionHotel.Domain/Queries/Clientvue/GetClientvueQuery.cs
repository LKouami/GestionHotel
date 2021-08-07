using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.Clientvue
{
    public class GetClientvueQuery : GetOneQuery<long, ClientvueDto>
    {
        public GetClientvueQuery(long Id) : base(Id)
        {

        }
    }
}
