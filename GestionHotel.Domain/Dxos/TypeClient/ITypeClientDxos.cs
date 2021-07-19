using GestionHotel.Domain.Commands.TypeClient;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface ITypeClientDxos : IBaseDxos
    {
        TypeClientDto MapTypeClientDto(STypeClient typeClient);
        STypeClient MapCreateRequesttoTypeClient(CreateTypeClientCommand typeClient);
        STypeClient MapUpdateRequesttoTypeClient(UpdateTypeClientCommand typeClient);
    }
}
