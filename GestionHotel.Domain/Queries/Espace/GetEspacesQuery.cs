using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.Espace
{
    public class GetEspacesQuery : QueryListBase<PagedResults<EspaceDto>>
    {
        public GetEspacesQuery() : base()
        {

        }
        public GetEspacesQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}