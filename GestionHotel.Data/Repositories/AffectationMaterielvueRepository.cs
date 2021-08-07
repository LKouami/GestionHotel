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
    public class AffectationMaterielvueRepository : Repository<AffectationMaterielvue, AffectationMaterielvueDto, IAffectationMaterielvueDxos>, IAffectationMaterielvueRepository
    {
        public AffectationMaterielvueRepository(NoyauxButlerDBContext dbContext,
           ILogger<AffectationMaterielvueRepository> logger,
           IAffectationMaterielvueDxos affectationMaterielvueDxos) : base(dbContext, logger, affectationMaterielvueDxos)
        {
            //Code removed here
        }
    }
}
