using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.OrganismePayeur;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.OrganismePayeur;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class CreateOrganismePayeurHandler : IRequestHandler<CreateOrganismePayeurCommand, OrganismePayeurDto>
    {
        private readonly IOrganismePayeurRepository _organismePayeurRepository;
        private readonly IOrganismePayeurDxos _organismePayeurDxos;
        private readonly IMediator _mediator;

        public CreateOrganismePayeurHandler(IOrganismePayeurRepository organismePayeurRepository,
            IMediator mediator,
            IOrganismePayeurDxos organismePayeurDxos)
        {
            _organismePayeurRepository = organismePayeurRepository ?? throw new ArgumentNullException(nameof(organismePayeurRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _organismePayeurDxos = organismePayeurDxos ?? throw new ArgumentNullException(nameof(organismePayeurDxos));
        }


        public async Task<OrganismePayeurDto> Handle(CreateOrganismePayeurCommand request, CancellationToken cancellationToken)
        {
            var organismePayeurModel = _organismePayeurDxos.MapCreateRequesttoOrganismePayeur(request);

            _organismePayeurRepository.Add(organismePayeurModel);

            if (await _organismePayeurRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Insertion to database failed");
            }

            await _mediator.Publish(new OrganismePayeurCreatedEvent(organismePayeurModel.Id), cancellationToken);

            var organismePayeurDto = _organismePayeurDxos.MapOrganismePayeurDto(organismePayeurModel);

            return organismePayeurDto;
        }
    }
}