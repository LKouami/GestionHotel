using MediatR;

namespace GestionHotel.Domain.Commands
{
    public class CommandBase<T> : IRequest<T> where T : class
    {

    }
}

