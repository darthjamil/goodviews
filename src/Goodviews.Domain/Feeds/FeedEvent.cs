using System;

namespace Goodviews.Domain
{
    public class FeedEvent
    {
        /// <summary>
        /// The ID of the user who caused this event
        /// </summary>
        public Guid UserId { get; set; }
        // TODO Add feed details
    }
}
