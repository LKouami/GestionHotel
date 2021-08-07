using AutoMapper;
using GestionHotel.Model.Dtos;
using GestionHotel.Model.Models;
using GestionHotel.Domain.Dxos.Common;

namespace GestionHotel.Domain.Dxos
{
    public class LocationvueDxos : BaseDxos, ILocationvueDxos
    {
        public LocationvueDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Locationvue, LocationvueDto>()
                  .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dst => dst.DateArriveePrevue, opt => opt.MapFrom(src => src.DateArriveePrevue))
                  .ForMember(dst => dst.DateArrivee, opt => opt.MapFrom(src => src.DateArrivee))
                  .ForMember(dst => dst.DateDepart, opt => opt.MapFrom(src => src.DateDepart))
                  .ForMember(dst => dst.DateDepartPrevue, opt => opt.MapFrom(src => src.DateDepartPrevue))
                  .ForMember(dst => dst.NbPersonne, opt => opt.MapFrom(src => src.NbPersonne))
                  .ForMember(dst => dst.Modalite, opt => opt.MapFrom(src => src.Modalite))
                  .ForMember(dst => dst.OrigineLocation, opt => opt.MapFrom(src => src.OrigineLocation))
                  .ForMember(dst => dst.Reduction, opt => opt.MapFrom(src => src.Reduction))
                  .ForMember(dst => dst.PrixApayer, opt => opt.MapFrom(src => src.PrixApayer))
                  .ForMember(dst => dst.Observation, opt => opt.MapFrom(src => src.Observation))
                  .ForMember(dst => dst.ClNom, opt => opt.MapFrom(src => src.ClNom))
                  .ForMember(dst => dst.ClPrenom, opt => opt.MapFrom(src => src.ClPrenom))
                  .ForMember(dst => dst.ClNationalite, opt => opt.MapFrom(src => src.ClNationalite))
                  .ForMember(dst => dst.ClEmail, opt => opt.MapFrom(src => src.ClEmail))
                  .ForMember(dst => dst.ClDateNaissance, opt => opt.MapFrom(src => src.ClDateNaissance))
                  .ForMember(dst => dst.ClDomicileHabituel, opt => opt.MapFrom(src => src.ClDomicileHabituel))
                  .ForMember(dst => dst.ClTel, opt => opt.MapFrom(src => src.ClTel))
                  .ForMember(dst => dst.PaLibelle, opt => opt.MapFrom(src => src.PaLibelle))
                  .ForMember(dst => dst.PaTaux, opt => opt.MapFrom(src => src.PaTaux))
                  .ForMember(dst => dst.EsNumero, opt => opt.MapFrom(src => src.EsNumero))
                  .ForMember(dst => dst.EsNom, opt => opt.MapFrom(src => src.EsNom))
                  .ForMember(dst => dst.EsSituation, opt => opt.MapFrom(src => src.EsSituation))
                  .ForMember(dst => dst.EsPrix, opt => opt.MapFrom(src => src.EsPrix))
                  .ForMember(dst => dst.EsDescription, opt => opt.MapFrom(src => src.EsDescription))
                  .ForMember(dst => dst.OrNom, opt => opt.MapFrom(src => src.OrNom))
                  .ForMember(dst => dst.OrEmail, opt => opt.MapFrom(src => src.OrEmail))
                  .ForMember(dst => dst.OrTel, opt => opt.MapFrom(src => src.OrTel))
                  .ForMember(dst => dst.OrId, opt => opt.MapFrom(src => src.OrId))
                  .ForMember(dst => dst.EsId, opt => opt.MapFrom(src => src.EsId))
                  .ForMember(dst => dst.PaId, opt => opt.MapFrom(src => src.PaId))
                  .ForMember(dst => dst.ClId, opt => opt.MapFrom(src => src.ClId))
                  .ForMember(dst => dst.OrAdresse, opt => opt.MapFrom(src => src.OrAdresse))
                  .ForMember(dst => dst.EtatLocation, opt => opt.MapFrom(src => src.EtatLocation))
                  .ForMember(dst => dst.Status, opt => opt.MapFrom(src => src.Status))
                  .ForMember(dst => dst.ModifiedAt, opt => opt.MapFrom(src => src.ModifiedAt))
                  .ForMember(dst => dst.ModifiedBy, opt => opt.MapFrom(src => src.ModifiedBy))
                    ;

                
            });

            _mapper = config.CreateMapper();
        }

        public LocationvueDto MapLocationvueDto(Locationvue LocationvueModel)
        {
            return _mapper.Map<Locationvue, LocationvueDto>(LocationvueModel);
        }

    }
}
