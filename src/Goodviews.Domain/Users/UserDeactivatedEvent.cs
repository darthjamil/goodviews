using Goodviews.Domain;
using System;

namespace Goodviews.Users
{
    public class UserDeactivatedEvent : Event
    {
        public Guid UserId { get; set; }
    }
}
