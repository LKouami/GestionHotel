using GestionHotel.Domain.Commands.Espace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IEspacevueDxos : IBaseDxos
    {
        EspacevueDto MapEspacevueDto(Espacevue clientvue);
    }
}
