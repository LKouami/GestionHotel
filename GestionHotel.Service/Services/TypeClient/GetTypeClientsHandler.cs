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
    public class GetTypeClientsHandler : IRequestHandler<GetTypeClientsQuery, PagedResults<TypeClientDto>>
    {
        private readonly ITypeClientRepository _typeClientRepository;
        private readonly ILogger _logger;

        public GetTypeClientsHandler(ITypeClientRepository typeClientRepository, ITypeClientDxos typeClientDxos,
            ILogger<GetTypeClientsHandler> logger)
        {
            _typeClientRepository = typeClientRepository ?? throw new ArgumentNullException(nameof(typeClientRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<TypeClientDto>> Handle(GetTypeClientsQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _typeClientRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _typeClientRepository.GetListPageAsync(request,
               p =>
                   p.Nom.ToLower().StartsWith(request.Search));
            }

        }
    }
}