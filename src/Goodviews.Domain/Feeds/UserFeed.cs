using System;
using System.Collections.Generic;

namespace Goodviews.Feeds
{
    /// <summary>
    /// Represents a user's feed in a given month. The feed is generated from raw data
    /// on a regular basis as part of a batch process. Only the current month's feed is
    /// updated; once a month has passed, the feed is accessible for reads but does not
    /// need to be written to.
    /// </summary>
    public class UserFeed
    {
        public string Id => $"user-feeds/{UserId}/{DateGenerated.Year}/{DateGenerated.Month}";
        /// <summary>
        /// Who the feed is for
        /// </summary>
        public string UserId { get; set; }
        public DateTime DateGenerated { get; set; }
        public List<FeedEvent> FeedEvents { get; set; }
    }
}
