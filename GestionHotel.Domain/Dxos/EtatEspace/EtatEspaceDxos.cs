using AutoMapper;
using GestionHotel.Domain.Commands.EtatEspace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class EtatEspaceDxos : BaseDxos, IEtatEspaceDxos
    {
        public EtatEspaceDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SEtatEspace, EtatEspaceDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Libelle, opt => opt.MapFrom(src => src.Libelle))
                  .ForMember(dst => dst.Valeur, opt => opt.MapFrom(src => src.Valeur))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateEtatEspaceCommand, SEtatEspace>()
                  .ForMember(dst => dst.Libelle, opt => opt.MapFrom(src => src.Libelle))
                  .ForMember(dst => dst.Valeur, opt => opt.MapFrom(src => src.Valeur))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateEtatEspaceCommand, SEtatEspace>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Libelle, opt => opt.MapFrom(src => src.Libelle))
                  .ForMember(dst => dst.Valeur, opt => opt.MapFrom(src => src.Valeur))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SEtatEspace MapCreateRequesttoEtatEspace(CreateEtatEspaceCommand request)
        {
            return _mapper.Map<CreateEtatEspaceCommand, SEtatEspace>(request);
        }

        public EtatEspaceDto MapEtatEspaceDto(SEtatEspace EtatEspaceModel)
        {
            return _mapper.Map<SEtatEspace, EtatEspaceDto>(EtatEspaceModel);
        }

        public SEtatEspace MapUpdateRequesttoEtatEspace(UpdateEtatEspaceCommand request)
        {
            return _mapper.Map<UpdateEtatEspaceCommand, SEtatEspace>(request);
        }
    }
}
