using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;

namespace GestionHotel.Data.IRepositories
{
    public interface IRoleRepository : IRepository<ARole, RoleDto>
    {
        Task<IEnumerable<ARole>> GetRolesFromUser(int userId);
        Task<IEnumerable<AClaim>> GetRolesClaimsFromUser(int userId);
    }
}