using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Espace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Espace;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace GestionHotel.Service.Services
{
    public class DeleteEspacevueHandler : IRequestHandler<DeleteEspaceCommand, DeleteResult>
    {
        private readonly IEspaceRepository _espaceRepository;
        private readonly IAffectationMaterielRepository _affectationMaterielRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IMediator _mediator;

        public DeleteEspacevueHandler(IEspaceRepository espaceRepository, ILocationRepository locationRepository,IAffectationMaterielRepository affectationMaterielRepository,
            IMediator mediator)
        {
            _espaceRepository = espaceRepository ?? throw new ArgumentNullException(nameof(espaceRepository));
            _affectationMaterielRepository = affectationMaterielRepository ?? throw new ArgumentNullException(nameof(affectationMaterielRepository));
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteEspaceCommand request, CancellationToken cancellationToken)
        {
            var espaceModel = await _espaceRepository.GetAsync(e => e.Id == request.Id);

            if (espaceModel != null)
            {
                bool usedInLocation = _locationRepository.Queryable(l => l.EspaceId == request.Id).Any();
                bool usedInAffectationMateriel = _affectationMaterielRepository.Queryable(l => l.EspaceId == request.Id).Any();

                if (!usedInLocation)
                {
                    _espaceRepository.Remove(espaceModel);

                    if (await _espaceRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new EspaceDeletedEvent(espaceModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("Espace cannot been deleted because it is used by Location");
                }

                if (!usedInAffectationMateriel)
                {
                    _espaceRepository.Remove(espaceModel);

                    if (await _espaceRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new EspaceDeletedEvent(espaceModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("Espace cannot been deleted because it is used by AffectationMateriel");
                }
            }
            else
            {
                throw new ApplicationException("Espace does no longer exist");
            }


        }
    }
}