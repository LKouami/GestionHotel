using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Espace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Espace;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class UpdateEspaceHandler : IRequestHandler<UpdateEspaceCommand, EspaceDto>
    {
        private readonly IEspaceRepository _espaceRepository;
        private readonly IEspaceDxos _espaceDxos;
        private readonly IMediator _mediator;

        public UpdateEspaceHandler(IEspaceRepository espaceRepository,
            IMediator mediator,
            IEspaceDxos espaceDxos)
        {
            _espaceRepository = espaceRepository ?? throw new ArgumentNullException(nameof(espaceRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _espaceDxos = espaceDxos ?? throw new ArgumentNullException(nameof(espaceDxos));
        }


        public async Task<EspaceDto> Handle(UpdateEspaceCommand request, CancellationToken cancellationToken)
        {
            var espaceModel = _espaceDxos.MapUpdateRequesttoEspace(request);

            _espaceRepository.Update(espaceModel);

            if (await _espaceRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Update in database failed");
            }

            await _mediator.Publish(new EspaceUpdatedEvent(espaceModel.Id), cancellationToken);

            var espaceDto = _espaceDxos.MapEspaceDto(espaceModel);

            return espaceDto;
        }
    }
}