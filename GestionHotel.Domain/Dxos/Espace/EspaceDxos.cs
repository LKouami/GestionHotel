using AutoMapper;
using GestionHotel.Domain.Commands.Espace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class EspaceDxos : BaseDxos, IEspaceDxos
    {
        public EspaceDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SEspace, EspaceDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Numero, opt => opt.MapFrom(src => src.Numero))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Situation, opt => opt.MapFrom(src => src.Situation))
                  .ForMember(dst => dst.Prix, opt => opt.MapFrom(src => src.Prix))
                  .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description))
                  .ForMember(dst => dst.TypeEspaceId, opt => opt.MapFrom(src => src.TypeEspaceId))
                  .ForMember(dst => dst.EtatEspaceId, opt => opt.MapFrom(src => src.EtatEspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateEspaceCommand, SEspace>()
                  .ForMember(dst => dst.Numero, opt => opt.MapFrom(src => src.Numero))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Situation, opt => opt.MapFrom(src => src.Situation))
                  .ForMember(dst => dst.Prix, opt => opt.MapFrom(src => src.Prix))
                  .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description))
                  .ForMember(dst => dst.TypeEspaceId, opt => opt.MapFrom(src => src.TypeEspaceId))
                  .ForMember(dst => dst.EtatEspaceId, opt => opt.MapFrom(src => src.EtatEspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateEspaceCommand, SEspace>()
                    .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Numero, opt => opt.MapFrom(src => src.Numero))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Situation, opt => opt.MapFrom(src => src.Situation))
                  .ForMember(dst => dst.Prix, opt => opt.MapFrom(src => src.Prix))
                  .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description))
                  .ForMember(dst => dst.TypeEspaceId, opt => opt.MapFrom(src => src.TypeEspaceId))
                  .ForMember(dst => dst.EtatEspaceId, opt => opt.MapFrom(src => src.EtatEspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SEspace MapCreateRequesttoEspace(CreateEspaceCommand request)
        {
            return _mapper.Map<CreateEspaceCommand, SEspace>(request);
        }

        public EspaceDto MapEspaceDto(SEspace EspaceModel)
        {
            return _mapper.Map<SEspace, EspaceDto>(EspaceModel);
        }

        public SEspace MapUpdateRequesttoEspace(UpdateEspaceCommand request)
        {
            return _mapper.Map<UpdateEspaceCommand, SEspace>(request);
        }
    }
}
