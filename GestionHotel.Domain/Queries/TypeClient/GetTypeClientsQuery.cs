using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.TypeClient
{
    public class GetTypeClientsQuery : QueryListBase<PagedResults<TypeClientDto>>
    {
        public GetTypeClientsQuery() : base()
        {

        }
        public GetTypeClientsQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}