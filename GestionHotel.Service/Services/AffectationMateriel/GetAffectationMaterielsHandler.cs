using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.AffectationMateriel;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetAffectationMaterielsHandler : IRequestHandler<GetAffectationMaterielsQuery, PagedResults<AffectationMaterielDto>>
    {
        private readonly IAffectationMaterielRepository _affectationMaterielRepository;
        private readonly ILogger _logger;

        public GetAffectationMaterielsHandler(IAffectationMaterielRepository affectationMaterielRepository, ITypeClientDxos affectationMaterielDxos,
            ILogger<GetAffectationMaterielsHandler> logger)
        {
            _affectationMaterielRepository = affectationMaterielRepository ?? throw new ArgumentNullException(nameof(affectationMaterielRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<AffectationMaterielDto>> Handle(GetAffectationMaterielsQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _affectationMaterielRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _affectationMaterielRepository.GetListPageAsync(request, null);
            }

        }
    }
}