using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.AffectationMaterielvue
{
    public class GetAffectationMaterielvuesQuery : QueryListBase<PagedResults<AffectationMaterielvueDto>>
    {
        public GetAffectationMaterielvuesQuery() : base()
        {

        }
        public GetAffectationMaterielvuesQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}