
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface ILocationvueDxos : IBaseDxos
    {
        LocationvueDto MapLocationvueDto(Locationvue location);
     }
}
