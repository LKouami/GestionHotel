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
    public class AffectationMaterielRepository : Repository<SAffectationMateriel, AffectationMaterielDto, IAffectationMaterielDxos>, IAffectationMaterielRepository
    {
        public AffectationMaterielRepository(NoyauxButlerDBContext dbContext,
           ILogger<AffectationMaterielRepository> logger,
           IAffectationMaterielDxos affectationMaterielDxos) : base(dbContext, logger, affectationMaterielDxos)
        {
            //Code removed here
        }
    }
}
