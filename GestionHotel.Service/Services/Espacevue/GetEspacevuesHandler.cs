using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Espacevue;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetEspacevuesHandler : IRequestHandler<GetEspacevuesQuery, PagedResults<EspacevueDto>>
    {
        private readonly IEspacevueRepository _espacevueRepository;
        private readonly ILogger _logger;

        public GetEspacevuesHandler(IEspacevueRepository espacevueRepository, IEspacevueDxos espacevueDxos,
            ILogger<GetEspacevuesHandler> logger)
        {
            _espacevueRepository = espacevueRepository ?? throw new ArgumentNullException(nameof(espacevueRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<EspacevueDto>> Handle(GetEspacevuesQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _espacevueRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _espacevueRepository.GetListPageAsync(request,
              p =>
                  p.Nom.ToLower().StartsWith(request.Search));
            }

        }
    }
}