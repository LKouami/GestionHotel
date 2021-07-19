using AutoMapper;
using GestionHotel.Domain.Commands.TypeEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class TypeEspaceDxos : BaseDxos, ITypeEspaceDxos
    {
        public TypeEspaceDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<STypeEspace, TypeEspaceDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateTypeEspaceCommand, STypeEspace>()
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateTypeEspaceCommand, STypeEspace>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public STypeEspace MapCreateRequesttoTypeEspace(CreateTypeEspaceCommand request)
        {
            return _mapper.Map<CreateTypeEspaceCommand, STypeEspace>(request);
        }

        public TypeEspaceDto MapTypeEspaceDto(STypeEspace TypeEspaceModel)
        {
            return _mapper.Map<STypeEspace, TypeEspaceDto>(TypeEspaceModel);
        }

        public STypeEspace MapUpdateRequesttoTypeEspace(UpdateTypeEspaceCommand request)
        {
            return _mapper.Map<UpdateTypeEspaceCommand, STypeEspace>(request);
        }
    }
}
