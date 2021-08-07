using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.AffectationMateriel;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.AffectationMateriel;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class CreateAffectationMaterielHandler : IRequestHandler<CreateAffectationMaterielCommand, AffectationMaterielDto>
    {
        private readonly IAffectationMaterielRepository _affectationMaterielRepository;
        private readonly IAffectationMaterielDxos _affectationMaterielDxos;
        private readonly IMediator _mediator;

        public CreateAffectationMaterielHandler(IAffectationMaterielRepository affectationMaterielRepository,
            IMediator mediator,
            IAffectationMaterielDxos affectationMaterielDxos)
        {
            _affectationMaterielRepository = affectationMaterielRepository ?? throw new ArgumentNullException(nameof(affectationMaterielRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _affectationMaterielDxos = affectationMaterielDxos ?? throw new ArgumentNullException(nameof(affectationMaterielDxos));
        }


        public async Task<AffectationMaterielDto> Handle(CreateAffectationMaterielCommand request, CancellationToken cancellationToken)
        {
            var affectationMaterielModel = _affectationMaterielDxos.MapCreateRequesttoAffectationMateriel(request);

            _affectationMaterielRepository.Add(affectationMaterielModel);

            if (await _affectationMaterielRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Insertion to database failed");
            }

            await _mediator.Publish(new AffectationMaterielCreatedEvent(affectationMaterielModel.Id), cancellationToken);

            var affectationMaterielDto = _affectationMaterielDxos.MapAffectationMaterielDto(affectationMaterielModel);

            return affectationMaterielDto;
        }
    }
}