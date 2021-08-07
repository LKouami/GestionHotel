using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.Espace;
using FluentValidation;

namespace GestionHotel.Domain.Validations.Espace
{
    public class CreateEspaceValidation : AbstractValidator<CreateEspaceCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateEspaceValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Numero).NotNull();
            RuleFor(x => x.Nom).Must(BeNotADuplicate).WithMessage("Cet espace a déja été enregistré");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.SEspace.Any(d => d.Nom.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
