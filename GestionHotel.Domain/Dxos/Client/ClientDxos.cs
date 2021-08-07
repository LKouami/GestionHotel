using AutoMapper;
using GestionHotel.Domain.Commands.Client;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class ClientDxos : BaseDxos, IClientDxos
    {
        public ClientDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SClient, ClientDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.TypeClientId, opt => opt.MapFrom(src => src.TypeClientId))
                  .ForMember(dst => dst.OrganismeId, opt => opt.MapFrom(src => src.OrganismeId))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Prenom, opt => opt.MapFrom(src => src.Prenom))
                  .ForMember(dst => dst.Nationalite, opt => opt.MapFrom(src => src.Nationalite))
                  .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                  .ForMember(dst => dst.DateNaissance, opt => opt.MapFrom(src => src.DateNaissance))
                  .ForMember(dst => dst.DomicileHabituel, opt => opt.MapFrom(src => src.DomicileHabituel))
                  .ForMember(dst => dst.Tel, opt => opt.MapFrom(src => src.Tel))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateClientCommand, SClient>()
                  .ForMember(dst => dst.TypeClientId, opt => opt.MapFrom(src => src.TypeClientId))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Prenom, opt => opt.MapFrom(src => src.Prenom))
                  .ForMember(dst => dst.Nationalite, opt => opt.MapFrom(src => src.Nationalite))
                  .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                  .ForMember(dst => dst.DateNaissance, opt => opt.MapFrom(src => src.DateNaissance))
                  .ForMember(dst => dst.DomicileHabituel, opt => opt.MapFrom(src => src.DomicileHabituel))
                  .ForMember(dst => dst.Tel, opt => opt.MapFrom(src => src.Tel))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateClientCommand, SClient>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.TypeClientId, opt => opt.MapFrom(src => src.TypeClientId))
                  .ForMember(dst => dst.OrganismeId, opt => opt.MapFrom(src => src.OrganismeId))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Prenom, opt => opt.MapFrom(src => src.Prenom))
                  .ForMember(dst => dst.Nationalite, opt => opt.MapFrom(src => src.Nationalite))
                  .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                  .ForMember(dst => dst.DateNaissance, opt => opt.MapFrom(src => src.DateNaissance))
                  .ForMember(dst => dst.DomicileHabituel, opt => opt.MapFrom(src => src.DomicileHabituel))
                  .ForMember(dst => dst.Tel, opt => opt.MapFrom(src => src.Tel))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SClient MapCreateRequesttoClient(CreateClientCommand request)
        {
            return _mapper.Map<CreateClientCommand, SClient>(request);
        }

        public ClientDto MapClientDto(SClient ClientModel)
        {
            return _mapper.Map<SClient, ClientDto>(ClientModel);
        }

        public SClient MapUpdateRequesttoClient(UpdateClientCommand request)
        {
            return _mapper.Map<UpdateClientCommand, SClient>(request);
        }
    }
}
