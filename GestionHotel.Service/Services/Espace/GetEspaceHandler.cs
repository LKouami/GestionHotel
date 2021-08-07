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
    public class GetEspaceHandler : IRequestHandler<GetEspaceQuery, EspaceDto>
    {
        private readonly IEspaceRepository _espaceRepository;
        private readonly IEspaceDxos _espaceDxos;
        private readonly ILogger _logger;

        public GetEspaceHandler(IEspaceRepository espaceRepository, IEspaceDxos espaceDxos, ILogger<GetEspaceHandler> logger)
        {
            _espaceRepository = espaceRepository ?? throw new ArgumentNullException(nameof(espaceRepository));
            _espaceDxos = espaceDxos ?? throw new ArgumentNullException(nameof(espaceDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<EspaceDto> Handle(GetEspaceQuery request, CancellationToken cancellationToken)
        {
            var espace = await _espaceRepository.GetAsync(e =>
                e.Id == request.Id);

            if (espace != null)
            {
                _logger.LogInformation($"Got a request get espace Id: {espace.Id}");
                var espaceDto = _espaceDxos.MapEspaceDto(espace);
                return espaceDto;
            }

            return null;
        }
    }
}