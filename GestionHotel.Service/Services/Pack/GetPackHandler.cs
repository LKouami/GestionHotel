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
    public class GetPackHandler : IRequestHandler<GetPackQuery, PackDto>
    {
        private readonly IPackRepository _packRepository;
        private readonly IPackDxos _packDxos;
        private readonly ILogger _logger;

        public GetPackHandler(IPackRepository packRepository, IPackDxos packDxos, ILogger<GetPackHandler> logger)
        {
            _packRepository = packRepository ?? throw new ArgumentNullException(nameof(packRepository));
            _packDxos = packDxos ?? throw new ArgumentNullException(nameof(packDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PackDto> Handle(GetPackQuery request, CancellationToken cancellationToken)
        {
            var pack = await _packRepository.GetAsync(e =>
                e.Id == request.Id);

            if (pack != null)
            {
                _logger.LogInformation($"Got a request get pack Id: {pack.Id}");
                var packDto = _packDxos.MapPackDto(pack);
                return packDto;
            }

            return null;
        }
    }
}