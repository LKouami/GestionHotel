using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.Client
{
    public class GetClientQuery : GetOneQuery<long, ClientDto>
    {
        public GetClientQuery(long Id) : base(Id)
        {

        }
    }
}
