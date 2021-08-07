using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.AffectationMateriel
{
    public class GetAffectationMaterielsQuery : QueryListBase<PagedResults<AffectationMaterielDto>>
    {
        public GetAffectationMaterielsQuery() : base()
        {

        }
        public GetAffectationMaterielsQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}