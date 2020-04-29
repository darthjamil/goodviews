using System;

namespace Goodviews.Feeds
{
    public interface IFeedService
    {
        /// <summary>
        /// Retrieves a user's real-time feed. This service can be polled.
        /// </summary>
        /// <param name="userId">The user whose feed we're getting</param>
        /// <param name="fromDate">Start viewing from which date (usually UTC-Now)</param>
        /// <param name="toDate">Return feed events until this date</param>
        /// <returns>A paginated list of events for this user to see, ordered by date descending</returns>
        public UserFeed GetFeed(string userId, DateTime fromDate, DateTime toDate);
    }
}
