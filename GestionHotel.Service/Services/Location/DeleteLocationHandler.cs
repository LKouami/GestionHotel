using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Location;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Location;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class DeleteLocationHandler : IRequestHandler<DeleteLocationCommand, DeleteResult>
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMediator _mediator;

        public DeleteLocationHandler(ILocationRepository locationRepository,
            IMediator mediator)
        {
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
        {
            var locationModel = await _locationRepository.GetAsync(e => e.Id == request.Id);

            _locationRepository.Remove(locationModel);

            if (await _locationRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Deletion failed");
            }

            await _mediator.Publish(new LocationDeletedEvent(locationModel.Id), cancellationToken);

            return new DeleteResult(true);
        }
    }
}