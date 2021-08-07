using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Client;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetClientHandler : IRequestHandler<GetClientQuery, ClientDto>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IClientDxos _clientDxos;
        private readonly ILogger _logger;

        public GetClientHandler(IClientRepository clientRepository, IClientDxos clientDxos, ILogger<GetClientHandler> logger)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _clientDxos = clientDxos ?? throw new ArgumentNullException(nameof(clientDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<ClientDto> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetAsync(e =>
                e.Id == request.Id);

            if (client != null)
            {
                _logger.LogInformation($"Got a request get client Id: {client.Id}");
                var clientDto = _clientDxos.MapClientDto(client);
                return clientDto;
            }

            return null;
        }
    }
}