using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.TypeClient;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetTypeClientHandler : IRequestHandler<GetTypeClientQuery, TypeClientDto>
    {
        private readonly ITypeClientRepository _typeClientRepository;
        private readonly ITypeClientDxos _typeClientDxos;
        private readonly ILogger _logger;

        public GetTypeClientHandler(ITypeClientRepository typeClientRepository, ITypeClientDxos typeClientDxos, ILogger<GetTypeClientHandler> logger)
        {
            _typeClientRepository = typeClientRepository ?? throw new ArgumentNullException(nameof(typeClientRepository));
            _typeClientDxos = typeClientDxos ?? throw new ArgumentNullException(nameof(typeClientDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<TypeClientDto> Handle(GetTypeClientQuery request, CancellationToken cancellationToken)
        {
            var typeClient = await _typeClientRepository.GetAsync(e =>
                e.Id == request.Id);

            if (typeClient != null)
            {
                _logger.LogInformation($"Got a request get typeClient Id: {typeClient.Id}");
                var typeClientDto = _typeClientDxos.MapTypeClientDto(typeClient);
                return typeClientDto;
            }

            return null;
        }
    }
}