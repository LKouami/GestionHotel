using GestionHotel.Model.Dtos;

namespace GestionHotel.Domain.Queries.User
{
    public class GetUsersQuery : QueryListBase<PagedResults<UserDto>>
    {
        public GetUsersQuery() : base()
        {

        }
        public GetUsersQuery(string search, string sort, string direction, int pageIndex, int pageSize) :
            base(search, sort, direction, pageIndex, pageSize)
        {

        }
    }
}