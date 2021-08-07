using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.TypeClient;
using FluentValidation;

namespace GestionHotel.Domain.Validations.TypeClient
{
    public class CreateTypeClientValidation : AbstractValidator<CreateTypeClientCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateTypeClientValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Nom).NotNull();
            RuleFor(x => x.Nom).Must(BeNotADuplicate).WithMessage("Ce type de client a déja été enregistré");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.STypeClient.Any(d => d.Nom.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
