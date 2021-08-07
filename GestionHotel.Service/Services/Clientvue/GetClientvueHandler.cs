using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Clientvue;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetClientvueHandler : IRequestHandler<GetClientvueQuery, ClientvueDto>
    {
        private readonly IClientvueRepository _clientvueRepository;
        private readonly IClientvueDxos _clientvueDxos;
        private readonly ILogger _logger;

        public GetClientvueHandler(IClientvueRepository clientvueRepository, IClientvueDxos clientvueDxos, ILogger<GetClientvueHandler> logger)
        {
            _clientvueRepository = clientvueRepository ?? throw new ArgumentNullException(nameof(clientvueRepository));
            _clientvueDxos = clientvueDxos ?? throw new ArgumentNullException(nameof(clientvueDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<ClientvueDto> Handle(GetClientvueQuery request, CancellationToken cancellationToken)
        {
            var clientvue = await _clientvueRepository.GetAsync(e =>
                e.Id == request.Id);

            if (clientvue != null)
            {
                _logger.LogInformation($"Got a request get clientvue Id: {clientvue.Id}");
                var clientvueDto = _clientvueDxos.MapClientvueDto(clientvue);
                return clientvueDto;
            }

            return null;
        }
    }
}