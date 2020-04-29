using Goodviews.Domain;

namespace Goodviews.Users
{
    public class UserDeactivatedEvent : Event
    {
        public string UserId { get; set; }
    }
}
