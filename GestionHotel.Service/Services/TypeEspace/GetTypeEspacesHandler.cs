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
    public class GetTypeEspacesHandler : IRequestHandler<GetTypeEspacesQuery, PagedResults<TypeEspaceDto>>
    {
        private readonly ITypeEspaceRepository _typeEspaceRepository;
        private readonly ILogger _logger;

        public GetTypeEspacesHandler(ITypeEspaceRepository typeEspaceRepository, ITypeEspaceDxos typeEspaceDxos,
            ILogger<GetTypeEspacesHandler> logger)
        {
            _typeEspaceRepository = typeEspaceRepository ?? throw new ArgumentNullException(nameof(typeEspaceRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<TypeEspaceDto>> Handle(GetTypeEspacesQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _typeEspaceRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _typeEspaceRepository.GetListPageAsync(request,
               p =>
                   p.Nom.ToLower().StartsWith(request.Search));
            }

        }
    }
}