using AutoMapper;
using GestionHotel.Domain.Commands.Promotion;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class PromotionDxos : BaseDxos, IPromotionDxos
    {
        public PromotionDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SPromotion, PromotionDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Libelle, opt => opt.MapFrom(src => src.Libelle))
                  .ForMember(dst => dst.Taux, opt => opt.MapFrom(src => src.Taux))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreatePromotionCommand, SPromotion>()
                  .ForMember(dst => dst.Libelle, opt => opt.MapFrom(src => src.Libelle))
                  .ForMember(dst => dst.Taux, opt => opt.MapFrom(src => src.Taux))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdatePromotionCommand, SPromotion>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Libelle, opt => opt.MapFrom(src => src.Libelle))
                  .ForMember(dst => dst.Taux, opt => opt.MapFrom(src => src.Taux))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SPromotion MapCreateRequesttoPromotion(CreatePromotionCommand request)
        {
            return _mapper.Map<CreatePromotionCommand, SPromotion>(request);
        }

        public PromotionDto MapPromotionDto(SPromotion PromotionModel)
        {
            return _mapper.Map<SPromotion, PromotionDto>(PromotionModel);
        }

        public SPromotion MapUpdateRequesttoPromotion(UpdatePromotionCommand request)
        {
            return _mapper.Map<UpdatePromotionCommand, SPromotion>(request);
        }
    }
}
