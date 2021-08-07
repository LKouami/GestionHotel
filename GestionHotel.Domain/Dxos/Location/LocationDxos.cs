using AutoMapper;
using GestionHotel.Domain.Commands.Location;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class LocationDxos : BaseDxos, ILocationDxos
    {
        public LocationDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SLocation, LocationDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.DateArriveePrevue, opt => opt.MapFrom(src => src.DateArriveePrevue))
                  .ForMember(dst => dst.DateArrivee, opt => opt.MapFrom(src => src.DateArrivee))
                  .ForMember(dst => dst.DateDepart, opt => opt.MapFrom(src => src.DateDepart))
                  .ForMember(dst => dst.DateDepartPrevue, opt => opt.MapFrom(src => src.DateDepartPrevue))
                  .ForMember(dst => dst.NbPersonne, opt => opt.MapFrom(src => src.NbPersonne))
                  .ForMember(dst => dst.Modalite, opt => opt.MapFrom(src => src.Modalite))
                  .ForMember(dst => dst.OrigineLocation, opt => opt.MapFrom(src => src.OrigineLocation))
                  .ForMember(dst => dst.Reduction, opt => opt.MapFrom(src => src.Reduction))
                  .ForMember(dst => dst.OrganismePayeurId, opt => opt.MapFrom(src => src.OrganismePayeurId))
                  .ForMember(dst => dst.Observation, opt => opt.MapFrom(src => src.Observation))
                  .ForMember(dst => dst.PrixApayer, opt => opt.MapFrom(src => src.PrixApayer))
                  .ForMember(dst => dst.ClientId, opt => opt.MapFrom(src => src.ClientId))
                  .ForMember(dst => dst.PackId, opt => opt.MapFrom(src => src.PackId))
                  .ForMember(dst => dst.EtatLocation, opt => opt.MapFrom(src => src.EtatLocation))
                  .ForMember(dst => dst.EspaceId, opt => opt.MapFrom(src => src.EspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateLocationCommand, SLocation>()
                  .ForMember(dst => dst.DateArriveePrevue, opt => opt.MapFrom(src => src.DateArriveePrevue))
                  .ForMember(dst => dst.DateArrivee, opt => opt.MapFrom(src => src.DateArrivee))
                  .ForMember(dst => dst.DateDepart, opt => opt.MapFrom(src => src.DateDepart))
                  .ForMember(dst => dst.DateDepartPrevue, opt => opt.MapFrom(src => src.DateDepartPrevue))
                  .ForMember(dst => dst.NbPersonne, opt => opt.MapFrom(src => src.NbPersonne))
                  .ForMember(dst => dst.Modalite, opt => opt.MapFrom(src => src.Modalite))
                  .ForMember(dst => dst.OrigineLocation, opt => opt.MapFrom(src => src.OrigineLocation))
                  .ForMember(dst => dst.Reduction, opt => opt.MapFrom(src => src.Reduction))
                  .ForMember(dst => dst.OrganismePayeurId, opt => opt.MapFrom(src => src.OrganismePayeurId))
                  .ForMember(dst => dst.PrixApayer, opt => opt.MapFrom(src => src.PrixApayer))
                  .ForMember(dst => dst.Observation, opt => opt.MapFrom(src => src.Observation))
                  .ForMember(dst => dst.ClientId, opt => opt.MapFrom(src => src.ClientId))
                  .ForMember(dst => dst.PackId, opt => opt.MapFrom(src => src.PackId))
                  .ForMember(dst => dst.EtatLocation, opt => opt.MapFrom(src => src.EtatLocation))
                  .ForMember(dst => dst.EspaceId, opt => opt.MapFrom(src => src.EspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateLocationCommand, SLocation>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.DateArriveePrevue, opt => opt.MapFrom(src => src.DateArriveePrevue))
                  .ForMember(dst => dst.DateArrivee, opt => opt.MapFrom(src => src.DateArrivee))
                  .ForMember(dst => dst.DateDepart, opt => opt.MapFrom(src => src.DateDepart))
                  .ForMember(dst => dst.DateDepartPrevue, opt => opt.MapFrom(src => src.DateDepartPrevue))
                  .ForMember(dst => dst.NbPersonne, opt => opt.MapFrom(src => src.NbPersonne))
                  .ForMember(dst => dst.Modalite, opt => opt.MapFrom(src => src.Modalite))
                  .ForMember(dst => dst.OrigineLocation, opt => opt.MapFrom(src => src.OrigineLocation))
                  .ForMember(dst => dst.Reduction, opt => opt.MapFrom(src => src.Reduction))
                  .ForMember(dst => dst.OrganismePayeurId, opt => opt.MapFrom(src => src.OrganismePayeurId))
                  .ForMember(dst => dst.PrixApayer, opt => opt.MapFrom(src => src.PrixApayer))
                  .ForMember(dst => dst.Observation, opt => opt.MapFrom(src => src.Observation))
                  .ForMember(dst => dst.ClientId, opt => opt.MapFrom(src => src.ClientId))
                  .ForMember(dst => dst.PackId, opt => opt.MapFrom(src => src.PackId))
                  .ForMember(dst => dst.EtatLocation, opt => opt.MapFrom(src => src.EtatLocation))
                  .ForMember(dst => dst.EspaceId, opt => opt.MapFrom(src => src.EspaceId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SLocation MapCreateRequesttoLocation(CreateLocationCommand request)
        {
            return _mapper.Map<CreateLocationCommand, SLocation>(request);
        }

        public LocationDto MapLocationDto(SLocation LocationModel)
        {
            return _mapper.Map<SLocation, LocationDto>(LocationModel);
        }

        public SLocation MapUpdateRequesttoLocation(UpdateLocationCommand request)
        {
            return _mapper.Map<UpdateLocationCommand, SLocation>(request);
        }
    }
}
