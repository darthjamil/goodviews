using Goodviews.Services;

namespace Goodviews.Users
{
    public class UserDeactivatedEvent : Event
    {
        public string UserId { get; set; }
    }
}
