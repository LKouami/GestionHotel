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
    public class TypeEspaceRepository : Repository<STypeEspace, TypeEspaceDto, ITypeEspaceDxos>, ITypeEspaceRepository
    {
        public TypeEspaceRepository(NoyauxButlerDBContext dbContext,
           ILogger<TypeEspaceRepository> logger,
           ITypeEspaceDxos typeEspaceDxos) : base(dbContext, logger, typeEspaceDxos)
        {
            //Code removed here
        }
    }
}
