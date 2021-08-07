using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.OrganismePayeur;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetOrganismePayeursHandler : IRequestHandler<GetOrganismePayeursQuery, PagedResults<OrganismePayeurDto>>
    {
        private readonly IOrganismePayeurRepository _organismePayeurRepository;
        private readonly ILogger _logger;

        public GetOrganismePayeursHandler(IOrganismePayeurRepository organismePayeurRepository, IOrganismePayeurDxos organismePayeurDxos,
            ILogger<GetOrganismePayeursHandler> logger)
        {
            _organismePayeurRepository = organismePayeurRepository ?? throw new ArgumentNullException(nameof(organismePayeurRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<OrganismePayeurDto>> Handle(GetOrganismePayeursQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _organismePayeurRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _organismePayeurRepository.GetListPageAsync(request,
               p =>
                   p.Nom.ToLower().StartsWith(request.Search));
            }

        }
    }
}