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
    public class UpdateEtatEspaceHandler : IRequestHandler<UpdateEtatEspaceCommand, EtatEspaceDto>
    {
        private readonly IEtatEspaceRepository _etatEspaceRepository;
        private readonly IEtatEspaceDxos _etatEspaceDxos;
        private readonly IMediator _mediator;

        public UpdateEtatEspaceHandler(IEtatEspaceRepository etatEspaceRepository,
            IMediator mediator,
            IEtatEspaceDxos etatEspaceDxos)
        {
            _etatEspaceRepository = etatEspaceRepository ?? throw new ArgumentNullException(nameof(etatEspaceRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _etatEspaceDxos = etatEspaceDxos ?? throw new ArgumentNullException(nameof(etatEspaceDxos));
        }


        public async Task<EtatEspaceDto> Handle(UpdateEtatEspaceCommand request, CancellationToken cancellationToken)
        {
            var etatEspaceModel = _etatEspaceDxos.MapUpdateRequesttoEtatEspace(request);

            _etatEspaceRepository.Update(etatEspaceModel);

            if (await _etatEspaceRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Update in database failed");
            }

            await _mediator.Publish(new EtatEspaceUpdatedEvent(etatEspaceModel.Id), cancellationToken);

            var etatEspaceDto = _etatEspaceDxos.MapEtatEspaceDto(etatEspaceModel);

            return etatEspaceDto;
        }
    }
}