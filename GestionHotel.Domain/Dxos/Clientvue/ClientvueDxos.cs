using AutoMapper;
using GestionHotel.Domain.Commands.Client;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class ClientvueDxos : BaseDxos, IClientvueDxos
    {
        public ClientvueDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Clientvue, ClientvueDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.TcId, opt => opt.MapFrom(src => src.TcId))
                  .ForMember(dst => dst.TcNom, opt => opt.MapFrom(src => src.TcNom))
                  .ForMember(dst => dst.TcStatus, opt => opt.MapFrom(src => src.TcStatus))
                  .ForMember(dst => dst.OrId, opt => opt.MapFrom(src => src.OrId))
                  .ForMember(dst => dst.OrAdresse, opt => opt.MapFrom(src => src.OrAdresse))
                  .ForMember(dst => dst.OrEmail, opt => opt.MapFrom(src => src.OrEmail))
                  .ForMember(dst => dst.OrTel, opt => opt.MapFrom(src => src.OrTel))
                  .ForMember(dst => dst.OrStatus, opt => opt.MapFrom(src => src.OrStatus))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Prenom, opt => opt.MapFrom(src => src.Prenom))
                  .ForMember(dst => dst.Nationalite, opt => opt.MapFrom(src => src.Nationalite))
                  .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                  .ForMember(dst => dst.DateNaissance, opt => opt.MapFrom(src => src.DateNaissance))
                  .ForMember(dst => dst.DomicileHabituel, opt => opt.MapFrom(src => src.DomicileHabituel))
                  .ForMember(dst => dst.Tel, opt => opt.MapFrom(src => src.Tel))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                    ;
            });

            _mapper = config.CreateMapper();
        }


        public ClientvueDto MapClientvueDto(Clientvue ClientvueModel)
        {
            return _mapper.Map<Clientvue, ClientvueDto>(ClientvueModel);
        }

    }
}
