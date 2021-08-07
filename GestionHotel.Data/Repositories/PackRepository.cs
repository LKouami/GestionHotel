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
    public class PackRepository : Repository<SPack, PackDto, IPackDxos>, IPackRepository
    {
        public PackRepository(NoyauxButlerDBContext dbContext,
           ILogger<PackRepository> logger,
           IPackDxos packDxos) : base(dbContext, logger, packDxos)
        {
            //Code removed here
        }
    }
}
