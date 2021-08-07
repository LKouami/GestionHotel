using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Location;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetLocationHandler : IRequestHandler<GetLocationQuery, LocationDto>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ILocationDxos _locationDxos;
        private readonly ILogger _logger;

        public GetLocationHandler(ILocationRepository locationRepository, ILocationDxos locationDxos, ILogger<GetLocationHandler> logger)
        {
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
            _locationDxos = locationDxos ?? throw new ArgumentNullException(nameof(locationDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<LocationDto> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var location = await _locationRepository.GetAsync(e =>
                e.Id == request.Id);

            if (location != null)
            {
                _logger.LogInformation($"Got a request get location Id: {location.Id}");
                var locationDto = _locationDxos.MapLocationDto(location);
                return locationDto;
            }

            return null;
        }
    }
}