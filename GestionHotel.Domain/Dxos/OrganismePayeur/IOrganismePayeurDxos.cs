using GestionHotel.Domain.Commands.OrganismePayeur;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IOrganismePayeurDxos : IBaseDxos
    {
        OrganismePayeurDto MapOrganismePayeurDto(SOrganismePayeur organismePayeur);
        SOrganismePayeur MapCreateRequesttoOrganismePayeur(CreateOrganismePayeurCommand organismePayeur);
        SOrganismePayeur MapUpdateRequesttoOrganismePayeur(UpdateOrganismePayeurCommand organismePayeur);
    }
}
