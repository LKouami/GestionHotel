using MediatR;

namespace GestionHotel.Domain.Commands.Common 
{
    public class CommandBase<T> : IRequest<T> where T : class
    {

    }
}

