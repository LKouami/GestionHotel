using AutoMapper;
using GestionHotel.Domain.Commands.Pack;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class PackDxos : BaseDxos, IPackDxos
    {
        public PackDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SPack, PackDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Libelle, opt => opt.MapFrom(src => src.Libelle))
                  .ForMember(dst => dst.Taux, opt => opt.MapFrom(src => src.Taux))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreatePackCommand, SPack>()
                  .ForMember(dst => dst.Libelle, opt => opt.MapFrom(src => src.Libelle))
                  .ForMember(dst => dst.Taux, opt => opt.MapFrom(src => src.Taux))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdatePackCommand, SPack>()
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

        public SPack MapCreateRequesttoPack(CreatePackCommand request)
        {
            return _mapper.Map<CreatePackCommand, SPack>(request);
        }

        public PackDto MapPackDto(SPack PackModel)
        {
            return _mapper.Map<SPack, PackDto>(PackModel);
        }

        public SPack MapUpdateRequesttoPack(UpdatePackCommand request)
        {
            return _mapper.Map<UpdatePackCommand, SPack>(request);
        }
    }
}
