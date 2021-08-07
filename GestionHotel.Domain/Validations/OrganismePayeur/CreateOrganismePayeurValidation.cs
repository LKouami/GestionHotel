using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.OrganismePayeur;
using FluentValidation;

namespace GestionHotel.Domain.Validations.OrganismePayeur
{
    public class CreateOrganismePayeurValidation : AbstractValidator<CreateOrganismePayeurCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateOrganismePayeurValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Nom).NotNull();
            RuleFor(x => x.Nom).Must(BeNotADuplicate)
                .WithMessage("Cet organisme a déja été enregistré");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.SOrganismePayeur.Any(d => d.Nom.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
