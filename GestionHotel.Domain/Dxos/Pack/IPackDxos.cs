using GestionHotel.Domain.Commands.Pack;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IPackDxos : IBaseDxos
    {
        PackDto MapPackDto(SPack pack);
        SPack MapCreateRequesttoPack(CreatePackCommand pack);
        SPack MapUpdateRequesttoPack(UpdatePackCommand pack);
    }
}
