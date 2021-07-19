using GestionHotel.Domain.Commands.TypeEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface ITypeEspaceDxos : IBaseDxos
    {
        TypeEspaceDto MapTypeEspaceDto(STypeEspace typeEspace);
        STypeEspace MapCreateRequesttoTypeEspace(CreateTypeEspaceCommand typeEspace);
        STypeEspace MapUpdateRequesttoTypeEspace(UpdateTypeEspaceCommand typeEspace);
    }
}
