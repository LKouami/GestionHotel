using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.TypeEspace;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetTypeEspaceHandler : IRequestHandler<GetTypeEspaceQuery, TypeEspaceDto>
    {
        private readonly ITypeEspaceRepository _typeEspaceRepository;
        private readonly ITypeEspaceDxos _typeEspaceDxos;
        private readonly ILogger _logger;

        public GetTypeEspaceHandler(ITypeEspaceRepository typeEspaceRepository, ITypeEspaceDxos typeEspaceDxos, ILogger<GetTypeEspaceHandler> logger)
        {
            _typeEspaceRepository = typeEspaceRepository ?? throw new ArgumentNullException(nameof(typeEspaceRepository));
            _typeEspaceDxos = typeEspaceDxos ?? throw new ArgumentNullException(nameof(typeEspaceDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<TypeEspaceDto> Handle(GetTypeEspaceQuery request, CancellationToken cancellationToken)
        {
            var typeEspace = await _typeEspaceRepository.GetAsync(e =>
                e.Id == request.Id);

            if (typeEspace != null)
            {
                _logger.LogInformation($"Got a request get typeEspace Id: {typeEspace.Id}");
                var typeEspaceDto = _typeEspaceDxos.MapTypeEspaceDto(typeEspace);
                return typeEspaceDto;
            }

            return null;
        }
    }
}