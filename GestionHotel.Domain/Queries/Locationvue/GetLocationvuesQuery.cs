using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.Locationvue
{
    public class GetLocationvuesQuery : QueryListBase<PagedResults<LocationvueDto>>
    {
        public GetLocationvuesQuery() : base()
        {

        }
        public GetLocationvuesQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}