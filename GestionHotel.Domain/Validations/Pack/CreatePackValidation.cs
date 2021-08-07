using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.Pack;
using FluentValidation;

namespace GestionHotel.Domain.Validations.Pack
{
    public class CreatePackValidation : AbstractValidator<CreatePackCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreatePackValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Libelle).NotNull();
            RuleFor(x => x.Libelle).Must(BeNotADuplicate).WithMessage("Ce pack a déja été enregistré, pensez à le modifier");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.SPack.Any(d => d.Libelle.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
