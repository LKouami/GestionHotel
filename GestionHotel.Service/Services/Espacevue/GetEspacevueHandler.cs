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
    public class GetEspacevueHandler : IRequestHandler<GetEspacevueQuery, EspacevueDto>
    {
        private readonly IEspacevueRepository _espacevueRepository;
        private readonly IEspacevueDxos _espacevueDxos;
        private readonly ILogger _logger;

        public GetEspacevueHandler(IEspacevueRepository espacevueRepository, IEspacevueDxos espacevueDxos, ILogger<GetEspacevueHandler> logger)
        {
            _espacevueRepository = espacevueRepository ?? throw new ArgumentNullException(nameof(espacevueRepository));
            _espacevueDxos = espacevueDxos ?? throw new ArgumentNullException(nameof(espacevueDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<EspacevueDto> Handle(GetEspacevueQuery request, CancellationToken cancellationToken)
        {
            var espacevue = await _espacevueRepository.GetAsync(e =>
                e.Id == request.Id);

            if (espacevue != null)
            {
                _logger.LogInformation($"Got a request get espacevue Id: {espacevue.Id}");
                var espacevueDto = _espacevueDxos.MapEspacevueDto(espacevue);
                return espacevueDto;
            }

            return null;
        }
    }
}