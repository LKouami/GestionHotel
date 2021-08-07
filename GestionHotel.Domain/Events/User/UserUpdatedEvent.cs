using MediatR;

namespace GestionHotel.Domain.Events.User
{
    public class UserUpdatedEvent : INotification
    {
        public long UserId { get; }

        public UserUpdatedEvent(long userId)
        {
            UserId = userId;
        }
    }
}