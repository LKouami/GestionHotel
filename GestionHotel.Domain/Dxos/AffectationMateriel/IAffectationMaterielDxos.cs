using GestionHotel.Domain.Commands.AffectationMateriel;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IAffectationMaterielDxos : IBaseDxos
    {
        AffectationMaterielDto MapAffectationMaterielDto(SAffectationMateriel client);
        SAffectationMateriel MapCreateRequesttoAffectationMateriel(CreateAffectationMaterielCommand client);
        SAffectationMateriel MapUpdateRequesttoAffectationMateriel(UpdateAffectationMaterielCommand client);
    }
}
