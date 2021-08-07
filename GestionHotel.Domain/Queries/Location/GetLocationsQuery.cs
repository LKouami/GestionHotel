using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.Location
{
    public class GetLocationsQuery : QueryListBase<PagedResults<LocationDto>>
    {
        public GetLocationsQuery() : base()
        {

        }
        public GetLocationsQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}