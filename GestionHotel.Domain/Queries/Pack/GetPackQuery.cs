using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.Pack
{
    public class GetPackQuery : GetOneQuery<long, PackDto>
    {
        public GetPackQuery(long Id) : base(Id)
        {
            
        }
    }
}
