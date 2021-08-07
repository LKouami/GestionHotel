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
    public class GetAffectationMaterielvueHandler : IRequestHandler<GetAffectationMaterielvueQuery, AffectationMaterielvueDto>
    {
        private readonly IAffectationMaterielvueRepository _affectationMaterielvueRepository;
        private readonly IAffectationMaterielvueDxos _affectationMaterielvueDxos;
        private readonly ILogger _logger;

        public GetAffectationMaterielvueHandler(IAffectationMaterielvueRepository affectationMaterielvueRepository, IAffectationMaterielvueDxos affectationMaterielvueDxos, ILogger<GetAffectationMaterielvueHandler> logger)
        {
            _affectationMaterielvueRepository = affectationMaterielvueRepository ?? throw new ArgumentNullException(nameof(affectationMaterielvueRepository));
            _affectationMaterielvueDxos = affectationMaterielvueDxos ?? throw new ArgumentNullException(nameof(affectationMaterielvueDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<AffectationMaterielvueDto> Handle(GetAffectationMaterielvueQuery request, CancellationToken cancellationToken)
        {
            var affectationMaterielvue = await _affectationMaterielvueRepository.GetAsync(e =>
                e.Id == request.Id);

            if (affectationMaterielvue != null)
            {
                _logger.LogInformation($"Got a request get affectationMaterielvue Id: {affectationMaterielvue.Id}");
                var affectationMaterielvueDto = _affectationMaterielvueDxos.MapAffectationMaterielvueDto(affectationMaterielvue);
                return affectationMaterielvueDto;
            }

            return null;
        }
    }
}