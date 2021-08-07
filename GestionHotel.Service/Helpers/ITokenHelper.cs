using GestionHotel.Model.Models;
using System.Threading.Tasks;

namespace GestionHotel.Service.Services.Helpers
{
    public interface ITokenHelper
    {
        Task<string> CreateJWTAsync(AUser user);

    }

}
