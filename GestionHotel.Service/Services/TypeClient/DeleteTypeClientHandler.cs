using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.TypeClient;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.TypeClient;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace GestionHotel.Service.Services
{
    public class DeleteTypeClientvueHandler : IRequestHandler<DeleteTypeClientCommand, DeleteResult>
    {
        private readonly ITypeClientRepository _typeClientRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IMediator _mediator;

        public DeleteTypeClientvueHandler(ITypeClientRepository typeClientRepository, IClientRepository clientRepository,
            IMediator mediator)
        {
            _typeClientRepository = typeClientRepository ?? throw new ArgumentNullException(nameof(typeClientRepository));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteTypeClientCommand request, CancellationToken cancellationToken)
        {
            var typeClientModel = await _typeClientRepository.GetAsync(e => e.Id == request.Id);

            if (typeClientModel != null)
            {
                bool usedInClient = _clientRepository.Queryable(l => l.TypeClientId == request.Id).Any();

                if (!usedInClient)
                {
                    _typeClientRepository.Remove(typeClientModel);

                    if (await _typeClientRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new TypeClientDeletedEvent(typeClientModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("TypeClient cannot been deleted because it is used by Client");
                }
            }
            else
            {
                throw new ApplicationException("TypeClient does no longer exist");
            }


        }
    }
}