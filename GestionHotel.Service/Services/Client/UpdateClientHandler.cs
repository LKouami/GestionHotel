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
    public class UpdateClientHandler : IRequestHandler<UpdateClientCommand, ClientDto>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IClientDxos _clientDxos;
        private readonly IMediator _mediator;

        public UpdateClientHandler(IClientRepository clientRepository,
            IMediator mediator,
            IClientDxos clientDxos)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _clientDxos = clientDxos ?? throw new ArgumentNullException(nameof(clientDxos));
        }


        public async Task<ClientDto> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var clientModel = _clientDxos.MapUpdateRequesttoClient(request);

            _clientRepository.Update(clientModel);

            if (await _clientRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Update in database failed");
            }

            await _mediator.Publish(new ClientUpdatedEvent(clientModel.Id), cancellationToken);

            var clientDto = _clientDxos.MapClientDto(clientModel);

            return clientDto;
        }
    }
}