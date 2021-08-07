using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.TypeEspace
{
    public class GetTypeEspacesQuery : QueryListBase<PagedResults<TypeEspaceDto>>
    {
        public GetTypeEspacesQuery() : base()
        {

        }
        public GetTypeEspacesQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}