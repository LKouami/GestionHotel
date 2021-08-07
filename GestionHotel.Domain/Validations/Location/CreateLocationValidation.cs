using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.Location;
using FluentValidation;

namespace GestionHotel.Domain.Validations.Location
{
    public class CreateLocationValidation : AbstractValidator<CreateLocationCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateLocationValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         

        }

    }
}
