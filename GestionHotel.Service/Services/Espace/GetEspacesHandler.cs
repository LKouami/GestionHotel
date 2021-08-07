using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Espace;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetEspacesHandler : IRequestHandler<GetEspacesQuery, PagedResults<EspaceDto>>
    {
        private readonly IEspaceRepository _espaceRepository;
        private readonly ILogger _logger;

        public GetEspacesHandler(IEspaceRepository espaceRepository, IEspaceDxos espaceDxos,
            ILogger<GetEspacesHandler> logger)
        {
            _espaceRepository = espaceRepository ?? throw new ArgumentNullException(nameof(espaceRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<EspaceDto>> Handle(GetEspacesQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _espaceRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _espaceRepository.GetListPageAsync(request,
               p =>
                   p.Nom.ToLower().StartsWith(request.Search));
            }

        }
    }
}