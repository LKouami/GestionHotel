using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.EtatEspace
{
    public class GetEtatEspaceQuery : GetOneQuery<long, EtatEspaceDto>
    {
        public GetEtatEspaceQuery(long Id) : base(Id)
        {

        }
    }
}
