using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Locationvue;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetLocationvueHandler : IRequestHandler<GetLocationvueQuery, LocationvueDto>
    {
        private readonly ILocationvueRepository _locationvueRepository;
        private readonly ILocationvueDxos _locationvueDxos;
        private readonly ILogger _logger;

        public GetLocationvueHandler(ILocationvueRepository locationvueRepository, ILocationvueDxos locationvueDxos, ILogger<GetLocationvueHandler> logger)
        {
            _locationvueRepository = locationvueRepository ?? throw new ArgumentNullException(nameof(locationvueRepository));
            _locationvueDxos = locationvueDxos ?? throw new ArgumentNullException(nameof(locationvueDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<LocationvueDto> Handle(GetLocationvueQuery request, CancellationToken cancellationToken)
        {
            var locationvue = await _locationvueRepository.GetAsync(e =>
                e.Id == request.Id);

            if (locationvue != null)
            {
                _logger.LogInformation($"Got a request get locationvue Id: {locationvue.Id}");
                var locationvueDto = _locationvueDxos.MapLocationvueDto(locationvue);
                return locationvueDto;
            }

            return null;
        }
    }
}