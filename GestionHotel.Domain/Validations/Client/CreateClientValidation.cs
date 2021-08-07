using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.Client;
using FluentValidation;

namespace GestionHotel.Domain.Validations.Client
{
    public class CreateClientValidation : AbstractValidator<CreateClientCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateClientValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Prenom).NotNull();

            RuleFor(x => x.Prenom).Must(BeNotADuplicate)
                .WithMessage("Ce client a déja été enregistré");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.SClient.Any(d => d.Prenom.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
