using System;
using System.Collections.Generic;

namespace Goodviews.Feeds
{
    public class UserFeed
    {
        /// <summary>
        /// Who the feed is for
        /// </summary>
        public Guid FeedForUserId { get; set; }
        public DateTime LastViewed { get; set; }
        public List<FeedEvent> FeedEvents { get; set; }
    }
}
