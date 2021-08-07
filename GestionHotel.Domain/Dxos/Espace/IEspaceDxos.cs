using GestionHotel.Domain.Commands.Espace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IEspaceDxos : IBaseDxos
    {
        EspaceDto MapEspaceDto(SEspace espace);
        SEspace MapCreateRequesttoEspace(CreateEspaceCommand espace);
        SEspace MapUpdateRequesttoEspace(UpdateEspaceCommand espace);
    }
}
