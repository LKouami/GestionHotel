using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.OrganismePayeur
{
    public class GetOrganismePayeursQuery : QueryListBase<PagedResults<OrganismePayeurDto>>
    {
        public GetOrganismePayeursQuery() : base()
        {

        }
        public GetOrganismePayeursQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}