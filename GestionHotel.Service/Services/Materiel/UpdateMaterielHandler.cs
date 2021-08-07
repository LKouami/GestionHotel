using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.Materiel;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.Materiel;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class UpdateMaterielHandler : IRequestHandler<UpdateMaterielCommand, MaterielDto>
    {
        private readonly IMaterielRepository _materielRepository;
        private readonly IMaterielDxos _materielDxos;
        private readonly IMediator _mediator;

        public UpdateMaterielHandler(IMaterielRepository materielRepository,
            IMediator mediator,
            IMaterielDxos materielDxos)
        {
            _materielRepository = materielRepository ?? throw new ArgumentNullException(nameof(materielRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _materielDxos = materielDxos ?? throw new ArgumentNullException(nameof(materielDxos));
        }


        public async Task<MaterielDto> Handle(UpdateMaterielCommand request, CancellationToken cancellationToken)
        {
            var materielModel = _materielDxos.MapUpdateRequesttoMateriel(request);

            _materielRepository.Update(materielModel);

            if (await _materielRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Update in database failed");
            }

            await _mediator.Publish(new MaterielUpdatedEvent(materielModel.Id), cancellationToken);

            var materielDto = _materielDxos.MapMaterielDto(materielModel);

            return materielDto;
        }
    }
}