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
    public class OrganismePayeurRepository : Repository<SOrganismePayeur, OrganismePayeurDto, IOrganismePayeurDxos>, IOrganismePayeurRepository
    {
        public OrganismePayeurRepository(NoyauxButlerDBContext dbContext,
           ILogger<OrganismePayeurRepository> logger,
           IOrganismePayeurDxos organismePayeurDxos) : base(dbContext, logger, organismePayeurDxos)
        {
            //Code removed here
        }
    }
}
