using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.TypeClient
{
    public class GetTypeClientQuery : GetOneQuery<long, TypeClientDto>
    {
        public GetTypeClientQuery(long Id) : base(Id)
        {

        }
    }
}
