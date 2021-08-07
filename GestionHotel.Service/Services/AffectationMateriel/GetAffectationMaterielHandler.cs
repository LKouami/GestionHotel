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
    public class GetAffectationMaterielHandler : IRequestHandler<GetAffectationMaterielQuery, AffectationMaterielDto>
    {
        private readonly IAffectationMaterielRepository _affectationMaterielRepository;
        private readonly IAffectationMaterielDxos _affectationMaterielDxos;
        private readonly ILogger _logger;

        public GetAffectationMaterielHandler(IAffectationMaterielRepository affectationMaterielRepository, IAffectationMaterielDxos affectationMaterielDxos, ILogger<GetAffectationMaterielHandler> logger)
        {
            _affectationMaterielRepository = affectationMaterielRepository ?? throw new ArgumentNullException(nameof(affectationMaterielRepository));
            _affectationMaterielDxos = affectationMaterielDxos ?? throw new ArgumentNullException(nameof(affectationMaterielDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<AffectationMaterielDto> Handle(GetAffectationMaterielQuery request, CancellationToken cancellationToken)
        {
            var affectationMateriel = await _affectationMaterielRepository.GetAsync(e =>
                e.Id == request.Id);

            if (affectationMateriel != null)
            {
                _logger.LogInformation($"Got a request get affectationMateriel Id: {affectationMateriel.Id}");
                var affectationMaterielDto = _affectationMaterielDxos.MapAffectationMaterielDto(affectationMateriel);
                return affectationMaterielDto;
            }

            return null;
        }
    }
}