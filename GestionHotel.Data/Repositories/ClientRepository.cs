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
    public class ClientRepository : Repository<SClient, ClientDto, IClientDxos>, IClientRepository
    {
        public ClientRepository(NoyauxButlerDBContext dbContext,
           ILogger<ClientRepository> logger,
           IClientDxos clientDxos) : base(dbContext, logger, clientDxos)
        {
            //Code removed here
        }
    }
}
