using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.EtatEspace;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetEtatEspacesHandler : IRequestHandler<GetEtatEspacesQuery, PagedResults<EtatEspaceDto>>
    {
        private readonly IEtatEspaceRepository _etatEspaceRepository;
        private readonly ILogger _logger;

        public GetEtatEspacesHandler(IEtatEspaceRepository etatEspaceRepository, IEtatEspaceDxos etatEspaceDxos,
            ILogger<GetEtatEspacesHandler> logger)
        {
            _etatEspaceRepository = etatEspaceRepository ?? throw new ArgumentNullException(nameof(etatEspaceRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<EtatEspaceDto>> Handle(GetEtatEspacesQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _etatEspaceRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _etatEspaceRepository.GetListPageAsync(request,
               p =>
                   p.Libelle.ToLower().StartsWith(request.Search));
            }

        }
    }
}