using System;

namespace Goodviews.Domain
{
    public class UserDeactivatedEvent : Event
    {
        public Guid UserId { get; set; }
    }
}
