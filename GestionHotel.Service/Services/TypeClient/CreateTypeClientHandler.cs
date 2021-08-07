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
    public class CreateTypeClientHandler : IRequestHandler<CreateTypeClientCommand, TypeClientDto>
    {
        private readonly ITypeClientRepository _typeClientRepository;
        private readonly ITypeClientDxos _typeClientDxos;
        private readonly IMediator _mediator;

        public CreateTypeClientHandler(ITypeClientRepository typeClientRepository,
            IMediator mediator,
            ITypeClientDxos typeClientDxos)
        {
            _typeClientRepository = typeClientRepository ?? throw new ArgumentNullException(nameof(typeClientRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _typeClientDxos = typeClientDxos ?? throw new ArgumentNullException(nameof(typeClientDxos));
        }


        public async Task<TypeClientDto> Handle(CreateTypeClientCommand request, CancellationToken cancellationToken)
        {
            var typeClientModel = _typeClientDxos.MapCreateRequesttoTypeClient(request);

            _typeClientRepository.Add(typeClientModel);

            if (await _typeClientRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException("Insertion to database failed");
            }

            await _mediator.Publish(new TypeClientCreatedEvent(typeClientModel.Id), cancellationToken);

            var typeClientDto = _typeClientDxos.MapTypeClientDto(typeClientModel);

            return typeClientDto;
        }
    }
}