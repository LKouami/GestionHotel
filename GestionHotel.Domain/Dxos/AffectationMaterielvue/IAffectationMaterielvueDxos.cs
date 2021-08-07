using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IAffectationMaterielvueDxos : IBaseDxos
    {
        AffectationMaterielvueDto MapAffectationMaterielvueDto(AffectationMaterielvue client);
    }
}
