using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Pack;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetPacksHandler : IRequestHandler<GetPacksQuery, PagedResults<PackDto>>
    {
        private readonly IPackRepository _packRepository;
        private readonly ILogger _logger;

        public GetPacksHandler(IPackRepository packRepository, IPackDxos packDxos,
            ILogger<GetPacksHandler> logger)
        {
            _packRepository = packRepository ?? throw new ArgumentNullException(nameof(packRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<PackDto>> Handle(GetPacksQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _packRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _packRepository.GetListPageAsync(request,
               p =>
                   p.Libelle.ToLower().StartsWith(request.Search));
            }

        }
    }
}