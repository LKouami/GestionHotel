using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.Materiel;
using FluentValidation;

namespace GestionHotel.Domain.Validations.Materiel
{
    public class CreateMaterielValidation : AbstractValidator<CreateMaterielCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateMaterielValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Nom).NotNull();
            RuleFor(x => x.Nom).Must(BeNotADuplicate).WithMessage("Ce matériel a déja été enregistré, pensez à modifier sa quantité");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.SMateriel.Any(d => d.Nom.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
