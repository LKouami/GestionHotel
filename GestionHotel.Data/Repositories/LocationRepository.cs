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
    public class LocationRepository : Repository<SLocation, LocationDto, ILocationDxos>, ILocationRepository
    {
        public LocationRepository(NoyauxButlerDBContext dbContext,
           ILogger<LocationRepository> logger,
           ILocationDxos locationDxos) : base(dbContext, logger, locationDxos)
        {
            //Code removed here
        }
    }
}
