using System;
using System.Collections.Generic;

namespace Goodviews.Users
{
    public class FriendRequests
    {
        public Guid UserId { get; set; }
        public List<Guid> RequesterIds { get; set; }
    }
}
