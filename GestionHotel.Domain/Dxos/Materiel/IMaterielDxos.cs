using GestionHotel.Domain.Commands.Materiel;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IMaterielDxos : IBaseDxos
    {
        MaterielDto MapMaterielDto(SMateriel materiel);
        SMateriel MapCreateRequesttoMateriel(CreateMaterielCommand materiel);
        SMateriel MapUpdateRequesttoMateriel(UpdateMaterielCommand materiel);
    }
}
