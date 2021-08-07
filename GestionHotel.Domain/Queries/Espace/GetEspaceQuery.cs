using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.Espace
{
    public class GetEspaceQuery : GetOneQuery<long, EspaceDto>
    {
        public GetEspaceQuery(long Id) : base(Id)
        {

        }
    }
}
