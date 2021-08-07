using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.EtatEspace;
using FluentValidation;

namespace GestionHotel.Domain.Validations.EtatEspace
{
    public class CreateEtatEspaceValidation : AbstractValidator<CreateEtatEspaceCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateEtatEspaceValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Libelle).NotNull();
            RuleFor(x => x.Libelle).Must(BeNotADuplicate).WithMessage("Cet etat d'espace a déja été enregistré");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.SEtatEspace.Any(d => d.Libelle.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
