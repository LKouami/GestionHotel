using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionHotel.Domain.Commands.User;
using FluentValidation;

namespace GestionHotel.Domain.Validations.User
{
    public class CreateUserValidation : AbstractValidator<CreateUserCommand>
    {
        NoyauxButlerDBContext _dbContext;

        public CreateUserValidation(NoyauxButlerDBContext dbContext)
        {
            _dbContext = dbContext;
         
            RuleFor(x => x.Email).NotNull();
            RuleFor(x => x.Email).Must(BeNotADuplicate).WithMessage("Cet utilisateur a déja été enregistré");

        }

        private bool BeNotADuplicate(string parameterName)
        {
            bool existAlready = _dbContext.AUser.Any(d => d.Email.ToLower().Equals(parameterName.ToLower()));

            return !existAlready;
        }

    }
}
