using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Materiel;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetMaterielHandler : IRequestHandler<GetMaterielQuery, MaterielDto>
    {
        private readonly IMaterielRepository _materielRepository;
        private readonly IMaterielDxos _materielDxos;
        private readonly ILogger _logger;

        public GetMaterielHandler(IMaterielRepository materielRepository, IMaterielDxos materielDxos, ILogger<GetMaterielHandler> logger)
        {
            _materielRepository = materielRepository ?? throw new ArgumentNullException(nameof(materielRepository));
            _materielDxos = materielDxos ?? throw new ArgumentNullException(nameof(materielDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<MaterielDto> Handle(GetMaterielQuery request, CancellationToken cancellationToken)
        {
            var materiel = await _materielRepository.GetAsync(e =>
                e.Id == request.Id);

            if (materiel != null)
            {
                _logger.LogInformation($"Got a request get materiel Id: {materiel.Id}");
                var materielDto = _materielDxos.MapMaterielDto(materiel);
                return materielDto;
            }

            return null;
        }
    }
}