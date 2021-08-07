using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.TypeEspace
{
    public class GetTypeEspaceQuery : GetOneQuery<long, TypeEspaceDto>
    {
        public GetTypeEspaceQuery(long Id) : base(Id)
        {

        }
    }
}
