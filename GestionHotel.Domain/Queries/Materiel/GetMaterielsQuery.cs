using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.Materiel
{
    public class GetMaterielsQuery : QueryListBase<PagedResults<MaterielDto>>
    {
        public GetMaterielsQuery() : base()
        {

        }
        public GetMaterielsQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}