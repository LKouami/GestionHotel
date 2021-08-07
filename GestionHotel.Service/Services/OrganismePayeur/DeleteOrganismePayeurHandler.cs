using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.OrganismePayeur;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.OrganismePayeur;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace GestionHotel.Service.Services
{
    public class DeleteOrganismePayeurvueHandler : IRequestHandler<DeleteOrganismePayeurCommand, DeleteResult>
    {
        private readonly IOrganismePayeurRepository _organismePayeurRepository;
        private readonly IClientRepository _clientRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IMediator _mediator;

        public DeleteOrganismePayeurvueHandler(IOrganismePayeurRepository organismePayeurRepository, IClientRepository clientRepository,ILocationRepository locationRepository,
            IMediator mediator)
        {
            _organismePayeurRepository = organismePayeurRepository ?? throw new ArgumentNullException(nameof(organismePayeurRepository));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }


        public async Task<DeleteResult> Handle(DeleteOrganismePayeurCommand request, CancellationToken cancellationToken)
        {
            var organismePayeurModel = await _organismePayeurRepository.GetAsync(e => e.Id == request.Id);

            if (organismePayeurModel != null)
            {
                bool usedInClient = _clientRepository.Queryable(l => l.OrganismeId == request.Id).Any();
                bool usedInLocation = _locationRepository.Queryable(l => l.OrganismePayeurId == request.Id).Any();

                if (!usedInClient)
                {
                    _organismePayeurRepository.Remove(organismePayeurModel);

                    if (await _organismePayeurRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new OrganismePayeurDeletedEvent(organismePayeurModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("OrganismePayeur cannot been deleted because it is used by Client");
                }

                if (!usedInLocation)
                {
                    _organismePayeurRepository.Remove(organismePayeurModel);

                    if (await _organismePayeurRepository.SaveChangesAsync() == 0)
                    {
                        throw new ApplicationException("Deletion Failed");
                    }

                    await _mediator.Publish(new OrganismePayeurDeletedEvent(organismePayeurModel.Id), cancellationToken);

                    return new DeleteResult(true);

                }
                else
                {
                    throw new ApplicationException("OrganismePayeur cannot been deleted because it is used by Location");
                }
            }
            else
            {
                throw new ApplicationException("OrganismePayeur does no longer exist");
            }


        }
    }
}