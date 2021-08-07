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
    public class EtatEspaceRepository : Repository<SEtatEspace, EtatEspaceDto, IEtatEspaceDxos>, IEtatEspaceRepository
    {
        public EtatEspaceRepository(NoyauxButlerDBContext dbContext,
           ILogger<EtatEspaceRepository> logger,
           IEtatEspaceDxos etatEspaceDxos) : base(dbContext, logger, etatEspaceDxos)
        {
            //Code removed here
        }
    }
}
