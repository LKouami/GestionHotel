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
    public class CreateEspaceHandler : IRequestHandler<CreateEspaceCommand, EspaceDto>
    {
        private readonly IEspaceRepository _espaceRepository;
        private readonly IEspaceDxos _espaceDxos;
        private readonly IMediator _mediator;

        public CreateEspaceHandler(IEspaceRepository espaceRepository,
            IMediator mediator,
            IEspaceDxos espaceDxos)
        {
            _espaceRepository = espaceRepository ?? throw new ArgumentNullException(nameof(espaceRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _espaceDxos = espaceDxos ?? throw new ArgumentNullException(nameof(espaceDxos));
        }


        public async Task<EspaceDto> Handle(CreateEspaceCommand request, CancellationToken cancellationToken)
        {
            var espaceModel = _espaceDxos.MapCreateRequesttoEspace(request);

            _espaceRepository.Add(espaceModel);

            if (await _espaceRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Insertion to database failed");
            }

            await _mediator.Publish(new EspaceCreatedEvent(espaceModel.Id), cancellationToken);

            var espaceDto = _espaceDxos.MapEspaceDto(espaceModel);

            return espaceDto;
        }
    }
}