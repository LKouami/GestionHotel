using GestionHotel.Domain.Commands.EtatEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IEtatEspaceDxos : IBaseDxos
    {
        EtatEspaceDto MapEtatEspaceDto(SEtatEspace espace);
        SEtatEspace MapCreateRequesttoEtatEspace(CreateEtatEspaceCommand espace);
        SEtatEspace MapUpdateRequesttoEtatEspace(UpdateEtatEspaceCommand espace);
    }
}
