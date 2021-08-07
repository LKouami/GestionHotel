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
    public class LocationvueRepository : Repository<Locationvue, LocationvueDto, ILocationvueDxos>, ILocationvueRepository
    {
        public LocationvueRepository(NoyauxButlerDBContext dbContext,
           ILogger<LocationRepository> logger,
           ILocationvueDxos locationvueDxos) : base(dbContext, logger, locationvueDxos)
        {
            //Code removed here
        }
    }
}
