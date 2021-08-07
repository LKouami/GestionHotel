using GestionHotel.Domain.Commands.Location;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface ILocationDxos : IBaseDxos
    {
        LocationDto MapLocationDto(SLocation location);
        SLocation MapCreateRequesttoLocation(CreateLocationCommand location);
        SLocation MapUpdateRequesttoLocation(UpdateLocationCommand location);
    }
}
