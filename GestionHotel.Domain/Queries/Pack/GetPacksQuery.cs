using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.Pack
{
    public class GetPacksQuery : QueryListBase<PagedResults<PackDto>>
    {
        public GetPacksQuery() : base()
        {

        }
        public GetPacksQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}