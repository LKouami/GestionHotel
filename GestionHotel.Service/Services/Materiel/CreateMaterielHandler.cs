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
    public class CreateMaterielHandler : IRequestHandler<CreateMaterielCommand, MaterielDto>
    {
        private readonly IMaterielRepository _materielRepository;
        private readonly IMaterielDxos _materielDxos;
        private readonly IMediator _mediator;

        public CreateMaterielHandler(IMaterielRepository materielRepository,
            IMediator mediator,
            IMaterielDxos materielDxos)
        {
            _materielRepository = materielRepository ?? throw new ArgumentNullException(nameof(materielRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _materielDxos = materielDxos ?? throw new ArgumentNullException(nameof(materielDxos));
        }


        public async Task<MaterielDto> Handle(CreateMaterielCommand request, CancellationToken cancellationToken)
        {
            var materielModel = _materielDxos.MapCreateRequesttoMateriel(request);

            _materielRepository.Add(materielModel);

            if (await _materielRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Insertion to database failed");
            }

            await _mediator.Publish(new MaterielCreatedEvent(materielModel.Id), cancellationToken);

            var materielDto = _materielDxos.MapMaterielDto(materielModel);

            return materielDto;
        }
    }
}