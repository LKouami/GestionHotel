using AutoMapper;
using GestionHotel.Domain.Commands.Materiel;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class MaterielDxos : BaseDxos, IMaterielDxos
    {
        public MaterielDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SMateriel, MaterielDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Quantite, opt => opt.MapFrom(src => src.Quantite))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateMaterielCommand, SMateriel>()
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Quantite, opt => opt.MapFrom(src => src.Quantite))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateMaterielCommand, SMateriel>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.Nom, opt => opt.MapFrom(src => src.Nom))
                  .ForMember(dst => dst.Quantite, opt => opt.MapFrom(src => src.Quantite))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SMateriel MapCreateRequesttoMateriel(CreateMaterielCommand request)
        {
            return _mapper.Map<CreateMaterielCommand, SMateriel>(request);
        }

        public MaterielDto MapMaterielDto(SMateriel MaterielModel)
        {
            return _mapper.Map<SMateriel, MaterielDto>(MaterielModel);
        }

        public SMateriel MapUpdateRequesttoMateriel(UpdateMaterielCommand request)
        {
            return _mapper.Map<UpdateMaterielCommand, SMateriel>(request);
        }
    }
}
