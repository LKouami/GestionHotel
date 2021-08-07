using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IRoleDxos: IBaseDxos
    {
        RoleDto MapRoleDto(ARole employee);
        //ARole MapCreateRequesttoRole(CreateRoleCommand employee);
        //ARole MapUpdateRequesttoRole(UpdateRoleCommand employee);
    }
}