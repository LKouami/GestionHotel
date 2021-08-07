using GestionHotel.Model.Dtos;
using Newtonsoft.Json;

namespace GestionHotel.Domain.Queries.EtatEspace
{
    public class GetEtatEspacesQuery : QueryListBase<PagedResults<EtatEspaceDto>>
    {
        public GetEtatEspacesQuery() : base()
        {

        }
        public GetEtatEspacesQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}