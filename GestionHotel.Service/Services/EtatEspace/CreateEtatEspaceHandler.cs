using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.EtatEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.EtatEspace;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class CreateEtatEspaceHandler : IRequestHandler<CreateEtatEspaceCommand, EtatEspaceDto>
    {
        private readonly IEtatEspaceRepository _etatEspaceRepository;
        private readonly IEtatEspaceDxos _etatEspaceDxos;
        private readonly IMediator _mediator;

        public CreateEtatEspaceHandler(IEtatEspaceRepository etatEspaceRepository,
            IMediator mediator,
            IEtatEspaceDxos etatEspaceDxos)
        {
            _etatEspaceRepository = etatEspaceRepository ?? throw new ArgumentNullException(nameof(etatEspaceRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _etatEspaceDxos = etatEspaceDxos ?? throw new ArgumentNullException(nameof(etatEspaceDxos));
        }


        public async Task<EtatEspaceDto> Handle(CreateEtatEspaceCommand request, CancellationToken cancellationToken)
        {
            var etatEspaceModel = _etatEspaceDxos.MapCreateRequesttoEtatEspace(request);

            _etatEspaceRepository.Add(etatEspaceModel);

            if (await _etatEspaceRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Insertion to database failed");
            }

            await _mediator.Publish(new EtatEspaceCreatedEvent(etatEspaceModel.Id), cancellationToken);

            var etatEspaceDto = _etatEspaceDxos.MapEtatEspaceDto(etatEspaceModel);

            return etatEspaceDto;
        }
    }
}