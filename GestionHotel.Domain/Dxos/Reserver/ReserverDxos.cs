using AutoMapper;
using GestionHotel.Domain.Commands.Reserver;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class ReserverDxos : BaseDxos, IReserverDxos
    {
        public ReserverDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SReserver, ReserverDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.NbPersonne, opt => opt.MapFrom(src => src.NbPersonne))
                  .ForMember(dst => dst.DateArrivee, opt => opt.MapFrom(src => src.DateArrivee))
                  .ForMember(dst => dst.DateArriveePrevue, opt => opt.MapFrom(src => src.DateArriveePrevue))
                  .ForMember(dst => dst.DateDepart, opt => opt.MapFrom(src => src.DateDepart))
                  .ForMember(dst => dst.DateDepartPrevue, opt => opt.MapFrom(src => src.DateDepartPrevue))
                  .ForMember(dst => dst.Modalite, opt => opt.MapFrom(src => src.Modalite))
                  .ForMember(dst => dst.OrigineReservation, opt => opt.MapFrom(src => src.OrigineReservation))
                  .ForMember(dst => dst.Reduction, opt => opt.MapFrom(src => src.Reduction))
                  .ForMember(dst => dst.Observation, opt => opt.MapFrom(src => src.Observation))
                  .ForMember(dst => dst.ClientId, opt => opt.MapFrom(src => src.ClientId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                cfg.CreateMap<CreateReserverCommand, SReserver>()
                  .ForMember(dst => dst.NbPersonne, opt => opt.MapFrom(src => src.NbPersonne))
                  .ForMember(dst => dst.DateArrivee, opt => opt.MapFrom(src => src.DateArrivee))
                  .ForMember(dst => dst.DateArriveePrevue, opt => opt.MapFrom(src => src.DateArriveePrevue))
                  .ForMember(dst => dst.DateDepart, opt => opt.MapFrom(src => src.DateDepart))
                  .ForMember(dst => dst.DateDepartPrevue, opt => opt.MapFrom(src => src.DateDepartPrevue))
                  .ForMember(dst => dst.Modalite, opt => opt.MapFrom(src => src.Modalite))
                  .ForMember(dst => dst.OrigineReservation, opt => opt.MapFrom(src => src.OrigineReservation))
                  .ForMember(dst => dst.Reduction, opt => opt.MapFrom(src => src.Reduction))
                  .ForMember(dst => dst.Observation, opt => opt.MapFrom(src => src.Observation))
                  .ForMember(dst => dst.ClientId, opt => opt.MapFrom(src => src.ClientId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.CreatedBy))
                  ;


                cfg.CreateMap<UpdateReserverCommand, SReserver>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.NbPersonne, opt => opt.MapFrom(src => src.NbPersonne))
                  .ForMember(dst => dst.DateArrivee, opt => opt.MapFrom(src => src.DateArrivee))
                  .ForMember(dst => dst.DateArriveePrevue, opt => opt.MapFrom(src => src.DateArriveePrevue))
                  .ForMember(dst => dst.DateDepart, opt => opt.MapFrom(src => src.DateDepart))
                  .ForMember(dst => dst.DateDepartPrevue, opt => opt.MapFrom(src => src.DateDepartPrevue))
                  .ForMember(dst => dst.Modalite, opt => opt.MapFrom(src => src.Modalite))
                  .ForMember(dst => dst.OrigineReservation, opt => opt.MapFrom(src => src.OrigineReservation))
                  .ForMember(dst => dst.Reduction, opt => opt.MapFrom(src => src.Reduction))
                  .ForMember(dst => dst.Observation, opt => opt.MapFrom(src => src.Observation))
                  .ForMember(dst => dst.ClientId, opt => opt.MapFrom(src => src.ClientId))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                  ;
            });

            _mapper = config.CreateMapper();
        }

        public SReserver MapCreateRequesttoReserver(CreateReserverCommand request)
        {
            return _mapper.Map<CreateReserverCommand, SReserver>(request);
        }

        public ReserverDto MapReserverDto(SReserver ReserverModel)
        {
            return _mapper.Map<SReserver, ReserverDto>(ReserverModel);
        }

        public SReserver MapUpdateRequesttoReserver(UpdateReserverCommand request)
        {
            return _mapper.Map<UpdateReserverCommand, SReserver>(request);
        }
    }
}
