using GestionHotel.Domain.Commands.User;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IUserDxos : IBaseDxos
    {
        UserDto MapUserDto(AUser user);
        AUser MapCreateRequesttoUser(CreateUserCommand user);
        AUser MapUpdateRequesttoUser(UpdateUserCommand user);
    }
}
