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
    public class GetLocationsHandler : IRequestHandler<GetLocationsQuery, PagedResults<LocationDto>>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ILogger _logger;

        public GetLocationsHandler(ILocationRepository locationRepository, ILocationDxos locationDxos,
            ILogger<GetLocationsHandler> logger)
        {
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<LocationDto>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _locationRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _locationRepository.GetListPageAsync(request, null);
            }

        }
    }
}