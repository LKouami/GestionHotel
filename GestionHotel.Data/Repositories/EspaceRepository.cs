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
    public class EspaceRepository : Repository<SEspace, EspaceDto, IEspaceDxos>, IEspaceRepository
    {
        public EspaceRepository(NoyauxButlerDBContext dbContext,
           ILogger<EspaceRepository> logger,
           IEspaceDxos espaceDxos) : base(dbContext, logger, espaceDxos)
        {
            //Code removed here
        }
    }
}
