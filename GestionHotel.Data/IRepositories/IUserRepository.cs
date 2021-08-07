using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotel.Data.IRepositories
{
    public interface IUserRepository : IRepository<AUser, UserDto>
    {
        Task<AUser> Login(string email, string password);
        Task<bool> EmailExistAsync(string email);

        Task<IEnumerable<AClaim>> GetClaimsFromUser(int userId);
    }
}
