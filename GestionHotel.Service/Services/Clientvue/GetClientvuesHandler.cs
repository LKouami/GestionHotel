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
    public class GetClientvuesHandler : IRequestHandler<GetClientvuesQuery, PagedResults<ClientvueDto>>
    {
        private readonly IClientvueRepository _clientvueRepository;
        private readonly ILogger _logger;

        public GetClientvuesHandler(IClientvueRepository clientvueRepository, IClientvueDxos clientvueDxos,
            ILogger<GetClientvuesHandler> logger)
        {
            _clientvueRepository = clientvueRepository ?? throw new ArgumentNullException(nameof(clientvueRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<ClientvueDto>> Handle(GetClientvuesQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _clientvueRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _clientvueRepository.GetListPageAsync(request,
               p =>
                   p.Nom.ToLower().StartsWith(request.Search));
            }

        }
    }
}