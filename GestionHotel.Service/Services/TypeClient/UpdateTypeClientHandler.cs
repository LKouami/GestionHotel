using GestionHotel.Data.IRepositories;
using GestionHotel.Domain.Commands.TypeClient;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Events.TypeClient;
using GestionHotel.Domain.Dxos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class UpdateTypeClientHandler : IRequestHandler<UpdateTypeClientCommand, TypeClientDto>
    {
        private readonly ITypeClientRepository _typeClientRepository;
        private readonly ITypeClientDxos _typeClientDxos;
        private readonly IMediator _mediator;

        public UpdateTypeClientHandler(ITypeClientRepository typeClientRepository,
            IMediator mediator,
            ITypeClientDxos typeClientDxos)
        {
            _typeClientRepository = typeClientRepository ?? throw new ArgumentNullException(nameof(typeClientRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _typeClientDxos = typeClientDxos ?? throw new ArgumentNullException(nameof(typeClientDxos));
        }


        public async Task<TypeClientDto> Handle(UpdateTypeClientCommand request, CancellationToken cancellationToken)
        {
            var typeClientModel = _typeClientDxos.MapUpdateRequesttoTypeClient(request);

            _typeClientRepository.Update(typeClientModel);

            if (await _typeClientRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Update in database failed");
            }

            await _mediator.Publish(new TypeClientUpdatedEvent(typeClientModel.Id), cancellationToken);

            var typeClientDto = _typeClientDxos.MapTypeClientDto(typeClientModel);

            return typeClientDto;
        }
    }
}