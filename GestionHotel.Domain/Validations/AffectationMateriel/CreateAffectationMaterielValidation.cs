using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.AffectationMateriel;
using FluentValidation;

namespace GestionHotel.Domain.Validations.AffectationMateriel
{
    public class CreateAffectationMaterielValidation : AbstractValidator<CreateAffectationMaterielCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateAffectationMaterielValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.MaterielId).NotNull();
            RuleFor(x => x.EspaceId).NotNull();

        }

    }
}
