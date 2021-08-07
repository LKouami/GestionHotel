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
    public class TypeClientRepository : Repository<STypeClient, TypeClientDto, ITypeClientDxos>, ITypeClientRepository
    {
        public TypeClientRepository(NoyauxButlerDBContext dbContext,
           ILogger<TypeClientRepository> logger,
           ITypeClientDxos typeClientDxos) : base(dbContext, logger, typeClientDxos)
        {
            //Code removed here
        }
    }
}
