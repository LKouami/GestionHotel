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
    public class MaterielRepository : Repository<SMateriel, MaterielDto, IMaterielDxos>, IMaterielRepository
    {
        public MaterielRepository(NoyauxButlerDBContext dbContext,
           ILogger<MaterielRepository> logger,
           IMaterielDxos materielDxos) : base(dbContext, logger, materielDxos)
        {
            //Code removed here
        }
    }
}
