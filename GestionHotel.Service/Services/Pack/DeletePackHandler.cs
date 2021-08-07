using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Pack;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Pack;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace GestionHotel.Service.Services
{
    public class DeletePackvueHandler : IRequestHandler<DeletePackCommand, DeleteResult>
    {
        private readonly IPackRepository _packRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IMediator _mediator;

        public DeletePackvueHandler(IPackRepository packRepository, ILocationRepository locationRepository,
            IMediator mediator)
        {
            _packRepository = packRepository ?? throw new ArgumentNullException(nameof(packRepository));
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeletePackCommand request, CancellationToken cancellationToken)
        {
            var packModel = await _packRepository.GetAsync(e => e.Id == request.Id);

            if (packModel != null)
            {
                bool usedInLocation = _locationRepository.Queryable(l => l.PackId == request.Id).Any();

                if (!usedInLocation)
                {
                    _packRepository.Remove(packModel);

                    if (await _packRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new PackDeletedEvent(packModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("Pack cannot been deleted because it is used by Location");
                }
            }
            else
            {
                throw new ApplicationException("Pack does no longer exist");
            }


        }
    }
}