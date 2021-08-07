using AutoMapper;
using GestionHotel.Domain.Commands.OrganismePayeur;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class OrganismePayeurDxos : BaseDxos, IOrganismePayeurDxos
    {
        public OrganismePayeurDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SOrganismePayeur, OrganismePayeurDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                  .ForMember(dst => dst.Tel, opt => opt.MapFrom(src => src.Tel))
                  .ForMember(dst => dst.Adresse, opt => opt.MapFrom(src => src.Adresse))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateOrganismePayeurCommand, SOrganismePayeur>()
                   .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                  .ForMember(dst => dst.Tel, opt => opt.MapFrom(src => src.Tel))
                  .ForMember(dst => dst.Adresse, opt => opt.MapFrom(src => src.Adresse))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateOrganismePayeurCommand, SOrganismePayeur>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                   .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Email, opt => opt.MapFrom(src => src.Email))
                  .ForMember(dst => dst.Tel, opt => opt.MapFrom(src => src.Tel))
                  .ForMember(dst => dst.Adresse, opt => opt.MapFrom(src => src.Adresse))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SOrganismePayeur MapCreateRequesttoOrganismePayeur(CreateOrganismePayeurCommand request)
        {
            return _mapper.Map<CreateOrganismePayeurCommand, SOrganismePayeur>(request);
        }

        public OrganismePayeurDto MapOrganismePayeurDto(SOrganismePayeur OrganismePayeurModel)
        {
            return _mapper.Map<SOrganismePayeur, OrganismePayeurDto>(OrganismePayeurModel);
        }

        public SOrganismePayeur MapUpdateRequesttoOrganismePayeur(UpdateOrganismePayeurCommand request)
        {
            return _mapper.Map<UpdateOrganismePayeurCommand, SOrganismePayeur>(request);
        }
    }
}
