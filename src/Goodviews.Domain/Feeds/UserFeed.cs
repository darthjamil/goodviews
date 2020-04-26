using System;
using System.Collections.Generic;

namespace Goodviews.Domain
{
    public class UserFeed
    {
        /// <summary>
        /// Who is this feed for
        /// </summary>
        public Guid FeedForUserId { get; set; }
        public DateTime LastViewed { get; set; }
        public List<FeedEvent> FeedEvents { get; set; }
    }
}
