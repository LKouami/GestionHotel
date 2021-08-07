﻿using GestionHotel.Model;
using GestionHotel.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHotel.Domain.Queries.Espacevue
{
    public class GetEspacevueQuery : GetOneQuery<long, EspacevueDto>
    {
        public GetEspacevueQuery(long Id) : base(Id)
        {

        }
    }
}
