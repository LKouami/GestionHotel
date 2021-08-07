using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.TypeEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.TypeEspace;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class UpdateTypeEspaceHandler : IRequestHandler<UpdateTypeEspaceCommand, TypeEspaceDto>
    {
        private readonly ITypeEspaceRepository _typeEspaceRepository;
        private readonly ITypeEspaceDxos _typeEspaceDxos;
        private readonly IMediator _mediator;

        public UpdateTypeEspaceHandler(ITypeEspaceRepository typeEspaceRepository,
            IMediator mediator,
            ITypeEspaceDxos typeEspaceDxos)
        {
            _typeEspaceRepository = typeEspaceRepository ?? throw new ArgumentNullException(nameof(typeEspaceRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _typeEspaceDxos = typeEspaceDxos ?? throw new ArgumentNullException(nameof(typeEspaceDxos));
        }


        public async Task<TypeEspaceDto> Handle(UpdateTypeEspaceCommand request, CancellationToken cancellationToken)
        {
            var typeEspaceModel = _typeEspaceDxos.MapUpdateRequesttoTypeEspace(request);

            _typeEspaceRepository.Update(typeEspaceModel);

            if (await _typeEspaceRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Update in database failed");
            }

            await _mediator.Publish(new TypeEspaceUpdatedEvent(typeEspaceModel.Id), cancellationToken);

            var typeEspaceDto = _typeEspaceDxos.MapTypeEspaceDto(typeEspaceModel);

            return typeEspaceDto;
        }
    }
}