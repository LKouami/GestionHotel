using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.Espacevue
{
    public class GetEspacevuesQuery : QueryListBase<PagedResults<EspacevueDto>>
    {
        public GetEspacevuesQuery() : base()
        {

        }
        public GetEspacevuesQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}