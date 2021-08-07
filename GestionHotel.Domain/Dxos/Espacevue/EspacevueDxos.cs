using AutoMapper;
using GestionHotel.Domain.Commands.Espace;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class EspacevueDxos : BaseDxos, IEspacevueDxos
    {
        public EspacevueDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Espacevue, EspacevueDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.TeNom, opt => opt.MapFrom(src => src.TeNom))
                  .ForMember(dst => dst.EeLibelle, opt => opt.MapFrom(src => src.EeLibelle))
                  .ForMember(dst => dst.EeValeur, opt => opt.MapFrom(src => src.EeValeur))
                  .ForMember(dst => dst.Numero, opt => opt.MapFrom(src => src.Numero))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Situation, opt => opt.MapFrom(src => src.Situation))
                  .ForMember(dst => dst.Prix, opt => opt.MapFrom(src => src.Prix))
                  .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description))
                  .ForMember(dst => dst.EtatEspaceId, opt => opt.MapFrom(src => src.EtatEspaceId))
                  .ForMember(dst => dst.TypeEspaceId, opt => opt.MapFrom(src => src.TypeEspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                    ;
            });

            _mapper = config.CreateMapper();
        }


        public EspacevueDto MapEspacevueDto(Espacevue EspacevueModel)
        {
            return _mapper.Map<Espacevue, EspacevueDto>(EspacevueModel);
        }

    }
}
