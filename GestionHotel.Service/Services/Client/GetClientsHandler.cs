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
    public class GetClientsHandler : IRequestHandler<GetClientsQuery, PagedResults<ClientDto>>
    {
        private readonly IClientRepository _clientRepository;
        private readonly ILogger _logger;

        public GetClientsHandler(IClientRepository clientRepository, IAffectationMaterielDxos clientDxos,
            ILogger<GetClientsHandler> logger)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<ClientDto>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _clientRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _clientRepository.GetListPageAsync(request, null);
            }

        }
    }
}