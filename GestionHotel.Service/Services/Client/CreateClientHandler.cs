using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Client;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Client;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class CreateClientvueHandler : IRequestHandler<CreateClientCommand, ClientDto>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IClientDxos _clientDxos;
        private readonly IMediator _mediator;

        public CreateClientvueHandler(IClientRepository clientRepository,
            IMediator mediator,
            IClientDxos clientDxos)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _clientDxos = clientDxos ?? throw new ArgumentNullException(nameof(clientDxos));
        }


        public async Task<ClientDto> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var clientModel = _clientDxos.MapCreateRequesttoClient(request);

            _clientRepository.Add(clientModel);

            if (await _clientRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Insertion to database failed");
            }

            await _mediator.Publish(new ClientCreatedEvent(clientModel.Id), cancellationToken);

            var clientDto = _clientDxos.MapClientDto(clientModel);

            return clientDto;
        }
    }
}