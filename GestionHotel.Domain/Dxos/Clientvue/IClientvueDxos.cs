using GestionHotel.Domain.Commands.Client;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IClientvueDxos : IBaseDxos
    {
        ClientvueDto MapClientvueDto(Clientvue clientvue);
    }
}
