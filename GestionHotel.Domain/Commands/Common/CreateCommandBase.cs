using MediatR;
using System;

namespace GestionHotel.Domain.Commands.Common
{
    public class CreateCommandBase<T> : IRequest<T> where T : class
    {
        public CreateCommandBase()
        {

        }
        public CreateCommandBase(int createdBy, DateTime createdAt)
        {
            CreatedBy = createdBy;
            CreatedAt = createdAt;
        }

        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
