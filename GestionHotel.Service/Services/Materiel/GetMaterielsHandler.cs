using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using GestionHotel.Domain.Queries.Materiel;
using GestionHotel.Domain.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services
{
    public class GetMaterielsHandler : IRequestHandler<GetMaterielsQuery, PagedResults<MaterielDto>>
    {
        private readonly IMaterielRepository _materielRepository;
        private readonly ILogger _logger;

        public GetMaterielsHandler(IMaterielRepository materielRepository, IMaterielDxos materielDxos,
            ILogger<GetMaterielsHandler> logger)
        {
            _materielRepository = materielRepository ?? throw new ArgumentNullException(nameof(materielRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PagedResults<MaterielDto>> Handle(GetMaterielsQuery request, CancellationToken cancellationToken)
        {
            if (String.IsNullOrWhiteSpace(request.Search))
            {
                return await _materielRepository.GetListPageAsync(request, null);
            }
            else
            {
                return await _materielRepository.GetListPageAsync(request,
               p =>
                   p.Nom.ToLower().StartsWith(request.Search));
            }

        }
    }
}