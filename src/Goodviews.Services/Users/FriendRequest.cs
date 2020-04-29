using System;

namespace Goodviews.Users
{
    public class FriendRequest
    {
        public string Id => $"friend-request/{RequesteeUserId}/{RequesterUserId}";
        public string RequesterUserId { get; set; }
        public string RequesteeUserId { get; set; }
        public DateTime DateRequestedUtc { get; set; }
    }
}
