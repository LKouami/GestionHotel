using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.AffectationMaterielvue;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetAffectationMaterielvuesHandler : IRequestHandler<GetAffectationMaterielvuesQuery, PagedResults<AffectationMaterielvueDto>>
    {
        private readonly IAffectationMaterielvueRepository _affectationMaterielvueRepository;
        private readonly ILogger _logger;

        public GetAffectationMaterielvuesHandler(IAffectationMaterielvueRepository affectationMaterielvueRepository, IAffectationMaterielvueDxos affectationMaterielvueDxos,
            ILogger<GetAffectationMaterielvuesHandler> logger)
        {
            _affectationMaterielvueRepository = affectationMaterielvueRepository ?? throw new ArgumentNullException(nameof(affectationMaterielvueRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<AffectationMaterielvueDto>> Handle(GetAffectationMaterielvuesQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _affectationMaterielvueRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _affectationMaterielvueRepository.GetListPageAsync(request, null);
            }

        }
    }
}