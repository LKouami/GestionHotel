using AutoMapper;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class AffectationMaterielvueDxos : BaseDxos, IAffectationMaterielvueDxos
    {
        public AffectationMaterielvueDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AffectationMaterielvue, AffectationMaterielvueDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.MaterielId, opt => opt.MapFrom(src => src.MaterielId))
                  .ForMember(dst => dst.EspaceId, opt => opt.MapFrom(src => src.EspaceId))
                  .ForMember(dst => dst.MaNom, opt => opt.MapFrom(src => src.MaNom))
                  .ForMember(dst => dst.MaQuantite, opt => opt.MapFrom(src => src.EspaceId))
                  .ForMember(dst => dst.EsNumero, opt => opt.MapFrom(src => src.EsNumero))
                  .ForMember(dst => dst.EsNom, opt => opt.MapFrom(src => src.EsNom))
                  .ForMember(dst => dst.EsSituation, opt => opt.MapFrom(src => src.EsSituation))
                  .ForMember(dst => dst.EsPrix, opt => opt.MapFrom(src => src.EsPrix))
                  .ForMember(dst => dst.EsDescription, opt => opt.MapFrom(src => src.EsDescription))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                
            });

            _mapper = config.CreateMapper();
        }


        public AffectationMaterielvueDto MapAffectationMaterielvueDto(AffectationMaterielvue AffectationMaterielvueModel)
        {
            return _mapper.Map<AffectationMaterielvue, AffectationMaterielvueDto>(AffectationMaterielvueModel);
        }

    }
}
