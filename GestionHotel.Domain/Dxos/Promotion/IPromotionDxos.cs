using GestionHotel.Domain.Commands.Promotion;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public interface IPromotionDxos : IBaseDxos
    {
        PromotionDto MapPromotionDto(SPromotion promotion);
        SPromotion MapCreateRequesttoPromotion(CreatePromotionCommand promotion);
        SPromotion MapUpdateRequesttoPromotion(UpdatePromotionCommand promotion);
    }
}
