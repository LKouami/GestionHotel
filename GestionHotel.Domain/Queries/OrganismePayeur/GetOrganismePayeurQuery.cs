using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.OrganismePayeur
{
    public class GetOrganismePayeurQuery : GetOneQuery<long, OrganismePayeurDto>
    {
        public GetOrganismePayeurQuery(long Id) : base(Id)
        {

        }
    }
}
