using System;

namespace Goodviews.Users
{
    public class FriendRequest
    {
        public User Requester { get; set; }
        public DateTime DateRequestedUtc { get; set; }
    }
}
