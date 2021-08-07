using AutoMapper;
using GestionHotel.Domain.Commands.AffectationMateriel;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class AffectationMaterielDxos : BaseDxos, IAffectationMaterielDxos
    {
        public AffectationMaterielDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SAffectationMateriel, AffectationMaterielDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.MaterielId, opt => opt.MapFrom(src => src.MaterielId))
                  .ForMember(dst => dst.EspaceId, opt => opt.MapFrom(src => src.EspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateAffectationMaterielCommand, SAffectationMateriel>()
                  .ForMember(dst => dst.MaterielId, opt => opt.MapFrom(src => src.MaterielId))
                  .ForMember(dst => dst.EspaceId, opt => opt.MapFrom(src => src.EspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateAffectationMaterielCommand, SAffectationMateriel>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.MaterielId, opt => opt.MapFrom(src => src.MaterielId))
                  .ForMember(dst => dst.EspaceId, opt => opt.MapFrom(src => src.EspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SAffectationMateriel MapCreateRequesttoAffectationMateriel(CreateAffectationMaterielCommand request)
        {
            return _mapper.Map<CreateAffectationMaterielCommand, SAffectationMateriel>(request);
        }

        public AffectationMaterielDto MapAffectationMaterielDto(SAffectationMateriel AffectationMaterielModel)
        {
            return _mapper.Map<SAffectationMateriel, AffectationMaterielDto>(AffectationMaterielModel);
        }

        public SAffectationMateriel MapUpdateRequesttoAffectationMateriel(UpdateAffectationMaterielCommand request)
        {
            return _mapper.Map<UpdateAffectationMaterielCommand, SAffectationMateriel>(request);
        }
    }
}
