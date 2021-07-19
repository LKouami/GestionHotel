using GestionHotel.Domain.Commands.Reserver;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IReserverDxos : IBaseDxos
    {
        ReserverDto MapReserverDto(SReserver reserver);
        SReserver MapCreateRequesttoReserver(CreateReserverCommand reserver);
        SReserver MapUpdateRequesttoReserver(UpdateReserverCommand reserver);
    }
}
