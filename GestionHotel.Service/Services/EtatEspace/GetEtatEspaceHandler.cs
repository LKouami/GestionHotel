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
    public class GetEtatEspaceHandler : IRequestHandler<GetEtatEspaceQuery, EtatEspaceDto>
    {
        private readonly IEtatEspaceRepository _etatEspaceRepository;
        private readonly IEtatEspaceDxos _etatEspaceDxos;
        private readonly ILogger _logger;

        public GetEtatEspaceHandler(IEtatEspaceRepository etatEspaceRepository, IEtatEspaceDxos etatEspaceDxos, ILogger<GetEtatEspaceHandler> logger)
        {
            _etatEspaceRepository = etatEspaceRepository ?? throw new ArgumentNullException(nameof(etatEspaceRepository));
            _etatEspaceDxos = etatEspaceDxos ?? throw new ArgumentNullException(nameof(etatEspaceDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<EtatEspaceDto> Handle(GetEtatEspaceQuery request, CancellationToken cancellationToken)
        {
            var etatEspace = await _etatEspaceRepository.GetAsync(e =>
                e.Id == request.Id);

            if (etatEspace != null)
            {
                _logger.LogInformation($"Got a request get etatEspace Id: {etatEspace.Id}");
                var etatEspaceDto = _etatEspaceDxos.MapEtatEspaceDto(etatEspace);
                return etatEspaceDto;
            }

            return null;
        }
    }
}