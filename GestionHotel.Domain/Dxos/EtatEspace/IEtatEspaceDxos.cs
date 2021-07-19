using GestionHotel.Domain.Commands.EtatEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IEtatEspaceDxos : IBaseDxos
    {
        EtatEspaceDto MapEtatEspaceDto(SEtatEspace etatEspace);
        SEtatEspace MapCreateRequesttoEtatEspace(CreateEtatEspaceCommand etatEspace);
        SEtatEspace MapUpdateRequesttoEtatEspace(UpdateEtatEspaceCommand etatEspace);
    }
}
