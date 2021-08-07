using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.User;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.User;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, DeleteResult>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMediator _mediator;

        public DeleteUserHandler(IUserRepository userRepository,
            IMediator mediator)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetAsync(e => e.Id == request.Id);

            _userRepository.Remove(user);

            if (await _userRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Deletion failed");
            }

            await _mediator.Publish(new UserDeletedEvent(user.Id), cancellationToken);

            return new DeleteResult(true);
        }
    }
}