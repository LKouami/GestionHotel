using GestionHotel.Domain.Commands.Client;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IClientDxos : IBaseDxos
    {
        ClientDto MapClientDto(SClient client);
        SClient MapCreateRequesttoClient(CreateClientCommand client);
        SClient MapUpdateRequesttoClient(UpdateClientCommand client);
    }
}
