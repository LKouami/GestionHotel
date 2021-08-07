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
    public class GetOrganismePayeurHandler : IRequestHandler<GetOrganismePayeurQuery, OrganismePayeurDto>
    {
        private readonly IOrganismePayeurRepository _organismePayeurRepository;
        private readonly IOrganismePayeurDxos _organismePayeurDxos;
        private readonly ILogger _logger;

        public GetOrganismePayeurHandler(IOrganismePayeurRepository organismePayeurRepository, IOrganismePayeurDxos organismePayeurDxos, ILogger<GetOrganismePayeurHandler> logger)
        {
            _organismePayeurRepository = organismePayeurRepository ?? throw new ArgumentNullException(nameof(organismePayeurRepository));
            _organismePayeurDxos = organismePayeurDxos ?? throw new ArgumentNullException(nameof(organismePayeurDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<OrganismePayeurDto> Handle(GetOrganismePayeurQuery request, CancellationToken cancellationToken)
        {
            var organismePayeur = await _organismePayeurRepository.GetAsync(e =>
                e.Id == request.Id);

            if (organismePayeur != null)
            {
                _logger.LogInformation($"Got a request get organismePayeur Id: {organismePayeur.Id}");
                var organismePayeurDto = _organismePayeurDxos.MapOrganismePayeurDto(organismePayeur);
                return organismePayeurDto;
            }

            return null;
        }
    }
}