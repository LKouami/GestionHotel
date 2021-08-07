using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Locationvue;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetLocationvuesHandler : IRequestHandler<GetLocationvuesQuery, PagedResults<LocationvueDto>>
    {
        private readonly ILocationvueRepository _locationvueRepository;
        private readonly ILogger _logger;

        public GetLocationvuesHandler(ILocationvueRepository locationvueRepository, ILocationvueDxos locationvueDxos,
            ILogger<GetLocationvuesHandler> logger)
        {
            _locationvueRepository = locationvueRepository ?? throw new ArgumentNullException(nameof(locationvueRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<LocationvueDto>> Handle(GetLocationvuesQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _locationvueRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _locationvueRepository.GetListPageAsync(request,
               p =>
                   p.ClNom.ToLower().StartsWith(request.Search) ||

                   p.OrNom.ToLower().StartsWith(request.Search)


                   );

            }

        }
    }
}