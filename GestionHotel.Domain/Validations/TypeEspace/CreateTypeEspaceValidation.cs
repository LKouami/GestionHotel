using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.TypeEspace;
using FluentValidation;

namespace GestionHotel.Domain.Validations.TypeEspace
{
    public class CreateTypeEspaceValidation : AbstractValidator<CreateTypeEspaceCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateTypeEspaceValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Nom).NotNull();
            RuleFor(x => x.Nom).Must(BeNotADuplicate).WithMessage("Ce type d'espace a déja été enregistré");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.STypeEspace.Any(d => d.Nom.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
