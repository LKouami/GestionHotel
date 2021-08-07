using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.Clientvue
{
    public class GetClientvuesQuery : QueryListBase<PagedResults<ClientvueDto>>
    {
        public GetClientvuesQuery() : base()
        {

        }
        public GetClientvuesQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}