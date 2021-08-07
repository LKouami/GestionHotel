using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.User
{
    public class GetUserQuery : GetOneQuery<long, UserDto>
    {
        public GetUserQuery(long Id) : base(Id)
        {

        }
    }
}
