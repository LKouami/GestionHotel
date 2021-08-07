using MediatR;
using System;

namespace GestionHotel.Domain.Commands.Common
{
    public class UpdateCommandBase<T> : IRequest<T> where T : class
    {
        public UpdateCommandBase()
        {

        }
        public UpdateCommandBase(int modifiedBy, DateTime modifiedAt, int deletedBy, DateTime deletedAt)
        {
            ModifiedBy = modifiedBy;
            ModifiedAt = modifiedAt;
        }

        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}