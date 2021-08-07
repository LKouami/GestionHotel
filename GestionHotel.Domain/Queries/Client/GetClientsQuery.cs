using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.Client
{
    public class GetClientsQuery : QueryListBase<PagedResults<ClientDto>>
    {
        public GetClientsQuery() : base()
        {

        }
        public GetClientsQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}