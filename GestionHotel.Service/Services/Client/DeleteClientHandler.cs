using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Client;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Client;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace GestionHotel.Service.Services
{
    public class DeleteClientvueHandler : IRequestHandler<DeleteClientCommand, DeleteResult>
    {
        private readonly IClientRepository _clientRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IMediator _mediator;

        public DeleteClientvueHandler(IClientRepository clientRepository, ILocationRepository locationRepository,
            IMediator mediator)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var clientModel = await _clientRepository.GetAsync(e => e.Id == request.Id);

            if (clientModel != null)
            {
                bool usedInLocation = _locationRepository.Queryable(l => l.ClientId == request.Id).Any();

                if (!usedInLocation)
                {
                    _clientRepository.Remove(clientModel);

                    if (await _clientRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new ClientDeletedEvent(clientModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("Client cannot been deleted because it is used by Location");
                }
            }
            else
            {
                throw new ApplicationException("Client does no longer exist");
            }


        }
    }
}