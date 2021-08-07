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
    public class ClientvueRepository : Repository<Clientvue, ClientvueDto, IClientvueDxos>, IClientvueRepository
    {
        public ClientvueRepository(NoyauxButlerDBContext dbContext,
           ILogger<ClientRepository> logger,
           IClientvueDxos clientvueDxos) : base(dbContext, logger, clientvueDxos)
        {
            //Code removed here
        }
    }
}
