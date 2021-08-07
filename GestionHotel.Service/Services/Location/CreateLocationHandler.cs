using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Location;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Location;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class CreateLocationHandler : IRequestHandler<CreateLocationCommand, LocationDto>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly ILocationDxos _locationDxos;
        private readonly IMediator _mediator;

        public CreateLocationHandler(ILocationRepository locationRepository,
            IMediator mediator,
            ILocationDxos locationDxos)
        {
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _locationDxos = locationDxos ?? throw new ArgumentNullException(nameof(locationDxos));
        }


        public async Task<LocationDto> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var locationModel = _locationDxos.MapCreateRequesttoLocation(request);

            _locationRepository.Add(locationModel);

            if (await _locationRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Insertion to database failed");
            }

            await _mediator.Publish(new LocationCreatedEvent(locationModel.Id), cancellationToken);

            var locationDto = _locationDxos.MapLocationDto(locationModel);

            return locationDto;
        }
    }
}