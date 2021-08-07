using AutoMapper;
using GestionHotel.Data.IRepositories;
using GestionHotel.Model.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;

namespace GestionHotel.Data.Repositories
{
    public class EspacevueRepository : Repository<Espacevue, EspacevueDto, IEspacevueDxos>, IEspacevueRepository
    {
        public EspacevueRepository(NoyauxButlerDBContext dbContext,
           ILogger<EspaceRepository> logger,
           IEspacevueDxos espacevueDxos) : base(dbContext, logger, espacevueDxos)
        {
            //Code removed here
        }
    }
}
