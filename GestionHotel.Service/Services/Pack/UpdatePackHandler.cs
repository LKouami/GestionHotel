using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Pack;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Pack;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class UpdatePackHandler : IRequestHandler<UpdatePackCommand, PackDto>
    {
        private readonly IPackRepository _packRepository;
        private readonly IPackDxos _packDxos;
        private readonly IMediator _mediator;

        public UpdatePackHandler(IPackRepository packRepository,
            IMediator mediator,
            IPackDxos packDxos)
        {
            _packRepository = packRepository ?? throw new ArgumentNullException(nameof(packRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _packDxos = packDxos ?? throw new ArgumentNullException(nameof(packDxos));
        }


        public async Task<PackDto> Handle(UpdatePackCommand request, CancellationToken cancellationToken)
        {
            var packModel = _packDxos.MapUpdateRequesttoPack(request);

            _packRepository.Update(packModel);

            if (await _packRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Update in database failed");
            }

            await _mediator.Publish(new PackUpdatedEvent(packModel.Id), cancellationToken);

            var packDto = _packDxos.MapPackDto(packModel);

            return packDto;
        }
    }
}